using System;
using SCM.RF.Client.Tool;
using SCM.RF.Client.Tool.Controls.Common;
using System.Windows.Forms;
using SCM.RF.Client.Utility;

namespace SCM.RF.Client.Tool.Controls.Picking
{
    public partial class UCPickingByTaskID : UCBasicControl
    {
        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="rf"></param>
        public UCPickingByTaskID(RF rf)
            : base(rf)
        {
            InitializeComponent();
        }

        #region 重载 override

        public override void Init()
        {
            base.SetTitle("按 [任务号] - 拣货");

            this.FocusTaskNo();
        }

        public override void Proc(EnMessageType type)
        {
            this.FocusTaskNo();
        }

        #endregion

        #region CLICK

        private void btnCancel_Click(object sender, EventArgs e)
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
                    if (StringHelper.ISStringInt32(txtTaskNo))
                    {
                        //FocusContainer();
                    }
                    else
                    {
                        base.ShowMessage("集合单格式错误！", false, EnMessageType.A, false);
                    }
                }
            }
        }

        #endregion

        #region FOCUS

        private void FocusTaskNo()
        {
            this.txtTaskNo.Text = string.Empty;
            this.txtTaskNo.Focus();
        }

        #endregion

        #region PRIVATE FUNCTION

        private void Proc(int key)
        {
            switch (key)
            {
                case 1:
                    //base.RF.ShowInBound2(EnImpType.BAD);
                    break;
                case 2:
                    //base.RF.ShowInBound2(EnImpType.CHECK);
                    break;
                default: break;
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
