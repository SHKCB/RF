namespace SCM.RF.Client.Tool.Controls.Receive
{
    partial class UCReceiveMain
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
            this.lblreceiveNo = new System.Windows.Forms.Label();
            this.pbReceiveNo = new System.Windows.Forms.PictureBox();
            this.txtReceiveNo = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblreceiveNo
            // 
            this.lblreceiveNo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
            this.lblreceiveNo.ForeColor = System.Drawing.Color.White;
            this.lblreceiveNo.Location = new System.Drawing.Point(0, 0);
            this.lblreceiveNo.Name = "lblreceiveNo";
            this.lblreceiveNo.Size = new System.Drawing.Size(100, 20);
            this.lblreceiveNo.Text = "入库单号：";
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
            this.txtReceiveNo.GotFocus += new System.EventHandler(this.txtReceiveNo_GotFocus);
            this.txtReceiveNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtReceiveNo_KeyPress);
            this.txtReceiveNo.LostFocus += new System.EventHandler(this.txtReceiveNo_LostFocus);
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
            this.btnCancel.Text = "返回 [&F4]";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // UCReceiveMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.pbReceiveNo);
            this.Controls.Add(this.txtReceiveNo);
            this.Controls.Add(this.lblreceiveNo);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "UCReceiveMain";
            this.Size = new System.Drawing.Size(300, 260);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblreceiveNo;
        private System.Windows.Forms.PictureBox pbReceiveNo;
        private System.Windows.Forms.TextBox txtReceiveNo;
        private System.Windows.Forms.Button btnCancel;
    }
}
