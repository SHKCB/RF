using System;
using System.Windows.Forms;
using SCM.RF.Client.BizEntities.Receive;
using SCM.RF.Client.BizProcess.Receive;
using SCM.RF.Client.Tool.Controls.Common;
using SCM.RF.Client.Utility;
using System.Drawing;

namespace SCM.RF.Client.Tool.Controls.Receive
{
    public partial class UCReceiveMain : UCBasicControl
    {
        #region LoadFunction

        public UCReceiveMain(RF rf)
            : base(rf)
        {
            InitializeComponent();
        }

        #endregion

        #region 重载 override

        public override void Init()
        {
            base.SetTitle("收货");

            this.FocusReceiveNo();
        }

        public override void Proc(EnMessageType type)
        {
            this.FocusReceiveNo();
        }

        #endregion

        #region Click Function

        /// <summary>
        /// 收货单号文本框 回车键执行具体方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtReceiveNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;

                string txtRec = this.txtReceiveNo.Text.Trim().ToUpper();

                if (txtRec.Length > 0)
                {
                    if (StringHelper.ISStringInt32(txtRec))
                    {
                        CheckReceiveNo();
                    }
                    else
                    {
                        base.ShowMessage("单号格式错误！", false, EnMessageType.A, false);
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.btnCancel.Enabled = false;
            base.Cancel();
            this.btnCancel.Enabled = true;
        }

        #endregion

        #region Private Function

        /// <summary>
        /// 具体检查收货单号的方法
        /// </summary>
        private void CheckReceiveNo()
        {
            string ReceiveNo = txtReceiveNo.Text.Trim();
            if (ReceiveNo == "" || ReceiveNo == null) { return; }

            ReceiveHeaderViewEntity entity = new ReceiveHeaderViewEntity(base.UserView);
            //entity.CID = SCM.RF.Client.BizProcess.Sys.InstanceBP.SystemInstance.CID;
            //entity.TID = DateTime.Now.ToString("yyyyMMddHHmmssfff");
            //entity.WareHouseId = base.UserView.WareHouseId;
            //entity.UName = base.UserView.UserID;
            //entity.PWD = base.UserView.Password;

            entity.Instockcode = ReceiveNo;

            entity = new ReceiveBP().GetReceiveDetail(entity, this.RF.RemoteServer);

            if (entity != null)
            {
                if (entity.Success)
                {
                    //跳转新页面 详细信息
                }
                else { base.ShowMessage(entity.Message, false, EnMessageType.A, false); }
            }
            else
            {
                base.ShowMessage("通讯错误，请重新登录!", false, EnMessageType.A, false);
            }
        }

        private void FocusReceiveNo()
        {
            this.txtReceiveNo.Text = string.Empty;
            this.txtReceiveNo.Focus();
        }

        #endregion

        #region FOCUS
        private void txtReceiveNo_GotFocus(object sender, EventArgs e)
        {
            this.pbReceiveNo.BackColor = Color.Yellow;
        }

        private void txtReceiveNo_LostFocus(object sender, EventArgs e)
        {
            this.pbReceiveNo.BackColor = Color.White;
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
