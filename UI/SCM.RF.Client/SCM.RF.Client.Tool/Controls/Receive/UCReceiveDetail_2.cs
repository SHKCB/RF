using System;
using System.Drawing;
using System.Windows.Forms;
using SCM.RF.Client.BizEntities.Receive;
using SCM.RF.Client.Tool.Controls.Common;

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

        #endregion
               
    }
}
