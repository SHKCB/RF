namespace SCM.RF.Client.Tool.Controls.PutAway
{
    partial class UCPutaway2
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lbNormal;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lbBad;
        private System.Windows.Forms.PictureBox pbMenu;
        private System.Windows.Forms.TextBox txtMenu;
        private System.Windows.Forms.Label lbMenu;

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
            this.lbNormal = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lbBad = new System.Windows.Forms.Label();
            this.pbMenu = new System.Windows.Forms.PictureBox();
            this.txtMenu = new System.Windows.Forms.TextBox();
            this.lbMenu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbNormal
            // 
            this.lbNormal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
            this.lbNormal.ForeColor = System.Drawing.Color.White;
            this.lbNormal.Location = new System.Drawing.Point(0, 0);
            this.lbNormal.Name = "lbNormal";
            this.lbNormal.Size = new System.Drawing.Size(300, 25);
            this.lbNormal.Text = "1、正品上架";
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
            this.btnCancel.Tag = "True";
            this.btnCancel.Text = "返回 [&F1]";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lbBad
            // 
            this.lbBad.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
            this.lbBad.ForeColor = System.Drawing.Color.White;
            this.lbBad.Location = new System.Drawing.Point(0, 40);
            this.lbBad.Name = "lbBad";
            this.lbBad.Size = new System.Drawing.Size(300, 25);
            this.lbBad.Text = "2、次品上架";
            // 
            // pbMenu
            // 
            this.pbMenu.BackColor = System.Drawing.Color.White;
            this.pbMenu.Location = new System.Drawing.Point(178, 253);
            this.pbMenu.Name = "pbMenu";
            this.pbMenu.Size = new System.Drawing.Size(10, 2);
            this.pbMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            // 
            // txtMenu
            // 
            this.txtMenu.BackColor = System.Drawing.Color.Black;
            this.txtMenu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMenu.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
            this.txtMenu.ForeColor = System.Drawing.Color.White;
            this.txtMenu.Location = new System.Drawing.Point(178, 235);
            this.txtMenu.MaxLength = 1;
            this.txtMenu.Name = "txtMenu";
            this.txtMenu.Size = new System.Drawing.Size(10, 25);
            this.txtMenu.TabIndex = 2;
            this.txtMenu.TabStop = false;
            this.txtMenu.Tag = "True";
            this.txtMenu.TextChanged += new System.EventHandler(this.txtMenu_TextChanged);
            this.txtMenu.GotFocus += new System.EventHandler(this.txtMenu_GotFocus);
            this.txtMenu.LostFocus += new System.EventHandler(this.txtMenu_LostFocus);
            // 
            // lbMenu
            // 
            this.lbMenu.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
            this.lbMenu.ForeColor = System.Drawing.Color.White;
            this.lbMenu.Location = new System.Drawing.Point(103, 238);
            this.lbMenu.Name = "lbMenu";
            this.lbMenu.Size = new System.Drawing.Size(70, 18);
            this.lbMenu.Text = "选择功能";
            // 
            // UCPutaway2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.pbMenu);
            this.Controls.Add(this.txtMenu);
            this.Controls.Add(this.lbMenu);
            this.Controls.Add(this.lbBad);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lbNormal);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "UCPutaway2";
            this.Size = new System.Drawing.Size(300, 260);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
