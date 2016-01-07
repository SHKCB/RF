﻿using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;
using SCM.RF.Client.BizEntities.HandOver;
using SCM.RF.Client.BizProcess.HandOver;
using SCM.RF.Client.Tool.Controls.Common;

/*
 * 手工移库扫描操作页面
 * Add by 飞鱼 2012-6-12
 * Edit by [][][]
 */
namespace SCM.RF.Client.Tool.Controls.HandOver
{
    public partial class UCHandOver3 : UCBasicControl
    {
        #region PRIVATE MEMORY

        private Hashtable _Hashtable;

        /// <summary>
        /// 主表信息
        /// </summary>
        private HOViewEntity _HOViewEntity;

        #endregion

        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="rf"></param>
        public UCHandOver3(RF rf)
            : base(rf)
        {
            InitializeComponent();
        }

        #region 重载 override

        public override void Init()
        {
            base.SetTitle("快递交接1");

            this.Clear();
        }

        public override void Proc(EnMessageType type)
        {
            if (type == EnMessageType.A)
            {
                this.Clear();
            }
            else if (type == EnMessageType.B)
            {
                base.Exit();
            }
            else if (type == EnMessageType.D)
            {
                this.FocusDeliveryNo();
            }
            else if (type == EnMessageType.E)
            {
                base.RF.HideHandOver3();
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
        /// <param name="TaskNO"></param>
        /// <param name="remoteserver"></param>
        /// <param name="userentity"></param>
        public void LoadData(HOViewEntity entity)
        {
            this._HOViewEntity = entity;

            this.lbTID2.Text = entity.HOID;
        }

        #endregion

        #region PRIVATE FUNCTION

        /// <summary>
        /// 清除值
        /// </summary>
        private void Clear()
        {
            this._Hashtable = new Hashtable();
            this.txtDeliveryNo.Text = string.Empty;
            this.FocusDeliveryNo();
        }

        /// <summary>
        /// 快递单聚焦
        /// </summary>
        private void FocusDeliveryNo()
        {
            this.txtDeliveryNo.Text = string.Empty;
            this.txtDeliveryNo.Focus();
        }

        /// <summary>
        /// 添加数据
        /// </summary>
        /// <param name="cellno"></param>
        /// <param name="barcode"></param>
        /// <param name="count"></param>
        private void AddData(string deliveryno)
        {
            HOItemViewEntity param = new HOItemViewEntity();

            param.InUser = base.UserViewEntity.UserName;
            param.OrderID = string.Empty;
            param.DeliveryNo = deliveryno;

            param.HOSysNo = this._HOViewEntity.SysNo;

            HOItemViewEntity result = new HOBP().Insert2(param, base.RemoteServer);

            if (result != null)
            {
                // 状态为 A - 准备移库
                if (result.Success)
                {
                    base.RF.PlaySound(true);

                    this.Clear();
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

        #region FOCUS

        private void txtDeliveryNo_GotFocus(object sender, EventArgs e)
        {
            this.pbDeliveryNo.BackColor = Color.Yellow;
        }

        private void txtDeliveryNo_LostFocus(object sender, EventArgs e)
        {
            this.pbDeliveryNo.BackColor = Color.White;
        }

        #endregion

        #region CLICK

        /// <summary>
        /// 后退按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            base.ShowMessage("退出？", true, EnMessageType.E);
        }

        private void txtDeliveryNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;

                string strDeliveryNo = this.txtDeliveryNo.Text.Trim().ToUpper();

                if (strDeliveryNo.Length == 0)
                {
                    base.ShowMessage("请输入快递单号！", false, EnMessageType.D, false);

                    return;
                }

                if (SCM.RF.Client.Utility.StringHelper.ISStringInt32(strDeliveryNo))
                {
                    this.AddData(strDeliveryNo);
                }
                else
                {
                    base.ShowMessage("快递单号格式错误！", false, EnMessageType.D, false);
                }
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
