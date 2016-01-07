namespace SCM.RF.Client.Tool.Controls.Login
{
    partial class UCSetting
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.PictureBox pbPort;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label lbPort;
        private System.Windows.Forms.PictureBox pbIP;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label lbIP;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button BtnScan;
        private System.Windows.Forms.Button btnWifi;

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
            this.pbPort = new System.Windows.Forms.PictureBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.lbPort = new System.Windows.Forms.Label();
            this.pbIP = new System.Windows.Forms.PictureBox();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.lbIP = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.BtnScan = new System.Windows.Forms.Button();
            this.btnWifi = new System.Windows.Forms.Button();
            this.btnIME = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pbPort
            // 
            this.pbPort.BackColor = System.Drawing.Color.White;
            this.pbPort.Location = new System.Drawing.Point(70, 58);
            this.pbPort.Name = "pbPort";
            this.pbPort.Size = new System.Drawing.Size(142, 2);
            this.pbPort.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            // 
            // txtPort
            // 
            this.txtPort.BackColor = System.Drawing.Color.Black;
            this.txtPort.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPort.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
            this.txtPort.ForeColor = System.Drawing.Color.White;
            this.txtPort.Location = new System.Drawing.Point(70, 40);
            this.txtPort.MaxLength = 4;
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(142, 25);
            this.txtPort.TabIndex = 2;
            this.txtPort.TabStop = false;
            this.txtPort.Tag = "True";
            this.txtPort.WordWrap = false;
            this.txtPort.GotFocus += new System.EventHandler(this.txtPort_GotFocus);
            this.txtPort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPort_KeyPress);
            this.txtPort.LostFocus += new System.EventHandler(this.txtPort_LostFocus);
            // 
            // lbPort
            // 
            this.lbPort.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
            this.lbPort.ForeColor = System.Drawing.Color.White;
            this.lbPort.Location = new System.Drawing.Point(0, 40);
            this.lbPort.Name = "lbPort";
            this.lbPort.Size = new System.Drawing.Size(78, 25);
            this.lbPort.Text = "端   号：";
            // 
            // pbIP
            // 
            this.pbIP.BackColor = System.Drawing.Color.White;
            this.pbIP.Location = new System.Drawing.Point(70, 18);
            this.pbIP.Name = "pbIP";
            this.pbIP.Size = new System.Drawing.Size(142, 2);
            this.pbIP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            // 
            // txtIP
            // 
            this.txtIP.BackColor = System.Drawing.Color.Black;
            this.txtIP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIP.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
            this.txtIP.ForeColor = System.Drawing.Color.White;
            this.txtIP.Location = new System.Drawing.Point(70, 0);
            this.txtIP.MaxLength = 20;
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(142, 25);
            this.txtIP.TabIndex = 1;
            this.txtIP.TabStop = false;
            this.txtIP.Tag = "True";
            this.txtIP.WordWrap = false;
            this.txtIP.GotFocus += new System.EventHandler(this.txtIP_GotFocus);
            this.txtIP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIP_KeyPress);
            this.txtIP.LostFocus += new System.EventHandler(this.txtIP_LostFocus);
            // 
            // lbIP
            // 
            this.lbIP.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
            this.lbIP.ForeColor = System.Drawing.Color.White;
            this.lbIP.Location = new System.Drawing.Point(0, 0);
            this.lbIP.Name = "lbIP";
            this.lbIP.Size = new System.Drawing.Size(78, 25);
            this.lbIP.Text = "IP地址：";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Black;
            this.btnCancel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(120, 218);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 25);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.TabStop = false;
            this.btnCancel.Tag = "True";
            this.btnCancel.Text = "返回 [&F1]";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Black;
            this.btnSave.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(20, 218);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 25);
            this.btnSave.TabIndex = 7;
            this.btnSave.TabStop = false;
            this.btnSave.Tag = "True";
            this.btnSave.Text = "保存 [&F5]";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // BtnScan
            // 
            this.BtnScan.BackColor = System.Drawing.Color.Black;
            this.BtnScan.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
            this.BtnScan.ForeColor = System.Drawing.Color.White;
            this.BtnScan.Location = new System.Drawing.Point(20, 150);
            this.BtnScan.Name = "BtnScan";
            this.BtnScan.Size = new System.Drawing.Size(80, 25);
            this.BtnScan.TabIndex = 3;
            this.BtnScan.TabStop = false;
            this.BtnScan.Tag = "True";
            this.BtnScan.Text = "开启扫描";
            this.BtnScan.Click += new System.EventHandler(this.BtnScan_Click);
            // 
            // btnWifi
            // 
            this.btnWifi.BackColor = System.Drawing.Color.Black;
            this.btnWifi.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
            this.btnWifi.ForeColor = System.Drawing.Color.White;
            this.btnWifi.Location = new System.Drawing.Point(20, 184);
            this.btnWifi.Name = "btnWifi";
            this.btnWifi.Size = new System.Drawing.Size(80, 25);
            this.btnWifi.TabIndex = 5;
            this.btnWifi.TabStop = false;
            this.btnWifi.Tag = "True";
            this.btnWifi.Text = "开启 WIFI";
            this.btnWifi.Click += new System.EventHandler(this.btnWifi_Click);
            // 
            // btnIME
            // 
            this.btnIME.BackColor = System.Drawing.Color.Black;
            this.btnIME.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
            this.btnIME.ForeColor = System.Drawing.Color.White;
            this.btnIME.Location = new System.Drawing.Point(120, 150);
            this.btnIME.Name = "btnIME";
            this.btnIME.Size = new System.Drawing.Size(80, 25);
            this.btnIME.TabIndex = 4;
            this.btnIME.TabStop = false;
            this.btnIME.Tag = "True";
            this.btnIME.Text = "输入法";
            this.btnIME.Click += new System.EventHandler(this.btnIME_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Black;
            this.btnExit.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(120, 184);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(80, 25);
            this.btnExit.TabIndex = 6;
            this.btnExit.TabStop = false;
            this.btnExit.Tag = "True";
            this.btnExit.Text = "退出系统";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // UCSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnIME);
            this.Controls.Add(this.btnWifi);
            this.Controls.Add(this.BtnScan);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pbPort);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.lbPort);
            this.Controls.Add(this.pbIP);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.lbIP);
            this.Name = "UCSetting";
            this.Size = new System.Drawing.Size(220, 260);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIME;
        private System.Windows.Forms.Button btnExit;
    }
}
