namespace SCM.RF.Client.Tool.Controls.Picking
{
    partial class UCPickingByTaskID
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.pbTaskNo = new System.Windows.Forms.PictureBox();
            this.txtTaskNo = new System.Windows.Forms.TextBox();
            this.lbTaskNo = new System.Windows.Forms.Label();
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
            this.btnCancel.TabIndex = 2;
            this.btnCancel.TabStop = false;
            this.btnCancel.Tag = "True";
            this.btnCancel.Text = "返回 [&F4]";
            // 
            // pbTaskNo
            // 
            this.pbTaskNo.BackColor = System.Drawing.Color.White;
            this.pbTaskNo.Location = new System.Drawing.Point(100, 18);
            this.pbTaskNo.Name = "pbTaskNo";
            this.pbTaskNo.Size = new System.Drawing.Size(200, 2);
            this.pbTaskNo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            // 
            // txtTaskNo
            // 
            this.txtTaskNo.BackColor = System.Drawing.Color.Black;
            this.txtTaskNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTaskNo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
            this.txtTaskNo.ForeColor = System.Drawing.Color.White;
            this.txtTaskNo.Location = new System.Drawing.Point(100, 0);
            this.txtTaskNo.MaxLength = 20;
            this.txtTaskNo.Name = "txtTaskNo";
            this.txtTaskNo.Size = new System.Drawing.Size(200, 25);
            this.txtTaskNo.TabIndex = 1;
            this.txtTaskNo.TabStop = false;
            this.txtTaskNo.Tag = "True";
            this.txtTaskNo.WordWrap = false;
            this.txtTaskNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTaskNo_KeyPress);
            // 
            // lbTaskNo
            // 
            this.lbTaskNo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
            this.lbTaskNo.ForeColor = System.Drawing.Color.White;
            this.lbTaskNo.Location = new System.Drawing.Point(0, 0);
            this.lbTaskNo.Name = "lbTaskNo";
            this.lbTaskNo.Size = new System.Drawing.Size(100, 20);
            this.lbTaskNo.Text = "任务单号：";
            // 
            // UCPickingByTaskID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.pbTaskNo);
            this.Controls.Add(this.txtTaskNo);
            this.Controls.Add(this.lbTaskNo);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "UCPickingByTaskID";
            this.Size = new System.Drawing.Size(300, 260);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.PictureBox pbTaskNo;
        private System.Windows.Forms.TextBox txtTaskNo;
        private System.Windows.Forms.Label lbTaskNo;

    }
}
