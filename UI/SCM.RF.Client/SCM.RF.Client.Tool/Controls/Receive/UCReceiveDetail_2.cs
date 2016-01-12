using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SCM.RF.Client.Tool.Controls.Common;

namespace SCM.RF.Client.Tool.Controls.Receive
{
    public partial class UCReceiveDetail_2 : UCBasicControl
    {
        #region LoadFunction

        public UCReceiveDetail_2(RF rf)
            : base(rf)
        {
            InitializeComponent();
        }

        #endregion

        #region 重载 override

        public override void Init()
        {
            base.SetTitle("收货详细");

            //this.FocusReceiveNo();
        }

        public override void Proc(EnMessageType type)
        {
            //this.FocusReceiveNo();
        }

        #endregion

        #region 供快捷键调用 本级页面

        /// <summary>
        /// 退出快捷键
        /// </summary>
        public void HookExit()
        {
            //btnCancel_Click(null, null);
        }

        #endregion

        private void txtReceiveNo_GotFocus(object sender, EventArgs e)
        {

        }

        private void txtReceiveNo_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtReceiveNo_LostFocus(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
