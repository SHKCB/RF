namespace SCM.RF.Client.Tool.Controls.Receive
{
    partial class UCReceiveDetail_2
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.lblBarcode = new System.Windows.Forms.Label();
            this.pbBarcode = new System.Windows.Forms.PictureBox();
            this.txtBarCode = new System.Windows.Forms.TextBox();
            this.lvData = new System.Windows.Forms.ListView();
            this.clCompany = new System.Windows.Forms.ColumnHeader();
            this.clProduct = new System.Windows.Forms.ColumnHeader();
            this.clName = new System.Windows.Forms.ColumnHeader();
            this.clSpec = new System.Windows.Forms.ColumnHeader();
            this.clCount = new System.Windows.Forms.ColumnHeader();
            this.clBox = new System.Windows.Forms.ColumnHeader();
            this.clOpenCount = new System.Windows.Forms.ColumnHeader();
            this.clOpenBox = new System.Windows.Forms.ColumnHeader();
            this.clId = new System.Windows.Forms.ColumnHeader();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBarcode
            // 
            this.lblBarcode.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
            this.lblBarcode.ForeColor = System.Drawing.Color.White;
            this.lblBarcode.Location = new System.Drawing.Point(0, 0);
            this.lblBarcode.Name = "lblBarcode";
            this.lblBarcode.Size = new System.Drawing.Size(100, 20);
            this.lblBarcode.Text = "商品条码：";
            // 
            // pbBarcode
            // 
            this.pbBarcode.BackColor = System.Drawing.Color.White;
            this.pbBarcode.Location = new System.Drawing.Point(100, 18);
            this.pbBarcode.Name = "pbBarcode";
            this.pbBarcode.Size = new System.Drawing.Size(200, 2);
            this.pbBarcode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            // 
            // txtBarCode
            // 
            this.txtBarCode.BackColor = System.Drawing.Color.Black;
            this.txtBarCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBarCode.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
            this.txtBarCode.ForeColor = System.Drawing.Color.White;
            this.txtBarCode.Location = new System.Drawing.Point(100, 0);
            this.txtBarCode.MaxLength = 20;
            this.txtBarCode.Name = "txtBarCode";
            this.txtBarCode.Size = new System.Drawing.Size(200, 25);
            this.txtBarCode.TabIndex = 1;
            this.txtBarCode.TabStop = false;
            this.txtBarCode.Tag = "True";
            this.txtBarCode.WordWrap = false;
            this.txtBarCode.GotFocus += new System.EventHandler(this.txtBarCode_GotFocus);
            this.txtBarCode.LostFocus += new System.EventHandler(this.txtBarCode_LostFocus);
            // 
            // lvData
            // 
            this.lvData.BackColor = System.Drawing.Color.Black;
            this.lvData.Columns.Add(this.clCompany);
            this.lvData.Columns.Add(this.clProduct);
            this.lvData.Columns.Add(this.clName);
            this.lvData.Columns.Add(this.clSpec);
            this.lvData.Columns.Add(this.clCount);
            this.lvData.Columns.Add(this.clBox);
            this.lvData.Columns.Add(this.clOpenCount);
            this.lvData.Columns.Add(this.clOpenBox);
            this.lvData.Columns.Add(this.clId);
            this.lvData.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
            this.lvData.ForeColor = System.Drawing.Color.White;
            this.lvData.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvData.Location = new System.Drawing.Point(3, 29);
            this.lvData.Name = "lvData";
            this.lvData.Size = new System.Drawing.Size(294, 200);
            this.lvData.TabIndex = 2;
            this.lvData.Tag = "True";
            this.lvData.View = System.Windows.Forms.View.Details;
            // 
            // clCompany
            // 
            this.clCompany.Text = "商家条码";
            this.clCompany.Width = 83;
            // 
            // clProduct
            // 
            this.clProduct.Text = "商品编码";
            this.clProduct.Width = 82;
            // 
            // clName
            // 
            this.clName.Text = "商品名称";
            this.clName.Width = 81;
            // 
            // clSpec
            // 
            this.clSpec.Text = "规格";
            this.clSpec.Width = 60;
            // 
            // clCount
            // 
            this.clCount.Text = "预到数";
            this.clCount.Width = 60;
            // 
            // clBox
            // 
            this.clBox.Text = "预到数：托/箱";
            this.clBox.Width = 60;
            // 
            // clOpenCount
            // 
            this.clOpenCount.Text = "未收数";
            this.clOpenCount.Width = 60;
            // 
            // clOpenBox
            // 
            this.clOpenBox.Text = "未收数：托/箱";
            this.clOpenBox.Width = 60;
            // 
            // clId
            // 
            this.clId.Text = "id";
            this.clId.Width = 60;
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
            this.btnCancel.Text = "返回 [&F4]";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSet
            // 
            this.btnSet.BackColor = System.Drawing.Color.Black;
            this.btnSet.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
            this.btnSet.ForeColor = System.Drawing.Color.White;
            this.btnSet.Location = new System.Drawing.Point(100, 235);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(80, 25);
            this.btnSet.TabIndex = 5;
            this.btnSet.TabStop = false;
            this.btnSet.Tag = "True";
            this.btnSet.Text = "设置";
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // UCReceiveDetail_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.btnSet);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lvData);
            this.Controls.Add(this.pbBarcode);
            this.Controls.Add(this.txtBarCode);
            this.Controls.Add(this.lblBarcode);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "UCReceiveDetail_2";
            this.Size = new System.Drawing.Size(300, 260);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblBarcode;
        private System.Windows.Forms.PictureBox pbBarcode;
        private System.Windows.Forms.TextBox txtBarCode;
        private System.Windows.Forms.ListView lvData;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.ColumnHeader clCompany;
        private System.Windows.Forms.ColumnHeader clProduct;
        private System.Windows.Forms.ColumnHeader clName;
        private System.Windows.Forms.ColumnHeader clSpec;
        private System.Windows.Forms.ColumnHeader clCount;
        private System.Windows.Forms.ColumnHeader clBox;
        private System.Windows.Forms.ColumnHeader clOpenCount;
        private System.Windows.Forms.ColumnHeader clOpenBox;
        private System.Windows.Forms.ColumnHeader clId;
    }
}
