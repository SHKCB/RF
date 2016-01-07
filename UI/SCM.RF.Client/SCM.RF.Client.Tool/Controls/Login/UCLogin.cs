using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Windows.Forms;
using SCM.RF.Client.Framework.Core;
using SCM.RF.Client.Tool.Controls.Common;
using SCM.RF.Client.BizEntities.AuthCenter;

/*
 *  登录界面
 */
namespace SCM.RF.Client.Tool.Controls.Login
{
    public partial class UCLogin : UCBasicControl
    {
        /// <summary>
        /// 默认构造函数
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
                    base.ShowMessage("请输入用户名！", false, EnMessageType.A, false);
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
        /// 登录
        /// </summary>
        private void LoadData()
        {
            this.btnLogin.Enabled = false;

            string username = this.txtUserName.Text.Trim();

            string password = this.txtPassWord.Text.Trim();

            if (username.Length == 0)
            {
                base.ShowMessage("请输入用户名！", false, EnMessageType.A, false);

                return;
            }

            if (password.Length == 0)
            {
                base.ShowMessage("请输入密码！", false, EnMessageType.B, false);

                return;
            }

            bool hasError = false;

            //bool needUpdate = SCM.RF.Client.BizProcess.Sys.InstanceBP.NeedUpdate(out hasError);

            //if (needUpdate)
            //{
            //    base.ShowMessage("系统有更新！", false, EnMessageType.C);

            //    return;
            //}
            //else
            //{
            //    if (hasError)
            //    {
            //        base.ShowMessage("与服务器同步失败，请重试！", false, EnMessageType.A, false);

            //        return;
            //    }
            //}

            #region 登录验证

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
                    base.ShowMessage("用户名或密码错误！", false, EnMessageType.A, false);
                }
            }
            else
            {
                base.ShowMessage("服务器连接失败！", false, EnMessageType.A, false);
            }

            #endregion
        }

        private new void Update()
        {
            //启动更新程序
            Process process = new Process();
            ProcessStartInfo info = new ProcessStartInfo();
            info.FileName = SCM.RF.Client.BizProcess.Sys.InstanceBP.SystemInstance.UpExe;
            process.StartInfo = info;
            process.Start();
            Application.Exit();
        }

        #endregion

        #region 重载 override

        public override void Init()
        {
            base.SetTitle("系统登录");

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

        #region 供快捷键调用

        /// <summary>
        /// 登陆快捷键
        /// </summary>
        public void HookLogin()
        {
            btnLogin_Click(null, null);
        }

        /// <summary>
        /// 重置快捷键
        /// </summary>
        public void HookReset()
        {
            btnReset_Click(null, null);
        }

        /// <summary>
        /// 设置快捷键
        /// </summary>
        public void HookSetting()
        {
            btnSetting_Click(null, null);
        }

        #endregion
    }
}
