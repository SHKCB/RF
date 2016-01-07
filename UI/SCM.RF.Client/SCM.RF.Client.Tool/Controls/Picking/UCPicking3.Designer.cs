namespace SCM.RF.Client.Tool.Controls.Picking
{
    partial class UCPicking3
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lbProduct;
        private System.Windows.Forms.Label lbProductName;
        private System.Windows.Forms.Label lbProductColor;
        private System.Windows.Forms.Label lbCellNo;
        private System.Windows.Forms.Label lbProductSize;
        private System.Windows.Forms.Button btnDetail;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnBad;
        private System.Windows.Forms.Label lbProduct2;
        private System.Windows.Forms.Label lbProductName2;
        private System.Windows.Forms.Label lbProductColor2;
        private System.Windows.Forms.Label lbProductSize2;
        private System.Windows.Forms.Label lbCellNo2;
        private System.Windows.Forms.Label lbQty;
        private System.Windows.Forms.Label lbQty2;
        private System.Windows.Forms.Label lbCount;
        private System.Windows.Forms.PictureBox pbCount;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.Button btnReset;

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
            this.lbProductName = new System.Windows.Forms.Label();
            this.lbProductColor = new System.Windows.Forms.Label();
            this.lbCellNo = new System.Windows.Forms.Label();
            this.lbProductSize = new System.Windows.Forms.Label();
            this.btnDetail = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnBad = new System.Windows.Forms.Button();
            this.lbProduct2 = new System.Windows.Forms.Label();
            this.lbProductName2 = new System.Windows.Forms.Label();
            this.lbProductColor2 = new System.Windows.Forms.Label();
            this.lbProductSize2 = new System.Windows.Forms.Label();
            this.lbCellNo2 = new System.Windows.Forms.Label();
            this.lbQty = new System.Windows.Forms.Label();
            this.lbQty2 = new System.Windows.Forms.Label();
            this.lbCount = new System.Windows.Forms.Label();
            this.pbCount = new System.Windows.Forms.PictureBox();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbProduct
            // 
            this.lbProduct.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
            this.lbProduct.ForeColor = System.Drawing.Color.White;
            this.lbProduct.Location = new System.Drawing.Point(0, 0);
            this.lbProduct.Name = "lbProduct";
            this.lbProduct.Size = new System.Drawing.Size(100, 20);
            this.lbProduct.Text = "拣货商品：";
            // 
            // lbProductName
            // 
            this.lbProductName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
            this.lbProductName.ForeColor = System.Drawing.Color.White;
            this.lbProductName.Location = new System.Drawing.Point(0, 25);
            this.lbProductName.Name = "lbProductName";
            this.lbProductName.Size = new System.Drawing.Size(100, 20);
            this.lbProductName.Text = "商品名称：";
            // 
            // lbProductColor
            // 
            this.lbProductColor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
            this.lbProductColor.ForeColor = System.Drawing.Color.White;
            this.lbProductColor.Location = new System.Drawing.Point(0, 50);
            this.lbProductColor.Name = "lbProductColor";
            this.lbProductColor.Size = new System.Drawing.Size(100, 20);
            this.lbProductColor.Text = "产品颜色：";
            // 
            // lbCellNo
            // 
            this.lbCellNo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
            this.lbCellNo.ForeColor = System.Drawing.Color.White;
            this.lbCellNo.Location = new System.Drawing.Point(0, 75);
            this.lbCellNo.Name = "lbCellNo";
            this.lbCellNo.Size = new System.Drawing.Size(100, 20);
            this.lbCellNo.Text = "拣货库位：";
            // 
            // lbProductSize
            // 
            this.lbProductSize.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
            this.lbProductSize.ForeColor = System.Drawing.Color.White;
            this.lbProductSize.Location = new System.Drawing.Point(170, 50);
            this.lbProductSize.Name = "lbProductSize";
            this.lbProductSize.Size = new System.Drawing.Size(60, 20);
            this.lbProductSize.Text = "尺码：";
            // 
            // btnDetail
            // 
            this.btnDetail.BackColor = System.Drawing.Color.Black;
            this.btnDetail.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
            this.btnDetail.ForeColor = System.Drawing.Color.White;
            this.btnDetail.Location = new System.Drawing.Point(250, 0);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(40, 40);
            this.btnDetail.TabIndex = 1;
            this.btnDetail.TabStop = false;
            this.btnDetail.Tag = "True";
            this.btnDetail.Text = "明细\r\n[F5]";
            this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Black;
            this.btnSearch.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(210, 125);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(80, 25);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.TabStop = false;
            this.btnSearch.Tag = "True";
            this.btnSearch.Text = "查询[&F6]";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Black;
            this.btnCancel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(10, 235);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 25);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.TabStop = false;
            this.btnCancel.Tag = "True";
            this.btnCancel.Text = "返回 [&F1]";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnBad
            // 
            this.btnBad.BackColor = System.Drawing.Color.Black;
            this.btnBad.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
            this.btnBad.ForeColor = System.Drawing.Color.White;
            this.btnBad.Location = new System.Drawing.Point(210, 235);
            this.btnBad.Name = "btnBad";
            this.btnBad.Size = new System.Drawing.Size(80, 25);
            this.btnBad.TabIndex = 4;
            this.btnBad.TabStop = false;
            this.btnBad.Tag = "True";
            this.btnBad.Text = "病单[&F10]";
            this.btnBad.Click += new System.EventHandler(this.btnBad_Click);
            // 
            // lbProduct2
            // 
            this.lbProduct2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
            this.lbProduct2.ForeColor = System.Drawing.Color.Lime;
            this.lbProduct2.Location = new System.Drawing.Point(100, 0);
            this.lbProduct2.Name = "lbProduct2";
            this.lbProduct2.Size = new System.Drawing.Size(150, 20);
            // 
            // lbProductName2
            // 
            this.lbProductName2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
            this.lbProductName2.ForeColor = System.Drawing.Color.White;
            this.lbProductName2.Location = new System.Drawing.Point(100, 25);
            this.lbProductName2.Name = "lbProductName2";
            this.lbProductName2.Size = new System.Drawing.Size(150, 20);
            // 
            // lbProductColor2
            // 
            this.lbProductColor2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
            this.lbProductColor2.ForeColor = System.Drawing.Color.Cyan;
            this.lbProductColor2.Location = new System.Drawing.Point(100, 50);
            this.lbProductColor2.Name = "lbProductColor2";
            this.lbProductColor2.Size = new System.Drawing.Size(70, 20);
            // 
            // lbProductSize2
            // 
            this.lbProductSize2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
            this.lbProductSize2.ForeColor = System.Drawing.Color.Cyan;
            this.lbProductSize2.Location = new System.Drawing.Point(230, 50);
            this.lbProductSize2.Name = "lbProductSize2";
            this.lbProductSize2.Size = new System.Drawing.Size(70, 20);
            // 
            // lbCellNo2
            // 
            this.lbCellNo2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
            this.lbCellNo2.ForeColor = System.Drawing.Color.Lime;
            this.lbCellNo2.Location = new System.Drawing.Point(100, 75);
            this.lbCellNo2.Name = "lbCellNo2";
            this.lbCellNo2.Size = new System.Drawing.Size(200, 20);
            // 
            // lbQty
            // 
            this.lbQty.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
            this.lbQty.ForeColor = System.Drawing.Color.White;
            this.lbQty.Location = new System.Drawing.Point(0, 100);
            this.lbQty.Name = "lbQty";
            this.lbQty.Size = new System.Drawing.Size(100, 20);
            this.lbQty.Text = "拣货数量：";
            // 
            // lbQty2
            // 
            this.lbQty2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
            this.lbQty2.ForeColor = System.Drawing.Color.Lime;
            this.lbQty2.Location = new System.Drawing.Point(100, 100);
            this.lbQty2.Name = "lbQty2";
            this.lbQty2.Size = new System.Drawing.Size(200, 20);
            // 
            // lbCount
            // 
            this.lbCount.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
            this.lbCount.ForeColor = System.Drawing.Color.White;
            this.lbCount.Location = new System.Drawing.Point(0, 125);
            this.lbCount.Name = "lbCount";
            this.lbCount.Size = new System.Drawing.Size(100, 20);
            this.lbCount.Text = "输入数量：";
            // 
            // pbCount
            // 
            this.pbCount.BackColor = System.Drawing.Color.White;
            this.pbCount.Location = new System.Drawing.Point(100, 143);
            this.pbCount.Name = "pbCount";
            this.pbCount.Size = new System.Drawing.Size(100, 2);
            this.pbCount.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            // 
            // txtCount
            // 
            this.txtCount.BackColor = System.Drawing.Color.Black;
            this.txtCount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCount.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
            this.txtCount.ForeColor = System.Drawing.Color.White;
            this.txtCount.Location = new System.Drawing.Point(100, 125);
            this.txtCount.MaxLength = 3;
            this.txtCount.Name = "txtCount";
            this.txtCount.ReadOnly = true;
            this.txtCount.Size = new System.Drawing.Size(100, 25);
            this.txtCount.TabIndex = 5;
            this.txtCount.TabStop = false;
            this.txtCount.Tag = "True";
            this.txtCount.WordWrap = false;
            this.txtCount.GotFocus += new System.EventHandler(this.txtCount_GotFocus);
            this.txtCount.LostFocus += new System.EventHandler(this.txtCount_LostFocus);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Black;
            this.btnReset.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(210, 204);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(80, 25);
            this.btnReset.TabIndex = 6;
            this.btnReset.TabStop = false;
            this.btnReset.Tag = "True";
            this.btnReset.Text = "重定位[&F3]";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // UCPicking3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.pbCount);
            this.Controls.Add(this.txtCount);
            this.Controls.Add(this.lbCount);
            this.Controls.Add(this.lbQty2);
            this.Controls.Add(this.lbQty);
            this.Controls.Add(this.lbCellNo2);
            this.Controls.Add(this.lbProductSize2);
            this.Controls.Add(this.lbProductColor2);
            this.Controls.Add(this.lbProductName2);
            this.Controls.Add(this.lbProduct2);
            this.Controls.Add(this.btnBad);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDetail);
            this.Controls.Add(this.lbCellNo);
            this.Controls.Add(this.lbProductSize);
            this.Controls.Add(this.lbProductColor);
            this.Controls.Add(this.lbProductName);
            this.Controls.Add(this.lbProduct);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
            this.ForeColor = System.Drawing.Color.Cyan;
            this.Name = "UCPicking3";
            this.Size = new System.Drawing.Size(300, 260);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
