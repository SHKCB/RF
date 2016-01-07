using System;
using System.Drawing;
using System.Windows.Forms;
using SCM.RF.Client.BizEntities.Putaway;
using SCM.RF.Client.Tool.Controls.Common;
using Justyle.WMS.RF.Server.BizEntities.Putaway;

namespace SCM.RF.Client.Tool.Controls.PutAway
{
    /// <summary>
    /// 整托盘上架
    /// </summary>
    public partial class UCPutaway2 : UCBasicControl
    {
        #region PRIVATE MEMBER

        /// <summary>
        ///  待上架 数据
        /// </summary>
        private PutawayViewEntity _PutawayEntity;

        #endregion

        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="rf"></param>
        public UCPutaway2(RF rf)
            : base(rf)
        {
            InitializeComponent();
        }

        #region 重载 override

        public override void Init()
        {
            base.SetTitle("功能选择");

            this.FocusMenu();
        }

        public override void Proc(EnMessageType type)
        {
            if (type == EnMessageType.A)
            {
                this.FocusMenu();
            }
            else if (type == EnMessageType.B)
            {
                base.Exit();
            }
            else
            {

            }
        }

        #endregion

        #region PUBLIC FUNCTION

        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="server"></param>
        /// <param name="user"></param>
        public void LoadData(PutawayViewEntity entity)
        {
            this._PutawayEntity = entity;
        }

        #endregion

        #region PRIVARE FUNCTION

        private void FocusMenu()
        {
            this.txtMenu.Text = string.Empty;

            this.txtMenu.Focus();
        }

        private void txtMenu_TextChanged(object sender, EventArgs e)
        {
            string txt = this.txtMenu.Text.Trim().ToUpper();

            if (txt.Length > 0)
            {
                //1-正品 2 - 次品
                if (txt == "1")
                {
                    base.RF.ShowPutaway3(this._PutawayEntity, EnImpType.CHECK);
                }
                else if (txt == "2")
                {
                    RF.ShowPutaway3(this._PutawayEntity, EnImpType.BAD);
                }
                else
                {
                    base.ShowMessage("请输入正确指令！", false, EnMessageType.A, false);
                }
            }
            else
            {
                this.FocusMenu();
            }
        }

        #endregion

        #region CLICK

        /// <summary>
        /// 返回
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.btnCancel.Enabled = false;
            base.RF.ShowPutaway1();
            this.btnCancel.Enabled = true;
        }

        #endregion

        #region FOCUS

        private void txtMenu_GotFocus(object sender, EventArgs e)
        {
            this.pbMenu.BackColor = Color.Yellow;
        }

        private void txtMenu_LostFocus(object sender, EventArgs e)
        {
            this.pbMenu.BackColor = Color.White;
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
