namespace SCM.RF.Client.Tool.Controls.Picking
{
    partial class UCPicking1
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnCancel;

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
            this.lbDeliveryNO = new System.Windows.Forms.Label();
            this.lbOrderID = new System.Windows.Forms.Label();
            this.lbTask = new System.Windows.Forms.Label();
            this.pbMenu = new System.Windows.Forms.PictureBox();
            this.txtMenu = new System.Windows.Forms.TextBox();
            this.lbMenu = new System.Windows.Forms.Label();
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
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lbDeliveryNO
            // 
            this.lbDeliveryNO.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
            this.lbDeliveryNO.ForeColor = System.Drawing.Color.White;
            this.lbDeliveryNO.Location = new System.Drawing.Point(10, 52);
            this.lbDeliveryNO.Name = "lbDeliveryNO";
            this.lbDeliveryNO.Size = new System.Drawing.Size(200, 20);
            this.lbDeliveryNO.Text = "3、按 [运单号] - 拣货";
            // 
            // lbOrderID
            // 
            this.lbOrderID.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
            this.lbOrderID.ForeColor = System.Drawing.Color.White;
            this.lbOrderID.Location = new System.Drawing.Point(10, 27);
            this.lbOrderID.Name = "lbOrderID";
            this.lbOrderID.Size = new System.Drawing.Size(200, 20);
            this.lbOrderID.Text = "2、按 [订单号] - 拣货";
            // 
            // lbTask
            // 
            this.lbTask.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
            this.lbTask.ForeColor = System.Drawing.Color.White;
            this.lbTask.Location = new System.Drawing.Point(10, 2);
            this.lbTask.Name = "lbTask";
            this.lbTask.Size = new System.Drawing.Size(200, 20);
            this.lbTask.Text = "1、按 [任务号] - 拣货";
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
            this.txtMenu.TabIndex = 1;
            this.txtMenu.TabStop = false;
            this.txtMenu.Tag = "True";
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
            // UCPicking1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.pbMenu);
            this.Controls.Add(this.txtMenu);
            this.Controls.Add(this.lbMenu);
            this.Controls.Add(this.lbDeliveryNO);
            this.Controls.Add(this.lbOrderID);
            this.Controls.Add(this.lbTask);
            this.Controls.Add(this.btnCancel);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "UCPicking1";
            this.Size = new System.Drawing.Size(300, 260);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbDeliveryNO;
        private System.Windows.Forms.Label lbOrderID;
        private System.Windows.Forms.Label lbTask;
        private System.Windows.Forms.PictureBox pbMenu;
        private System.Windows.Forms.TextBox txtMenu;
        private System.Windows.Forms.Label lbMenu;
    }
}
