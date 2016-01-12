using System;
using SCM.RF.Client.Tool;
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
            base.SetTitle("拣货类型选择");

            this.FocusMenu();
        }

        public override void Proc(EnMessageType type)
        {
            this.FocusMenu();
        }

        #endregion

        #region CLICK

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.btnCancel.Enabled = false;
            base.Cancel();
            this.btnCancel.Enabled = true;
        }

        #endregion

        #region FOCUS

        private void FocusMenu()
        {
            this.txtMenu.Text = string.Empty;
            this.txtMenu.Focus();
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
