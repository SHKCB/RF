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
            this.pbReceiveNo = new System.Windows.Forms.PictureBox();
            this.txtReceiveNo = new System.Windows.Forms.TextBox();
            this.lvData = new System.Windows.Forms.ListView();
            this.btnCancel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
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
            // pbReceiveNo
            // 
            this.pbReceiveNo.BackColor = System.Drawing.Color.White;
            this.pbReceiveNo.Location = new System.Drawing.Point(100, 18);
            this.pbReceiveNo.Name = "pbReceiveNo";
            this.pbReceiveNo.Size = new System.Drawing.Size(200, 2);
            this.pbReceiveNo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            // 
            // txtReceiveNo
            // 
            this.txtReceiveNo.BackColor = System.Drawing.Color.Black;
            this.txtReceiveNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtReceiveNo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
            this.txtReceiveNo.ForeColor = System.Drawing.Color.White;
            this.txtReceiveNo.Location = new System.Drawing.Point(100, 0);
            this.txtReceiveNo.MaxLength = 20;
            this.txtReceiveNo.Name = "txtReceiveNo";
            this.txtReceiveNo.Size = new System.Drawing.Size(200, 25);
            this.txtReceiveNo.TabIndex = 1;
            this.txtReceiveNo.TabStop = false;
            this.txtReceiveNo.Tag = "True";
            this.txtReceiveNo.WordWrap = false;
            // 
            // lvData
            // 
            this.lvData.BackColor = System.Drawing.Color.Black;
            this.lvData.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
            this.lvData.ForeColor = System.Drawing.Color.White;
            this.lvData.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvData.Location = new System.Drawing.Point(3, 26);
            this.lvData.Name = "lvData";
            this.lvData.Size = new System.Drawing.Size(294, 179);
            this.lvData.TabIndex = 2;
            this.lvData.Tag = "True";
            this.lvData.View = System.Windows.Forms.View.Details;
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
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(100, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 25);
            this.button1.TabIndex = 5;
            this.button1.TabStop = false;
            this.button1.Tag = "True";
            this.button1.Text = "返回 [&F4]";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(189, 235);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 25);
            this.button2.TabIndex = 6;
            this.button2.TabStop = false;
            this.button2.Tag = "True";
            this.button2.Text = "返回 [&F4]";
            // 
            // UCReceiveDetail_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lvData);
            this.Controls.Add(this.pbReceiveNo);
            this.Controls.Add(this.txtReceiveNo);
            this.Controls.Add(this.lblBarcode);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "UCReceiveDetail_2";
            this.Size = new System.Drawing.Size(300, 260);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblBarcode;
        private System.Windows.Forms.PictureBox pbReceiveNo;
        private System.Windows.Forms.TextBox txtReceiveNo;
        private System.Windows.Forms.ListView lvData;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
