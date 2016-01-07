using System.Net.Mail;
using System.Text;

namespace SCM.RF.Server.Utility
{
    /// <summary>
    /// 邮件
    /// </summary>
    public class MailHelper
    {
        private string _mailFrom;
        private string _mailServer;
        private string _mailUserName;
        private string _mailPassword;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="From">写信人</param>
        /// <param name="Server">服务器</param>
        /// <param name="UserName">用户名</param>
        /// <param name="Password">密码</param>
        public MailHelper(string From, string Server, string UserName, string Password)
        {
            this._mailFrom = From;
            this._mailServer = Server;
            this._mailUserName = UserName;
            this._mailPassword = Password;
        }

        /// <summary>
        /// 发送邮件
        /// </summary>
        /// <param name="MailTo">收件人</param>
        /// <param name="MailSubject">标题</param>
        /// <param name="MailBody">内容</param>
        /// <returns></returns>
        public void SendMail(string MailTo, string MailSubject, string MailBody)
        {
            try
            {
                MailMessage mail = new MailMessage();

                mail.From = new System.Net.Mail.MailAddress(this._mailFrom, this._mailFrom);

                if (MailTo.IndexOf(";") > 0)
                {
                    string[] mMailTo = MailTo.Substring(0, MailTo.Length - 1).Split(';');
                    foreach (string sMailTo in mMailTo)
                    {
                        if (!string.IsNullOrEmpty(sMailTo))
                        {
                            mail.To.Add(sMailTo);
                        }
                    }
                }
                else
                {
                    mail.To.Add(MailTo);
                }
                mail.Subject = MailSubject;
                mail.Body = MailBody;
                mail.IsBodyHtml = true;
                mail.BodyEncoding = Encoding.GetEncoding("GB2312");

                System.Net.Mail.SmtpClient SmtpMail = new System.Net.Mail.SmtpClient();
                SmtpMail.Host = this._mailServer;
                SmtpMail.UseDefaultCredentials = false;
                SmtpMail.Credentials = new System.Net.NetworkCredential(this._mailUserName, this._mailPassword);
                SmtpMail.DeliveryMethod = SmtpDeliveryMethod.Network;
                SmtpMail.SendCompleted += new SendCompletedEventHandler(SmtpMail_SendCompleted);

                SmtpMail.Send(mail);
            }
            catch
            {

            }
        }

        void SmtpMail_SendCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            //throw new System.NotImplementedException();
        }
    }
}
