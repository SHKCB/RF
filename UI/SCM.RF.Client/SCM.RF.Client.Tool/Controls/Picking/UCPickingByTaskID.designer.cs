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
            this.pbType = new System.Windows.Forms.PictureBox();
            this.txtType = new System.Windows.Forms.TextBox();
            this.lbType = new System.Windows.Forms.Label();
            this.lbDeliveryNO = new System.Windows.Forms.Label();
            this.lbOrderID = new System.Windows.Forms.Label();
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
            this.btnCancel.TabIndex = 3;
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
            this.txtTaskNo.GotFocus += new System.EventHandler(this.txtTaskNo_GotFocus);
            this.txtTaskNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTaskNo_KeyPress);
            this.txtTaskNo.LostFocus += new System.EventHandler(this.txtTaskNo_LostFocus);
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
            // pbType
            // 
            this.pbType.BackColor = System.Drawing.Color.White;
            this.pbType.Location = new System.Drawing.Point(100, 68);
            this.pbType.Name = "pbType";
            this.pbType.Size = new System.Drawing.Size(200, 2);
            this.pbType.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            // 
            // txtType
            // 
            this.txtType.BackColor = System.Drawing.Color.Black;
            this.txtType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtType.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
            this.txtType.ForeColor = System.Drawing.Color.White;
            this.txtType.Location = new System.Drawing.Point(100, 50);
            this.txtType.MaxLength = 20;
            this.txtType.Name = "txtType";
            this.txtType.ReadOnly = true;
            this.txtType.Size = new System.Drawing.Size(200, 25);
            this.txtType.TabIndex = 2;
            this.txtType.TabStop = false;
            this.txtType.Tag = "True";
            this.txtType.WordWrap = false;
            this.txtType.GotFocus += new System.EventHandler(this.txtType_GotFocus);
            this.txtType.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtType_KeyPress);
            this.txtType.LostFocus += new System.EventHandler(this.txtType_LostFocus);
            // 
            // lbType
            // 
            this.lbType.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
            this.lbType.ForeColor = System.Drawing.Color.White;
            this.lbType.Location = new System.Drawing.Point(0, 50);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(100, 20);
            this.lbType.Text = "拣货类型：";
            // 
            // lbDeliveryNO
            // 
            this.lbDeliveryNO.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
            this.lbDeliveryNO.ForeColor = System.Drawing.Color.White;
            this.lbDeliveryNO.Location = new System.Drawing.Point(150, 100);
            this.lbDeliveryNO.Name = "lbDeliveryNO";
            this.lbDeliveryNO.Size = new System.Drawing.Size(100, 20);
            this.lbDeliveryNO.Text = "2、边拣边分";
            // 
            // lbOrderID
            // 
            this.lbOrderID.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
            this.lbOrderID.ForeColor = System.Drawing.Color.White;
            this.lbOrderID.Location = new System.Drawing.Point(50, 100);
            this.lbOrderID.Name = "lbOrderID";
            this.lbOrderID.Size = new System.Drawing.Size(100, 20);
            this.lbOrderID.Text = "1、先拣后分";
            // 
            // UCPickingByTaskID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.lbDeliveryNO);
            this.Controls.Add(this.lbOrderID);
            this.Controls.Add(this.pbType);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.lbType);
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
        private System.Windows.Forms.PictureBox pbType;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.Label lbDeliveryNO;
        private System.Windows.Forms.Label lbOrderID;

    }
}
