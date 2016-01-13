using System;
using System.Drawing;
using System.Windows.Forms;
using SCM.RF.Client.BizEntities.Receive;
using SCM.RF.Client.Tool.Controls.Common;
using SCM.RF.Client.Utility;
using SCM.RF.Client.BizProcess.Receive;

namespace SCM.RF.Client.Tool.Controls.Receive
{
    public partial class UCReceiveDetail_2 : UCBasicControl
    {
        private ReceiveHeaderViewEntity _header;

        #region LoadFunction

        public UCReceiveDetail_2(RF rf)
            : base(rf)
        {
            InitializeComponent();
        }

        public void LoadData(ReceiveHeaderViewEntity header)
        {
            this._header = header;

            lvData.Items.Clear();

            lvData.BeginUpdate();

            ListViewItem item;

            for (int i = 0; i < this._header.Detail.Length; i++)
            {
                item = new ListViewItem();
                item.Text = this._header.Detail[i].Outerid;
                //item.SubItems.Add(this._header.Detail[i].Outerid);
                item.SubItems.Add(this._header.Detail[i].Cbarcode);
                item.SubItems.Add(this._header.Detail[i].GName);
                item.SubItems.Add(this._header.Detail[i].Spec);
                item.SubItems.Add(this._header.Detail[i].Waitamount);
                item.SubItems.Add(this._header.Detail[i].Waittxj);
                item.SubItems.Add(this._header.Detail[i].Planamount);
                item.SubItems.Add(this._header.Detail[i].Plantxj);
                item.SubItems.Add(this._header.Detail[i].Did);

                lvData.Items.Add(item);
            }

            lvData.EndUpdate();

        }

        #endregion

        #region 重载 override

        public override void Init()
        {
            base.SetTitle("收货详细");

            this.FocusBarCode();
        }

        public override void Proc(EnMessageType type)
        {
            this.FocusBarCode();
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

        #region FOCUS
        private void txtBarCode_GotFocus(object sender, EventArgs e)
        {
            this.pbBarcode.BackColor = Color.Yellow;
        }

        private void txtBarCode_LostFocus(object sender, EventArgs e)
        {
            this.pbBarcode.BackColor = Color.White;
        }
        #endregion

        #region Private Function

        /// <summary>
        /// 聚焦
        /// </summary>
        private void FocusBarCode()
        {
            this.txtBarCode.Text = string.Empty;
            this.txtBarCode.Focus();
        }

        private void GetSingle(string barcode)
        {
            ReceiveDetailViewEntity entity = new ReceiveDetailViewEntity(base.UserView);

            for (int i = 0; i < this._header.Detail.Length; i++)
            {
                if (this._header.Detail[i].Cbarcode == barcode)
                {
                    entity.Goodsid = this._header.Detail[i].Goodsid;
                }
            }

            entity = new ReceiveBP().GetGoodsUnitInfos(entity, this.RF.RemoteServer);
        }

        #endregion

        #region Click Function

        /// <summary>
        /// 返回
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.btnCancel.Enabled = false;
            base.Cancel();
            this.btnCancel.Enabled = true;
        }

        /// <summary>
        /// 设置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSet_Click(object sender, EventArgs e)
        {

        }

        private void txtBarCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;

                string txtcode = this.txtBarCode.Text.Trim().ToUpper();

                if (txtcode.Length > 0)
                {
                    if (StringHelper.ISStringInt32(txtcode))
                    {
                        GetSingle(txtcode);
                    }
                    else
                    {
                        base.ShowMessage("条码格式错误！", false, EnMessageType.A, false);
                    }
                }

            }
        }

        #endregion



    }
}
