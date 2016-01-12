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
            this.pbUserName = new System.Windows.Forms.PictureBox();
            this.txtReceiveNo = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblreceiveNo
            // 
            this.lblreceiveNo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
            this.lblreceiveNo.ForeColor = System.Drawing.Color.White;
            this.lblreceiveNo.Location = new System.Drawing.Point(10, 60);
            this.lblreceiveNo.Name = "lblreceiveNo";
            this.lblreceiveNo.Size = new System.Drawing.Size(119, 20);
            this.lblreceiveNo.Text = "待收货入库单:";
            // 
            // pbUserName
            // 
            this.pbUserName.BackColor = System.Drawing.Color.White;
            this.pbUserName.Location = new System.Drawing.Point(10, 103);
            this.pbUserName.Name = "pbUserName";
            this.pbUserName.Size = new System.Drawing.Size(195, 2);
            this.pbUserName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            // 
            // txtReceiveNo
            // 
            this.txtReceiveNo.BackColor = System.Drawing.Color.Black;
            this.txtReceiveNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtReceiveNo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
            this.txtReceiveNo.ForeColor = System.Drawing.Color.White;
            this.txtReceiveNo.Location = new System.Drawing.Point(10, 83);
            this.txtReceiveNo.MaxLength = 11;
            this.txtReceiveNo.Name = "txtReceiveNo";
            this.txtReceiveNo.Size = new System.Drawing.Size(195, 25);
            this.txtReceiveNo.TabIndex = 2;
            this.txtReceiveNo.TabStop = false;
            this.txtReceiveNo.Tag = "True";
            this.txtReceiveNo.WordWrap = false;
            this.txtReceiveNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtReceiveNo_KeyDown);
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.Black;
            this.btnOk.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
            this.btnOk.ForeColor = System.Drawing.Color.White;
            this.btnOk.Location = new System.Drawing.Point(10, 235);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(80, 25);
            this.btnOk.TabIndex = 4;
            this.btnOk.TabStop = false;
            this.btnOk.Tag = "True";
            this.btnOk.Text = "确定[&F1]";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btncancel
            // 
            this.btncancel.BackColor = System.Drawing.Color.Black;
            this.btncancel.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
            this.btncancel.ForeColor = System.Drawing.Color.White;
            this.btncancel.Location = new System.Drawing.Point(135, 235);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(80, 25);
            this.btncancel.TabIndex = 5;
            this.btncancel.TabStop = false;
            this.btncancel.Tag = "True";
            this.btncancel.Text = "返回[&F4]";
            // 
            // UCReceiveMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.pbUserName);
            this.Controls.Add(this.txtReceiveNo);
            this.Controls.Add(this.lblreceiveNo);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "UCReceiveMain";
            this.Size = new System.Drawing.Size(220, 260);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblreceiveNo;
        private System.Windows.Forms.PictureBox pbUserName;
        private System.Windows.Forms.TextBox txtReceiveNo;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btncancel;
    }
}
