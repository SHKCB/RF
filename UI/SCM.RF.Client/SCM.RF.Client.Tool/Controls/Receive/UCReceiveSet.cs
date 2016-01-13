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
    public partial class UCReceiveSet : UCBasicControl
    {
        #region LoadFunction

        public UCReceiveSet(RF rf)
            : base(rf)
        {
            InitializeComponent();
        }

        #endregion

        #region 重载 override

        public override void Init()
        {
            base.SetTitle("收货设置");

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
           // btnCancel_Click(null, null);
        }

        #endregion

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
