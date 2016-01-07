namespace SCM.RF.Client.Tool.Controls.HandOver
{
    partial class UCHandOver3
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lbTID;
        private System.Windows.Forms.Label lbDeliveryNo;
        private System.Windows.Forms.TextBox txtDeliveryNo;
        private System.Windows.Forms.PictureBox pbDeliveryNo;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lbTID2;

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
            this.lbTID = new System.Windows.Forms.Label();
            this.lbDeliveryNo = new System.Windows.Forms.Label();
            this.txtDeliveryNo = new System.Windows.Forms.TextBox();
            this.pbDeliveryNo = new System.Windows.Forms.PictureBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lbTID2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbTID
            // 
            this.lbTID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
            this.lbTID.ForeColor = System.Drawing.Color.White;
            this.lbTID.Location = new System.Drawing.Point(0, 0);
            this.lbTID.Name = "lbTID";
            this.lbTID.Size = new System.Drawing.Size(100, 25);
            this.lbTID.Text = "交接单号：";
            // 
            // lbDeliveryNo
            // 
            this.lbDeliveryNo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
            this.lbDeliveryNo.ForeColor = System.Drawing.Color.White;
            this.lbDeliveryNo.Location = new System.Drawing.Point(0, 40);
            this.lbDeliveryNo.Name = "lbDeliveryNo";
            this.lbDeliveryNo.Size = new System.Drawing.Size(100, 25);
            this.lbDeliveryNo.Text = "快递号码：";
            // 
            // txtDeliveryNo
            // 
            this.txtDeliveryNo.BackColor = System.Drawing.Color.Black;
            this.txtDeliveryNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDeliveryNo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
            this.txtDeliveryNo.ForeColor = System.Drawing.Color.White;
            this.txtDeliveryNo.Location = new System.Drawing.Point(100, 40);
            this.txtDeliveryNo.MaxLength = 20;
            this.txtDeliveryNo.Name = "txtDeliveryNo";
            this.txtDeliveryNo.Size = new System.Drawing.Size(200, 25);
            this.txtDeliveryNo.TabIndex = 2;
            this.txtDeliveryNo.TabStop = false;
            this.txtDeliveryNo.Tag = "True";
            this.txtDeliveryNo.WordWrap = false;
            this.txtDeliveryNo.GotFocus += new System.EventHandler(this.txtDeliveryNo_GotFocus);
            this.txtDeliveryNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDeliveryNo_KeyPress);
            this.txtDeliveryNo.LostFocus += new System.EventHandler(this.txtDeliveryNo_LostFocus);
            // 
            // pbDeliveryNo
            // 
            this.pbDeliveryNo.BackColor = System.Drawing.Color.White;
            this.pbDeliveryNo.Location = new System.Drawing.Point(100, 58);
            this.pbDeliveryNo.Name = "pbDeliveryNo";
            this.pbDeliveryNo.Size = new System.Drawing.Size(200, 2);
            this.pbDeliveryNo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
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
            this.btnCancel.Text = "返回 [&F1]";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lbTID2
            // 
            this.lbTID2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
            this.lbTID2.ForeColor = System.Drawing.Color.Yellow;
            this.lbTID2.Location = new System.Drawing.Point(100, 0);
            this.lbTID2.Name = "lbTID2";
            this.lbTID2.Size = new System.Drawing.Size(200, 25);
            // 
            // UCHandOver3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.lbTID2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.pbDeliveryNo);
            this.Controls.Add(this.txtDeliveryNo);
            this.Controls.Add(this.lbDeliveryNo);
            this.Controls.Add(this.lbTID);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "UCHandOver3";
            this.Size = new System.Drawing.Size(300, 260);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
