using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SCM.RF.Client.Tool.Controls.Common;
using SCM.RF.Client.BizEntities.AuthCenter;
using SCM.RF.Client.BizEntities.Receive;

namespace SCM.RF.Client.Tool.Controls.Receive
{
    public partial class UCReceiveMain : UCBasicControl
    {
        private UserViewEntity _user;

        #region LoadFunction

        public UCReceiveMain(RF rf)
            : base(rf)
        {
            InitializeComponent();
        }

        public override void Init()
        {
            base.SetTitle("收货");           
        }

        public UCReceiveMain(UserViewEntity user) 
        {
            InitializeComponent();
            this._user = user;
        }

        #endregion

        #region ClickFunction

        /// <summary>
        /// 收货单号文本框 回车键执行具体方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtReceiveNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CheckReceiveNo();
            }
        }

        /// <summary>
        /// 确定按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOk_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region PrivateFunction

        /// <summary>
        /// 具体检查收货单号的方法
        /// </summary>
        private void CheckReceiveNo()
        {
            string ReceiveNo = txtReceiveNo.Text.Trim();

            ReceiveHeaderViewEntity entity = new ReceiveHeaderViewEntity();

            entity.CID = SCM.RF.Client.BizProcess.Sys.InstanceBP.SystemInstance.CID;
            entity.Instockcode = ReceiveNo;
            entity.TID = DateTime.Now.ToString("yyyyMMddHHmmssfff");
            entity.WareHouseId = SCM.RF.Client.BizProcess.Sys.InstanceBP.SystemInstance.CID;
            entity.UName = _user.UserName;
            entity.PWD = _user.Password;



        }

        #endregion

     

    }
}
