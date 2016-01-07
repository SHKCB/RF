namespace SCM.RF.Client.Tool.Controls.Common
{
    partial class UCCellPal
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lbProduct;
        private System.Windows.Forms.TextBox txtProduct;
        private System.Windows.Forms.PictureBox pbProduct;
        private System.Windows.Forms.ListView lvList;
        private System.Windows.Forms.ColumnHeader No;
        private System.Windows.Forms.ColumnHeader CellNO;
        private System.Windows.Forms.ColumnHeader Qty;
        private System.Windows.Forms.ColumnHeader QcanUse;
        private System.Windows.Forms.Label lbPage;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnProv;
        private System.Windows.Forms.Button btnCancel;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lbProduct = new System.Windows.Forms.Label();
            this.txtProduct = new System.Windows.Forms.TextBox();
            this.pbProduct = new System.Windows.Forms.PictureBox();
            this.lvList = new System.Windows.Forms.ListView();
            this.No = new System.Windows.Forms.ColumnHeader();
            this.CellNO = new System.Windows.Forms.ColumnHeader();
            this.Qty = new System.Windows.Forms.ColumnHeader();
            this.QcanUse = new System.Windows.Forms.ColumnHeader();
            this.lbPage = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnProv = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbProduct
            // 
            this.lbProduct.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
            this.lbProduct.ForeColor = System.Drawing.Color.White;
            this.lbProduct.Location = new System.Drawing.Point(0, 0);
            this.lbProduct.Name = "lbProduct";
            this.lbProduct.Size = new System.Drawing.Size(100, 20);
            this.lbProduct.Text = "商品编码：";
            // 
            // txtProduct
            // 
            this.txtProduct.BackColor = System.Drawing.Color.Black;
            this.txtProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProduct.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
            this.txtProduct.ForeColor = System.Drawing.Color.White;
            this.txtProduct.Location = new System.Drawing.Point(100, 0);
            this.txtProduct.MaxLength = 30;
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Size = new System.Drawing.Size(200, 25);
            this.txtProduct.TabIndex = 1;
            this.txtProduct.TabStop = false;
            this.txtProduct.Tag = "True";
            this.txtProduct.WordWrap = false;
            this.txtProduct.GotFocus += new System.EventHandler(this.txtProduct_GotFocus);
            this.txtProduct.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProduct_KeyPress);
            this.txtProduct.LostFocus += new System.EventHandler(this.txtProduct_LostFocus);
            // 
            // pbProduct
            // 
            this.pbProduct.BackColor = System.Drawing.Color.White;
            this.pbProduct.Location = new System.Drawing.Point(100, 18);
            this.pbProduct.Name = "pbProduct";
            this.pbProduct.Size = new System.Drawing.Size(200, 2);
            this.pbProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            // 
            // lvList
            // 
            this.lvList.BackColor = System.Drawing.Color.Black;
            this.lvList.Columns.Add(this.No);
            this.lvList.Columns.Add(this.CellNO);
            this.lvList.Columns.Add(this.Qty);
            this.lvList.Columns.Add(this.QcanUse);
            this.lvList.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
            this.lvList.ForeColor = System.Drawing.Color.White;
            this.lvList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvList.Location = new System.Drawing.Point(0, 25);
            this.lvList.Name = "lvList";
            this.lvList.Size = new System.Drawing.Size(300, 175);
            this.lvList.TabIndex = 2;
            this.lvList.TabStop = false;
            this.lvList.Tag = "True";
            this.lvList.View = System.Windows.Forms.View.Details;
            // 
            // No
            // 
            this.No.Text = "No";
            this.No.Width = 30;
            // 
            // CellNO
            // 
            this.CellNO.Text = "库位";
            this.CellNO.Width = 146;
            // 
            // Qty
            // 
            this.Qty.Text = "库存";
            this.Qty.Width = 60;
            // 
            // QcanUse
            // 
            this.QcanUse.Text = "可用";
            this.QcanUse.Width = 60;
            // 
            // lbPage
            // 
            this.lbPage.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
            this.lbPage.ForeColor = System.Drawing.Color.White;
            this.lbPage.Location = new System.Drawing.Point(95, 208);
            this.lbPage.Name = "lbPage";
            this.lbPage.Size = new System.Drawing.Size(110, 20);
            this.lbPage.Text = "第0页/共0页";
            this.lbPage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbPage.Visible = false;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Black;
            this.btnNext.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(210, 204);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(80, 25);
            this.btnNext.TabIndex = 3;
            this.btnNext.TabStop = false;
            this.btnNext.Tag = "True";
            this.btnNext.Text = "下页 [&F3]";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnProv
            // 
            this.btnProv.BackColor = System.Drawing.Color.Black;
            this.btnProv.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
            this.btnProv.ForeColor = System.Drawing.Color.White;
            this.btnProv.Location = new System.Drawing.Point(10, 204);
            this.btnProv.Name = "btnProv";
            this.btnProv.Size = new System.Drawing.Size(80, 25);
            this.btnProv.TabIndex = 4;
            this.btnProv.TabStop = false;
            this.btnProv.Tag = "True";
            this.btnProv.Text = "上页 [&F2]";
            this.btnProv.Click += new System.EventHandler(this.btnProv_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Black;
            this.btnCancel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(10, 235);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 25);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.TabStop = false;
            this.btnCancel.Tag = "True";
            this.btnCancel.Text = "返回 [&F1]";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // UCCellPal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.lvList);
            this.Controls.Add(this.lbPage);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnProv);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.pbProduct);
            this.Controls.Add(this.txtProduct);
            this.Controls.Add(this.lbProduct);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "UCCellPal";
            this.Size = new System.Drawing.Size(300, 260);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
