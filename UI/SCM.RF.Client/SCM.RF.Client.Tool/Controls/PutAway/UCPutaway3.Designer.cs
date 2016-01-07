namespace SCM.RF.Client.Tool.Controls.PutAway
{
    partial class UCPutaway3
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lbBoxNo;
        private System.Windows.Forms.Label lbProduct;
        private System.Windows.Forms.TextBox txtBarCode;
        private System.Windows.Forms.PictureBox pbProduct;
        private System.Windows.Forms.Label lbCellNo;
        private System.Windows.Forms.TextBox txtCellNo;
        private System.Windows.Forms.PictureBox pbCellNo;
        private System.Windows.Forms.Label lbQty;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.PictureBox pbQty;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lbBoxNo2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDetail;
        private System.Windows.Forms.PictureBox pbSize;
        private System.Windows.Forms.PictureBox pbColor;
        private System.Windows.Forms.TextBox txtProductSize;
        private System.Windows.Forms.TextBox txtProductColor;
        private System.Windows.Forms.Label lbProductSize;
        private System.Windows.Forms.Label lbProductColor;
        private System.Windows.Forms.PictureBox pbNum;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label lbNum;

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
            this.lbBoxNo = new System.Windows.Forms.Label();
            this.lbProduct = new System.Windows.Forms.Label();
            this.txtBarCode = new System.Windows.Forms.TextBox();
            this.pbProduct = new System.Windows.Forms.PictureBox();
            this.lbCellNo = new System.Windows.Forms.Label();
            this.txtCellNo = new System.Windows.Forms.TextBox();
            this.pbCellNo = new System.Windows.Forms.PictureBox();
            this.lbQty = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.pbQty = new System.Windows.Forms.PictureBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lbBoxNo2 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDetail = new System.Windows.Forms.Button();
            this.pbSize = new System.Windows.Forms.PictureBox();
            this.pbColor = new System.Windows.Forms.PictureBox();
            this.txtProductSize = new System.Windows.Forms.TextBox();
            this.txtProductColor = new System.Windows.Forms.TextBox();
            this.lbProductSize = new System.Windows.Forms.Label();
            this.lbProductColor = new System.Windows.Forms.Label();
            this.pbNum = new System.Windows.Forms.PictureBox();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.lbNum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbBoxNo
            // 
            this.lbBoxNo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
            this.lbBoxNo.ForeColor = System.Drawing.Color.White;
            this.lbBoxNo.Location = new System.Drawing.Point(0, 0);
            this.lbBoxNo.Name = "lbBoxNo";
            this.lbBoxNo.Size = new System.Drawing.Size(100, 25);
            this.lbBoxNo.Text = "上架编码：";
            // 
            // lbProduct
            // 
            this.lbProduct.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
            this.lbProduct.ForeColor = System.Drawing.Color.White;
            this.lbProduct.Location = new System.Drawing.Point(0, 40);
            this.lbProduct.Name = "lbProduct";
            this.lbProduct.Size = new System.Drawing.Size(100, 25);
            this.lbProduct.Text = "扫描商品：";
            // 
            // txtBarCode
            // 
            this.txtBarCode.BackColor = System.Drawing.Color.Black;
            this.txtBarCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBarCode.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
            this.txtBarCode.ForeColor = System.Drawing.Color.White;
            this.txtBarCode.Location = new System.Drawing.Point(100, 40);
            this.txtBarCode.MaxLength = 20;
            this.txtBarCode.Name = "txtBarCode";
            this.txtBarCode.Size = new System.Drawing.Size(200, 25);
            this.txtBarCode.TabIndex = 1;
            this.txtBarCode.TabStop = false;
            this.txtBarCode.Tag = "True";
            this.txtBarCode.WordWrap = false;
            this.txtBarCode.GotFocus += new System.EventHandler(this.txtProduct_GotFocus);
            this.txtBarCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProduct_KeyPress);
            this.txtBarCode.LostFocus += new System.EventHandler(this.txtProduct_LostFocus);
            // 
            // pbProduct
            // 
            this.pbProduct.BackColor = System.Drawing.Color.White;
            this.pbProduct.Location = new System.Drawing.Point(100, 58);
            this.pbProduct.Name = "pbProduct";
            this.pbProduct.Size = new System.Drawing.Size(200, 2);
            this.pbProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            // 
            // lbCellNo
            // 
            this.lbCellNo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
            this.lbCellNo.ForeColor = System.Drawing.Color.White;
            this.lbCellNo.Location = new System.Drawing.Point(0, 160);
            this.lbCellNo.Name = "lbCellNo";
            this.lbCellNo.Size = new System.Drawing.Size(100, 25);
            this.lbCellNo.Text = "上架库位：";
            // 
            // txtCellNo
            // 
            this.txtCellNo.BackColor = System.Drawing.Color.Black;
            this.txtCellNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCellNo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
            this.txtCellNo.ForeColor = System.Drawing.Color.White;
            this.txtCellNo.Location = new System.Drawing.Point(100, 160);
            this.txtCellNo.MaxLength = 13;
            this.txtCellNo.Name = "txtCellNo";
            this.txtCellNo.Size = new System.Drawing.Size(200, 25);
            this.txtCellNo.TabIndex = 2;
            this.txtCellNo.TabStop = false;
            this.txtCellNo.Tag = "True";
            this.txtCellNo.WordWrap = false;
            this.txtCellNo.GotFocus += new System.EventHandler(this.txtCellNo_GotFocus);
            this.txtCellNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCellNo_KeyPress);
            this.txtCellNo.LostFocus += new System.EventHandler(this.txtCellNo_LostFocus);
            // 
            // pbCellNo
            // 
            this.pbCellNo.BackColor = System.Drawing.Color.White;
            this.pbCellNo.Location = new System.Drawing.Point(100, 178);
            this.pbCellNo.Name = "pbCellNo";
            this.pbCellNo.Size = new System.Drawing.Size(200, 2);
            this.pbCellNo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            // 
            // lbQty
            // 
            this.lbQty.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
            this.lbQty.ForeColor = System.Drawing.Color.White;
            this.lbQty.Location = new System.Drawing.Point(0, 200);
            this.lbQty.Name = "lbQty";
            this.lbQty.Size = new System.Drawing.Size(100, 25);
            this.lbQty.Text = "输入数量：";
            // 
            // txtQty
            // 
            this.txtQty.BackColor = System.Drawing.Color.Black;
            this.txtQty.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQty.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
            this.txtQty.ForeColor = System.Drawing.Color.White;
            this.txtQty.Location = new System.Drawing.Point(100, 200);
            this.txtQty.MaxLength = 4;
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(200, 25);
            this.txtQty.TabIndex = 3;
            this.txtQty.TabStop = false;
            this.txtQty.Tag = "True";
            this.txtQty.WordWrap = false;
            this.txtQty.GotFocus += new System.EventHandler(this.txtQty_GotFocus);
            this.txtQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQty_KeyPress);
            this.txtQty.LostFocus += new System.EventHandler(this.txtQty_LostFocus);
            // 
            // pbQty
            // 
            this.pbQty.BackColor = System.Drawing.Color.White;
            this.pbQty.Location = new System.Drawing.Point(100, 218);
            this.pbQty.Name = "pbQty";
            this.pbQty.Size = new System.Drawing.Size(200, 2);
            this.pbQty.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Black;
            this.btnCancel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(10, 235);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 25);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.TabStop = false;
            this.btnCancel.Tag = "True";
            this.btnCancel.Text = "退出[&F1]";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lbBoxNo2
            // 
            this.lbBoxNo2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
            this.lbBoxNo2.ForeColor = System.Drawing.Color.White;
            this.lbBoxNo2.Location = new System.Drawing.Point(100, 0);
            this.lbBoxNo2.Name = "lbBoxNo2";
            this.lbBoxNo2.Size = new System.Drawing.Size(200, 20);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Black;
            this.btnSearch.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(110, 235);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(80, 25);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.TabStop = false;
            this.btnSearch.Tag = "True";
            this.btnSearch.Text = "查询[&F6]";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDetail
            // 
            this.btnDetail.BackColor = System.Drawing.Color.Black;
            this.btnDetail.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
            this.btnDetail.ForeColor = System.Drawing.Color.White;
            this.btnDetail.Location = new System.Drawing.Point(210, 235);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(80, 25);
            this.btnDetail.TabIndex = 6;
            this.btnDetail.TabStop = false;
            this.btnDetail.Tag = "True";
            this.btnDetail.Text = "明细[&F5]";
            this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // pbSize
            // 
            this.pbSize.BackColor = System.Drawing.Color.White;
            this.pbSize.Location = new System.Drawing.Point(230, 98);
            this.pbSize.Name = "pbSize";
            this.pbSize.Size = new System.Drawing.Size(70, 2);
            this.pbSize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            // 
            // pbColor
            // 
            this.pbColor.BackColor = System.Drawing.Color.White;
            this.pbColor.Location = new System.Drawing.Point(100, 98);
            this.pbColor.Name = "pbColor";
            this.pbColor.Size = new System.Drawing.Size(70, 2);
            this.pbColor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            // 
            // txtProductSize
            // 
            this.txtProductSize.BackColor = System.Drawing.Color.Black;
            this.txtProductSize.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProductSize.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
            this.txtProductSize.ForeColor = System.Drawing.Color.White;
            this.txtProductSize.Location = new System.Drawing.Point(230, 80);
            this.txtProductSize.MaxLength = 20;
            this.txtProductSize.Name = "txtProductSize";
            this.txtProductSize.ReadOnly = true;
            this.txtProductSize.Size = new System.Drawing.Size(70, 25);
            this.txtProductSize.TabIndex = 7;
            this.txtProductSize.TabStop = false;
            this.txtProductSize.Tag = "True";
            this.txtProductSize.WordWrap = false;
            // 
            // txtProductColor
            // 
            this.txtProductColor.BackColor = System.Drawing.Color.Black;
            this.txtProductColor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProductColor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
            this.txtProductColor.ForeColor = System.Drawing.Color.White;
            this.txtProductColor.Location = new System.Drawing.Point(100, 80);
            this.txtProductColor.MaxLength = 20;
            this.txtProductColor.Name = "txtProductColor";
            this.txtProductColor.ReadOnly = true;
            this.txtProductColor.Size = new System.Drawing.Size(70, 25);
            this.txtProductColor.TabIndex = 8;
            this.txtProductColor.TabStop = false;
            this.txtProductColor.Tag = "True";
            this.txtProductColor.WordWrap = false;
            // 
            // lbProductSize
            // 
            this.lbProductSize.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
            this.lbProductSize.ForeColor = System.Drawing.Color.White;
            this.lbProductSize.Location = new System.Drawing.Point(170, 80);
            this.lbProductSize.Name = "lbProductSize";
            this.lbProductSize.Size = new System.Drawing.Size(60, 25);
            this.lbProductSize.Text = "尺码：";
            // 
            // lbProductColor
            // 
            this.lbProductColor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
            this.lbProductColor.ForeColor = System.Drawing.Color.White;
            this.lbProductColor.Location = new System.Drawing.Point(0, 80);
            this.lbProductColor.Name = "lbProductColor";
            this.lbProductColor.Size = new System.Drawing.Size(100, 25);
            this.lbProductColor.Text = "产品颜色：";
            // 
            // pbNum
            // 
            this.pbNum.BackColor = System.Drawing.Color.White;
            this.pbNum.Location = new System.Drawing.Point(100, 138);
            this.pbNum.Name = "pbNum";
            this.pbNum.Size = new System.Drawing.Size(200, 2);
            this.pbNum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            // 
            // txtNum
            // 
            this.txtNum.BackColor = System.Drawing.Color.Black;
            this.txtNum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNum.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
            this.txtNum.ForeColor = System.Drawing.Color.White;
            this.txtNum.Location = new System.Drawing.Point(100, 120);
            this.txtNum.MaxLength = 10;
            this.txtNum.Name = "txtNum";
            this.txtNum.ReadOnly = true;
            this.txtNum.Size = new System.Drawing.Size(200, 25);
            this.txtNum.TabIndex = 9;
            this.txtNum.TabStop = false;
            this.txtNum.Tag = "True";
            this.txtNum.WordWrap = false;
            // 
            // lbNum
            // 
            this.lbNum.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
            this.lbNum.ForeColor = System.Drawing.Color.White;
            this.lbNum.Location = new System.Drawing.Point(0, 120);
            this.lbNum.Name = "lbNum";
            this.lbNum.Size = new System.Drawing.Size(100, 25);
            this.lbNum.Text = "总上架量：";
            // 
            // UCPutaway3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.pbNum);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.lbNum);
            this.Controls.Add(this.pbSize);
            this.Controls.Add(this.pbColor);
            this.Controls.Add(this.txtProductSize);
            this.Controls.Add(this.txtProductColor);
            this.Controls.Add(this.lbProductSize);
            this.Controls.Add(this.lbProductColor);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDetail);
            this.Controls.Add(this.lbBoxNo2);
            this.Controls.Add(this.pbQty);
            this.Controls.Add(this.pbCellNo);
            this.Controls.Add(this.pbProduct);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.lbQty);
            this.Controls.Add(this.txtCellNo);
            this.Controls.Add(this.lbCellNo);
            this.Controls.Add(this.txtBarCode);
            this.Controls.Add(this.lbProduct);
            this.Controls.Add(this.lbBoxNo);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "UCPutaway3";
            this.Size = new System.Drawing.Size(300, 260);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
