namespace SCM.RF.Client.Tool.Controls.HandOver
{
    partial class UCHandOver1
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox listScheme;
        private System.Windows.Forms.Button btnStart;

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
            this.btnCancel = new System.Windows.Forms.Button();
            this.listScheme = new System.Windows.Forms.ComboBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnOld = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Black;
            this.btnCancel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(10, 235);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 25);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.TabStop = false;
            this.btnCancel.Text = "返回 [&F1]";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // listScheme
            // 
            this.listScheme.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
            this.listScheme.Location = new System.Drawing.Point(0, 0);
            this.listScheme.Name = "listScheme";
            this.listScheme.Size = new System.Drawing.Size(300, 25);
            this.listScheme.TabIndex = 2;
            this.listScheme.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Black;
            this.btnStart.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(210, 235);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(80, 25);
            this.btnStart.TabIndex = 3;
            this.btnStart.TabStop = false;
            this.btnStart.Text = "新版[&F10]";
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnOld
            // 
            this.btnOld.BackColor = System.Drawing.Color.Black;
            this.btnOld.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
            this.btnOld.ForeColor = System.Drawing.Color.White;
            this.btnOld.Location = new System.Drawing.Point(110, 235);
            this.btnOld.Name = "btnOld";
            this.btnOld.Size = new System.Drawing.Size(80, 25);
            this.btnOld.TabIndex = 4;
            this.btnOld.TabStop = false;
            this.btnOld.Text = "旧版[&F6]";
            this.btnOld.Click += new System.EventHandler(this.btnOld_Click);
            // 
            // UCHandOver1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.btnOld);
            this.Controls.Add(this.listScheme);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnCancel);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "UCHandOver1";
            this.Size = new System.Drawing.Size(300, 260);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOld;
    }
}
