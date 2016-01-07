using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using System.Xml;
using SCM.RF.Client.BizProcess.Sys;
using SCM.RF.Client.Tool.Controls.Common;
using SCM.RF.Client.Utility;
using System.Diagnostics;

namespace SCM.RF.Client.Tool.Controls.Login
{
    public partial class UCSetting : UCBasicControl
    {
        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="rf"></param>
        public UCSetting(RF rf)
            : base(rf)
        {
            InitializeComponent();
        }

        #region 重载 override

        public override void Init()
        {
            LoadData();

            this.txtIP.Focus();
        }

        public override void Proc(EnMessageType type)
        {
            if (type == EnMessageType.A)
            {
                btnCancel_Click(null, null);
            }
            else if (type == EnMessageType.B)
            {
                FocusIP();
            }
            else if (type == EnMessageType.C)
            {
                FocusPort();
            }
            else if (type == EnMessageType.D)
            {
                FocusIP();
            }
            else if (type == EnMessageType.E)
            {
                FocusPort();
            }
            else
            {

            }
        }

        #endregion

        #region CLICK

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.btnSave.Enabled = true;
            string ip = this.txtIP.Text.Trim();

            string port = this.txtPort.Text.Trim();

            if (ip.Length == 0)
            {
                base.ShowMessage("请输入IP地址！", false, EnMessageType.B, false);

                return;
            }

            if (port.Length == 0)
            {
                base.ShowMessage("请输入端口号！", false, EnMessageType.C, false);

                return;
            }

            if (!StringHelper.ISIP(ip))
            {
                base.ShowMessage("IP地址格式错误！", false, EnMessageType.D, false);

                return;
            }

            if (!StringHelper.ISInt32(port))
            {
                base.ShowMessage("端口格式错误！", false, EnMessageType.E, false);

                return;
            }

            Save(ip, port);

            this.btnSave.Enabled = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.btnCancel.Enabled = false;
            base.Exit();
            this.btnCancel.Enabled = true;
        }

        private void BtnScan_Click(object sender, EventArgs e)
        {
            this.BtnScan.Enabled = false;

            try
            {
                string path = Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase), @"Resources\SCANWEDGE.EXE");

                path = path.Replace(@"file:\", "");

                if (File.Exists(path))
                {
                    Process process = new Process();
                    ProcessStartInfo info = new ProcessStartInfo();
                    info.FileName = path;
                    process.StartInfo = info;
                    process.Start();
                }
                else
                {
                    base.ShowMessage("未找到执行文件！", false, EnMessageType.B, false);
                }
            }
            catch (Exception ex)
            {
                base.ShowMessage(ex.Message, false, EnMessageType.B, false);
            }

            this.BtnScan.Enabled = true;
        }

        private void btnWifi_Click(object sender, EventArgs e)
        {
            this.btnWifi.Enabled = false;
            Process process = new Process();
            ProcessStartInfo info = new ProcessStartInfo();
            string path = @"\Windows\WCLAUNCH.exe";
            info.FileName = path;
            process.StartInfo = info;
            process.Start();
            this.btnWifi.Enabled = true;
        }

        private void btnIME_Click(object sender, EventArgs e)
        {
            this.btnIME.Enabled = false;
            //WinceHelper.HideIme();
            this.btnIME.Enabled = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.RF.Close();
        }

        private void txtIP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;

                string ip = this.txtIP.Text.Trim();

                if (ip.Length == 0)
                {
                    base.ShowMessage("请输入IP地址！", false, EnMessageType.B, false);

                    return;
                }

                if (!StringHelper.ISIP(ip))
                {
                    base.ShowMessage("IP地址格式错误！", false, EnMessageType.D, false);

                    return;
                }

                FocusPort();
            }
        }

        private void txtPort_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;

                btnSave_Click(null, null);
            }
        }

        #endregion

        #region FOCUS
        private void txtIP_GotFocus(object sender, EventArgs e)
        {
            this.pbIP.BackColor = Color.Yellow;
        }

        private void txtIP_LostFocus(object sender, EventArgs e)
        {
            this.pbIP.BackColor = Color.White;
        }

        private void txtPort_GotFocus(object sender, EventArgs e)
        {
            this.pbPort.BackColor = Color.Yellow;
        }

        private void txtPort_LostFocus(object sender, EventArgs e)
        {
            this.pbPort.BackColor = Color.White;
        }
        #endregion

        #region PRIVATE FUNCTION

        private void FocusIP()
        {
            this.txtIP.Text = string.Empty;
            this.txtIP.Focus();
        }

        private void FocusPort()
        {
            this.txtPort.Text = string.Empty;
            this.txtPort.Focus();
        }

        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="ip"></param>
        /// <param name="port"></param>
        private void Save(string ip, string port)
        {
            XmlDocument doc = new XmlDocument();
            string path = string.Concat(Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase), @"\app.xml").Replace(@"file:\", "");
            doc.Load(path);
            doc.SelectSingleNode("app/ServerIp").InnerText = ip;
            doc.SelectSingleNode("app/ServerPort").InnerText = port;
            doc.Save(path);

            InstanceBP.SystemInstance = null;

            base.ShowMessage("保存成功！", false, EnMessageType.A, true);
        }

        /// <summary>
        /// 加载数据
        /// </summary>
        private void LoadData()
        {
            XmlDocument doc = new XmlDocument();
            string path = string.Concat(Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase), @"\app.xml");
            doc.Load(path);
            this.txtIP.Text = doc.SelectSingleNode("app/ServerIp").InnerText;
            this.txtPort.Text = doc.SelectSingleNode("app/ServerPort").InnerText;
        }

        #endregion

        #region 供快捷键调用

        /// <summary>
        /// 退出快捷键
        /// </summary>
        public void HookExit()
        {
            btnCancel_Click(null, null);
        }

        public void HookSave()
        {
            btnSave_Click(null, null);
        }

        #endregion
    }
}
