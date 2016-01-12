namespace SCM.RF.Client.Tool.Controls.Login
{
    partial class UCMenu
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtMenu;
        private System.Windows.Forms.Label lbMenu;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pbMenu;

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
            this.txtMenu = new System.Windows.Forms.TextBox();
            this.lbMenu = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.pbMenu = new System.Windows.Forms.PictureBox();
            this.lbSH = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            this.txtMenu.TabIndex = 1;
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
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Black;
            this.btnExit.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(10, 235);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(80, 25);
            this.btnExit.TabIndex = 2;
            this.btnExit.TabStop = false;
            this.btnExit.Tag = "True";
            this.btnExit.Text = "退出 [&F4]";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pbMenu
            // 
            this.pbMenu.BackColor = System.Drawing.Color.White;
            this.pbMenu.Location = new System.Drawing.Point(178, 253);
            this.pbMenu.Name = "pbMenu";
            this.pbMenu.Size = new System.Drawing.Size(10, 2);
            this.pbMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            // 
            // lbSH
            // 
            this.lbSH.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
            this.lbSH.ForeColor = System.Drawing.Color.White;
            this.lbSH.Location = new System.Drawing.Point(10, 2);
            this.lbSH.Name = "lbSH";
            this.lbSH.Size = new System.Drawing.Size(100, 20);
            this.lbSH.Text = "1、收货";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.Text = "2、定位";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(10, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.Text = "3、上架";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(10, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.Text = "4、拣货";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(10, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.Text = "5、移库";
            // 
            // UCMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbSH);
            this.Controls.Add(this.pbMenu);
            this.Controls.Add(this.txtMenu);
            this.Controls.Add(this.lbMenu);
            this.Controls.Add(this.btnExit);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "UCMenu";
            this.Size = new System.Drawing.Size(300, 260);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbSH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
