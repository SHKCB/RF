namespace SCM.RF.Client.AutoUpdate
{
    partial class Update
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.pbTotal = new System.Windows.Forms.ProgressBar();
            this.lbTotal = new System.Windows.Forms.Label();
            this.lbCurt = new System.Windows.Forms.Label();
            this.pbCurt = new System.Windows.Forms.ProgressBar();
            this.lbProc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pbTotal
            // 
            this.pbTotal.Location = new System.Drawing.Point(99, 144);
            this.pbTotal.Name = "pbTotal";
            this.pbTotal.Size = new System.Drawing.Size(200, 20);
            // 
            // lbTotal
            // 
            this.lbTotal.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
            this.lbTotal.ForeColor = System.Drawing.Color.White;
            this.lbTotal.Location = new System.Drawing.Point(21, 146);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(72, 20);
            this.lbTotal.Text = "总  进  度：";
            // 
            // lbCurt
            // 
            this.lbCurt.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
            this.lbCurt.ForeColor = System.Drawing.Color.White;
            this.lbCurt.Location = new System.Drawing.Point(21, 121);
            this.lbCurt.Name = "lbCurt";
            this.lbCurt.Size = new System.Drawing.Size(72, 20);
            this.lbCurt.Text = "当前进度：";
            // 
            // pbCurt
            // 
            this.pbCurt.Location = new System.Drawing.Point(99, 118);
            this.pbCurt.Name = "pbCurt";
            this.pbCurt.Size = new System.Drawing.Size(200, 20);
            // 
            // lbProc
            // 
            this.lbProc.ForeColor = System.Drawing.Color.White;
            this.lbProc.Location = new System.Drawing.Point(0, 182);
            this.lbProc.Name = "lbProc";
            this.lbProc.Size = new System.Drawing.Size(320, 20);
            this.lbProc.Text = "0%";
            this.lbProc.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(320, 320);
            this.ControlBox = false;
            this.Controls.Add(this.lbProc);
            this.Controls.Add(this.pbCurt);
            this.Controls.Add(this.lbCurt);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.pbTotal);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Update";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Update_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar pbTotal;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label lbCurt;
        private System.Windows.Forms.ProgressBar pbCurt;
        private System.Windows.Forms.Label lbProc;
    }
}