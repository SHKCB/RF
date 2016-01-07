using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Windows.Forms;
using SCM.RF.Client.Framework.Core;
using SCM.RF.Client.Tool.Controls.Common;
using SCM.RF.Client.BizEntities.AuthCenter;

/*
 *  ��¼����
 */
namespace SCM.RF.Client.Tool.Controls.Login
{
    public partial class UCLogin : UCBasicControl
    {
        /// <summary>
        /// Ĭ�Ϲ��캯��
        /// </summary>
        public UCLogin(RF rf)
            : base(rf)
        {
            InitializeComponent();
        }

        #region CLICK

        private void btnLogin_Click(object sender, System.EventArgs e)
        {
            this.btnLogin.Enabled = false;
            LoadData();
            this.btnLogin.Enabled = true;
        }

        private void btnReset_Click(object sender, System.EventArgs e)
        {
            this.btnReset.Enabled = false;

            Init();

            this.btnReset.Enabled = true;
        }

        private void btnSetting_Click(object sender, System.EventArgs e)
        {
            this.btnSetting.Enabled = false;
            base.RF.ShowSetting();
            this.btnSetting.Enabled = true;
        }

        private void txtBarCode_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;

                FocusUserName();
            }
        }

        private void txtUserName_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;

                string username = this.txtUserName.Text.Trim();

                if (username.Length > 0)
                {
                    this.FocusPassWord();
                }
                else
                {
                    base.ShowMessage("�������û�����", false, EnMessageType.A, false);
                }
            }
        }

        private void txtPassWord_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;

                btnLogin_Click(null, null);
            }
        }

        #endregion

        #region FOCUS

        private void txtBarCode_GotFocus(object sender, System.EventArgs e)
        {
            this.pbUserName.BackColor = Color.White;
            this.pbPassWord.BackColor = Color.White;
        }

        private void txtUserName_GotFocus(object sender, System.EventArgs e)
        {
            this.pbUserName.BackColor = Color.Yellow;
            this.pbPassWord.BackColor = Color.White;
        }

        private void txtUserName_LostFocus(object sender, System.EventArgs e)
        {
            this.pbUserName.BackColor = Color.White;
        }

        private void txtPassWord_GotFocus(object sender, System.EventArgs e)
        {
            this.pbUserName.BackColor = Color.White;
            this.pbPassWord.BackColor = Color.Yellow;
        }

        private void txtPassWord_LostFocus(object sender, System.EventArgs e)
        {
            this.pbPassWord.BackColor = Color.White;
        }
        #endregion

        #region PRIVATE FUNCTION

        private void FocusUserName()
        {
            this.txtUserName.SelectAll();
            this.txtUserName.Focus();
        }

        private void FocusPassWord()
        {
            this.txtPassWord.SelectAll();
            this.txtPassWord.Focus();
        }

        /// <summary>
        /// ��¼
        /// </summary>
        private void LoadData()
        {
            this.btnLogin.Enabled = false;

            string username = this.txtUserName.Text.Trim();

            string password = this.txtPassWord.Text.Trim();

            if (username.Length == 0)
            {
                base.ShowMessage("�������û�����", false, EnMessageType.A, false);

                return;
            }

            if (password.Length == 0)
            {
                base.ShowMessage("���������룡", false, EnMessageType.B, false);

                return;
            }

            bool hasError = false;

            //bool needUpdate = SCM.RF.Client.BizProcess.Sys.InstanceBP.NeedUpdate(out hasError);

            //if (needUpdate)
            //{
            //    base.ShowMessage("ϵͳ�и��£�", false, EnMessageType.C);

            //    return;
            //}
            //else
            //{
            //    if (hasError)
            //    {
            //        base.ShowMessage("�������ͬ��ʧ�ܣ������ԣ�", false, EnMessageType.A, false);

            //        return;
            //    }
            //}

            #region ��¼��֤

            IPHostEntry ipHost = Dns.GetHostEntry(Dns.GetHostName());
            IPAddress ip = ipHost.AddressList[0];

            RemoteServer param = new RemoteServer(SCM.RF.Client.BizProcess.Sys.InstanceBP.SystemInstance.ServerIp, int.Parse(username) + 3000);
            param.Connect();

            if (param.Connected)
            {
                UserViewEntity entity = new UserViewEntity();
                entity.ApplicationID = SCM.RF.Client.BizProcess.Sys.InstanceBP.SystemInstance.ApplicationID;
                entity.WkNo = username;
                entity.Password = password;
                entity.LocalIP = ip.ToString();

                entity = new SCM.RF.Client.BizProcess.Login.LoginBP().LoginIn(entity, param);

                if (entity != null && entity.IsLoggedIn)
                {
                    base.RF.RemoteServer = param;

                    base.RF.UserViewEntity = entity;

                    base.RF.ShowMenu();

                    this.btnLogin.Enabled = true;

                    base.RF.SetUser(entity.UserName);
                }
                else
                {
                    base.ShowMessage("�û������������", false, EnMessageType.A, false);
                }
            }
            else
            {
                base.ShowMessage("����������ʧ�ܣ�", false, EnMessageType.A, false);
            }

            #endregion
        }

        private new void Update()
        {
            //�������³���
            Process process = new Process();
            ProcessStartInfo info = new ProcessStartInfo();
            info.FileName = SCM.RF.Client.BizProcess.Sys.InstanceBP.SystemInstance.UpExe;
            process.StartInfo = info;
            process.Start();
            Application.Exit();
        }

        #endregion

        #region ���� override

        public override void Init()
        {
            base.SetTitle("ϵͳ��¼");

            this.txtUserName.Text = string.Empty;

            this.txtPassWord.Text = string.Empty;

            FocusUserName();
        }

        public override void Proc(EnMessageType type)
        {
            if (type == EnMessageType.A)
            {
                this.FocusUserName();
            }
            else if (type == EnMessageType.B)
            {
                this.FocusPassWord();
            }
            else if (type == EnMessageType.C)
            {
                this.Update();
            }
            else
            {
                this.FocusUserName();
            }
        }

        #endregion

        #region ����ݼ�����

        /// <summary>
        /// ��½��ݼ�
        /// </summary>
        public void HookLogin()
        {
            btnLogin_Click(null, null);
        }

        /// <summary>
        /// ���ÿ�ݼ�
        /// </summary>
        public void HookReset()
        {
            btnReset_Click(null, null);
        }

        /// <summary>
        /// ���ÿ�ݼ�
        /// </summary>
        public void HookSetting()
        {
            btnSetting_Click(null, null);
        }

        #endregion
    }
}
