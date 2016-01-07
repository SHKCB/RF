using System.Drawing;
using System.Windows.Forms;
using SCM.RF.Client.BizEntities.Picking;
using SCM.RF.Client.BizProcess.Picking;
using SCM.RF.Client.Tool.Controls.Common;

namespace SCM.RF.Client.Tool.Controls.Picking
{
    public partial class UCPicking1 : UCBasicControl
    {
        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="rf"></param>
        public UCPicking1(RF rf)
            : base(rf)
        {
            InitializeComponent();
        }

        #region 重载 override

        public override void Init()
        {
            base.SetTitle("扫描集合单");

            this.FocusContainer();

            this.FocusTaskNo();
        }

        public override void Proc(EnMessageType type)
        {
            if (type == EnMessageType.A)
            {
                this.FocusTaskNo();
            }
            else if (type == EnMessageType.B)
            {
                base.Exit();
            }
            else if (type == EnMessageType.C)
            {
                this.FocusContainer();
            }
            else
            {

            }
        }

        #endregion

        #region CLICK

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            this.btnCancel.Enabled = false;
            base.Cancel();
            this.btnCancel.Enabled = true;
        }

        private void txtTaskNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;

                string txtTaskNo = this.txtTaskNo.Text.Trim().ToUpper();

                if (txtTaskNo.Length > 0)
                {
                    if (SCM.RF.Client.Utility.StringHelper.ISStringInt32(txtTaskNo))
                    {
                        FocusContainer();
                    }
                    else
                    {
                        base.ShowMessage("集合单格式错误！", false, EnMessageType.A, false);
                    }
                }
            }
        }

        private void txtContainerID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;

                string strContainerID = this.txtContainerID.Text.Trim().ToUpper();

                string strTaskNo = this.txtTaskNo.Text.Trim().ToUpper();

                if (strTaskNo.Length == 0)
                {
                    base.ShowMessage("请输入集合单号！", false, EnMessageType.A, false);

                    return;
                }

                if (strContainerID.Length == 0)
                {
                    base.ShowMessage("请输入容器号！", false, EnMessageType.C, false);

                    return;
                }

                if (SCM.RF.Client.Utility.StringHelper.ISStringInt32(strTaskNo))
                {
                    if (SCM.RF.Client.Utility.StringHelper.ISStringInt32(strContainerID))
                    {
                        LoadData(strTaskNo, strContainerID);
                    }
                    else
                    {
                        base.ShowMessage("容器号格式错误！", false, EnMessageType.A, false);
                    }
                }
                else
                {
                    base.ShowMessage("集合单号格式错误！", false, EnMessageType.A, false);
                }
            }
        }

        #endregion

        #region FOCUS

        private void txtContainerID_GotFocus(object sender, System.EventArgs e)
        {
            this.pbContainer.BackColor = Color.Yellow;
        }

        private void txtContainerID_LostFocus(object sender, System.EventArgs e)
        {
            this.pbContainer.BackColor = Color.White;
        }

        private void txtTaskNo_GotFocus(object sender, System.EventArgs e)
        {
            this.pbTaskNo.BackColor = Color.Yellow;
        }

        private void txtTaskNo_LostFocus(object sender, System.EventArgs e)
        {
            this.pbTaskNo.BackColor = Color.White;
        }

        #endregion

        #region PRIVATE FUNCTION

        private void FocusTaskNo()
        {
            this.txtTaskNo.Text = string.Empty;

            this.txtTaskNo.Focus();
        }

        private void FocusContainer()
        {
            this.txtContainerID.Text = string.Empty;

            this.txtContainerID.Focus();
        }

        private void LoadData(string taskno, string containerid)
        {
            LabelViewEntity param = new LabelViewEntity();
            param.ContainerID = containerid;
            param.SysNo = 0;
            param.LabelNO = taskno;
            param.InUser = base.UserViewEntity.UserName;

            //加载数据
            LabelViewEntity result = new LabelBP().GetEntity(param, base.RemoteServer);

            if (result != null)
            {
                // 状态为 A - 准备移库
                if (result.Success)
                {
                    base.RF.ShowPicking2(result);
                }
                else
                {
                    base.ShowMessage(result.Message, false, EnMessageType.A, false);
                }
            }
            else
            {
                base.ShowMessage("错误，重新登录！", false, EnMessageType.B, false);
            }
        }

        #endregion

        #region 供快捷键调用 本级页面

        /// <summary>
        /// 退出快捷键
        /// </summary>
        public void HookExit()
        {
            btnCancel_Click(null, null);
        }

        #endregion
    }
}
