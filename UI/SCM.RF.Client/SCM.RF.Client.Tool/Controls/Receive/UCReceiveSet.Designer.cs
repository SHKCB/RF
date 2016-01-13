namespace SCM.RF.Client.Tool.Controls.Receive
{
    partial class UCReceiveSet
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
            this.cbOutReceive = new System.Windows.Forms.CheckBox();
            this.cbLPN = new System.Windows.Forms.CheckBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbOutReceive
            // 
            this.cbOutReceive.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
            this.cbOutReceive.ForeColor = System.Drawing.Color.White;
            this.cbOutReceive.Location = new System.Drawing.Point(63, 35);
            this.cbOutReceive.Name = "cbOutReceive";
            this.cbOutReceive.Size = new System.Drawing.Size(148, 20);
            this.cbOutReceive.TabIndex = 0;
            this.cbOutReceive.Text = "允许超收";
            // 
            // cbLPN
            // 
            this.cbLPN.Checked = true;
            this.cbLPN.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbLPN.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
            this.cbLPN.ForeColor = System.Drawing.Color.White;
            this.cbLPN.Location = new System.Drawing.Point(63, 86);
            this.cbLPN.Name = "cbLPN";
            this.cbLPN.Size = new System.Drawing.Size(148, 20);
            this.cbLPN.TabIndex = 1;
            this.cbLPN.Text = "自动生成LPN";
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
            // UCReceiveSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.cbLPN);
            this.Controls.Add(this.cbOutReceive);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "UCReceiveSet";
            this.Size = new System.Drawing.Size(300, 260);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox cbOutReceive;
        private System.Windows.Forms.CheckBox cbLPN;
        private System.Windows.Forms.Button btnCancel;
    }
}
