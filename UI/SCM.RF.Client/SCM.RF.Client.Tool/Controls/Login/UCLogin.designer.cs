namespace SCM.RF.Client.Tool.Controls.Login
{
    partial class UCLogin
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtPassWord;
        private System.Windows.Forms.PictureBox pbPassWord;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.PictureBox pbUserName;
        private System.Windows.Forms.TextBox txtBarCode;
        private System.Windows.Forms.PictureBox pbBarCode;
        private System.Windows.Forms.Label lbPassWord;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.Label lbBarCode;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbRF;

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
            this.btnSetting = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPassWord = new System.Windows.Forms.TextBox();
            this.pbPassWord = new System.Windows.Forms.PictureBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.pbUserName = new System.Windows.Forms.PictureBox();
            this.txtBarCode = new System.Windows.Forms.TextBox();
            this.pbBarCode = new System.Windows.Forms.PictureBox();
            this.lbPassWord = new System.Windows.Forms.Label();
            this.lbUserName = new System.Windows.Forms.Label();
            this.lbBarCode = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbRF = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSetting
            // 
            this.btnSetting.BackColor = System.Drawing.Color.Black;
            this.btnSetting.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
            this.btnSetting.ForeColor = System.Drawing.Color.White;
            this.btnSetting.Location = new System.Drawing.Point(206, 220);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(80, 25);
            this.btnSetting.TabIndex = 1;
            this.btnSetting.TabStop = false;
            this.btnSetting.Tag = "True";
            this.btnSetting.Text = "配置 [&F8]";
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Black;
            this.btnReset.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(110, 220);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(80, 25);
            this.btnReset.TabIndex = 2;
            this.btnReset.TabStop = false;
            this.btnReset.Tag = "True";
            this.btnReset.Text = "重置 [&F4]";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Black;
            this.btnLogin.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(14, 220);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(80, 25);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.TabStop = false;
            this.btnLogin.Tag = "True";
            this.btnLogin.Text = "登录 [&F1]";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPassWord
            // 
            this.txtPassWord.BackColor = System.Drawing.Color.Black;
            this.txtPassWord.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassWord.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
            this.txtPassWord.ForeColor = System.Drawing.Color.White;
            this.txtPassWord.Location = new System.Drawing.Point(130, 170);
            this.txtPassWord.MaxLength = 20;
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.PasswordChar = '*';
            this.txtPassWord.Size = new System.Drawing.Size(140, 25);
            this.txtPassWord.TabIndex = 2;
            this.txtPassWord.TabStop = false;
            this.txtPassWord.Tag = "True";
            this.txtPassWord.WordWrap = false;
            this.txtPassWord.GotFocus += new System.EventHandler(this.txtPassWord_GotFocus);
            this.txtPassWord.KeyPress += new System.Windows.Forms.KeyPressEventHandler(txtPassWord_KeyPress);
            this.txtPassWord.LostFocus += new System.EventHandler(this.txtPassWord_LostFocus);
            // 
            // pbPassWord
            // 
            this.pbPassWord.BackColor = System.Drawing.Color.White;
            this.pbPassWord.Location = new System.Drawing.Point(130, 190);
            this.pbPassWord.Name = "pbPassWord";
            this.pbPassWord.Size = new System.Drawing.Size(140, 2);
            this.pbPassWord.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.Color.Black;
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
            this.txtUserName.ForeColor = System.Drawing.Color.White;
            this.txtUserName.Location = new System.Drawing.Point(130, 130);
            this.txtUserName.MaxLength = 20;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(140, 25);
            this.txtUserName.TabIndex = 5;
            this.txtUserName.TabStop = false;
            this.txtUserName.Tag = "True";
            this.txtUserName.WordWrap = false;
            this.txtUserName.GotFocus += new System.EventHandler(this.txtUserName_GotFocus);
            this.txtUserName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(txtUserName_KeyPress);
            this.txtUserName.LostFocus += new System.EventHandler(this.txtUserName_LostFocus);
            // 
            // pbUserName
            // 
            this.pbUserName.BackColor = System.Drawing.Color.White;
            this.pbUserName.Location = new System.Drawing.Point(130, 150);
            this.pbUserName.Name = "pbUserName";
            this.pbUserName.Size = new System.Drawing.Size(140, 2);
            this.pbUserName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            // 
            // txtBarCode
            // 
            this.txtBarCode.BackColor = System.Drawing.Color.Black;
            this.txtBarCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBarCode.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
            this.txtBarCode.ForeColor = System.Drawing.Color.White;
            this.txtBarCode.Location = new System.Drawing.Point(130, 90);
            this.txtBarCode.MaxLength = 20;
            this.txtBarCode.Name = "txtBarCode";
            this.txtBarCode.Size = new System.Drawing.Size(140, 25);
            this.txtBarCode.TabIndex = 6;
            this.txtBarCode.TabStop = false;
            this.txtBarCode.Tag = "True";
            this.txtBarCode.WordWrap = false;
            this.txtBarCode.GotFocus += new System.EventHandler(this.txtBarCode_GotFocus);
            this.txtBarCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(txtBarCode_KeyPress);
            this.txtBarCode.LostFocus += new System.EventHandler(this.txtBarCode_LostFocus);
            // 
            // pbBarCode
            // 
            this.pbBarCode.BackColor = System.Drawing.Color.White;
            this.pbBarCode.Location = new System.Drawing.Point(130, 110);
            this.pbBarCode.Name = "pbBarCode";
            this.pbBarCode.Size = new System.Drawing.Size(140, 2);
            this.pbBarCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            // 
            // lbPassWord
            // 
            this.lbPassWord.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
            this.lbPassWord.ForeColor = System.Drawing.Color.White;
            this.lbPassWord.Location = new System.Drawing.Point(30, 170);
            this.lbPassWord.Name = "lbPassWord";
            this.lbPassWord.Size = new System.Drawing.Size(100, 25);
            this.lbPassWord.Text = "密      码：";
            // 
            // lbUserName
            // 
            this.lbUserName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
            this.lbUserName.ForeColor = System.Drawing.Color.White;
            this.lbUserName.Location = new System.Drawing.Point(30, 130);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(100, 25);
            this.lbUserName.Text = "用 户 名：";
            // 
            // lbBarCode
            // 
            this.lbBarCode.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
            this.lbBarCode.ForeColor = System.Drawing.Color.White;
            this.lbBarCode.Location = new System.Drawing.Point(30, 90);
            this.lbBarCode.Name = "lbBarCode";
            this.lbBarCode.Size = new System.Drawing.Size(100, 25);
            this.lbBarCode.Text = "登录条码：";
            // 
            // lbTitle
            // 
            this.lbTitle.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.lbTitle.ForeColor = System.Drawing.Color.White;
            this.lbTitle.Location = new System.Drawing.Point(37, 17);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(226, 28);
            this.lbTitle.Text = "物流生产管理系统";
            // 
            // lbRF
            // 
            this.lbRF.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.lbRF.ForeColor = System.Drawing.Color.White;
            this.lbRF.Location = new System.Drawing.Point(109, 47);
            this.lbRF.Name = "lbRF";
            this.lbRF.Size = new System.Drawing.Size(82, 22);
            this.lbRF.Text = "RF终端";
            // 
            // UCLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.lbRF);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.pbBarCode);
            this.Controls.Add(this.pbUserName);
            this.Controls.Add(this.pbPassWord);
            this.Controls.Add(this.btnSetting);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassWord);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.txtBarCode);
            this.Controls.Add(this.lbPassWord);
            this.Controls.Add(this.lbUserName);
            this.Controls.Add(this.lbBarCode);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "UCLogin";
            this.Size = new System.Drawing.Size(300, 260);
            this.ResumeLayout(false);
        }

        #endregion
    }
}
