namespace SCM.RF.Client.Tool.Controls.Common
{
    partial class UCBasicControl
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private UCMessageBox ucMessageBox;

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
            this.ucMessageBox = new SCM.RF.Client.Tool.Controls.Common.UCMessageBox();
            this.SuspendLayout();
            // 
            // ucMessageBox
            // 
            this.ucMessageBox.Location = new System.Drawing.Point(0, 0);
            this.ucMessageBox.Name = "ucMessageBox";
            this.ucMessageBox.Size = new System.Drawing.Size(220, 260);
            this.ucMessageBox.TabIndex = 1;
            this.ucMessageBox.TabStop = false;
            this.ucMessageBox.Visible = false;
            // 
            // UCBasicControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.ucMessageBox);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "UCBasicControl";
            this.Size = new System.Drawing.Size(220, 260);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
