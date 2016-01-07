namespace SCM.RF.Client.Tool.Controls.PutAway
{
    partial class UCPutaway1
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lbBoxNo;
        private System.Windows.Forms.TextBox txtBoxNo;
        private System.Windows.Forms.PictureBox pbBoxNo;
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
            this.lbBoxNo = new System.Windows.Forms.Label();
            this.txtBoxNo = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pbBoxNo = new System.Windows.Forms.PictureBox();
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
            // txtBoxNo
            // 
            this.txtBoxNo.BackColor = System.Drawing.Color.Black;
            this.txtBoxNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxNo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
            this.txtBoxNo.ForeColor = System.Drawing.Color.White;
            this.txtBoxNo.Location = new System.Drawing.Point(100, 0);
            this.txtBoxNo.MaxLength = 14;
            this.txtBoxNo.Name = "txtBoxNo";
            this.txtBoxNo.Size = new System.Drawing.Size(200, 25);
            this.txtBoxNo.TabIndex = 1;
            this.txtBoxNo.TabStop = false;
            this.txtBoxNo.Tag = "True";
            this.txtBoxNo.WordWrap = false;
            this.txtBoxNo.GotFocus += new System.EventHandler(this.txtBoxNo_GotFocus);
            this.txtBoxNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxNo_KeyPress);
            this.txtBoxNo.LostFocus += new System.EventHandler(this.txtBoxNo_LostFocus);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Black;
            this.btnCancel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(10, 235);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 25);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.TabStop = false;
            this.btnCancel.Tag = "True";
            this.btnCancel.Text = "退出 [&F1]";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pbBoxNo
            // 
            this.pbBoxNo.BackColor = System.Drawing.Color.White;
            this.pbBoxNo.Location = new System.Drawing.Point(100, 18);
            this.pbBoxNo.Name = "pbBoxNo";
            this.pbBoxNo.Size = new System.Drawing.Size(200, 2);
            this.pbBoxNo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            // 
            // UCPutaway1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.pbBoxNo);
            this.Controls.Add(this.txtBoxNo);
            this.Controls.Add(this.lbBoxNo);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "UCPutaway1";
            this.Size = new System.Drawing.Size(300, 260);
            this.ResumeLayout(false);

        }

        #endregion
    }
}