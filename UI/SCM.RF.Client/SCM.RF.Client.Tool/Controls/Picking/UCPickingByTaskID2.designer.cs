namespace SCM.RF.Client.Tool.Controls.Picking
{
    partial class UCPickingByTaskID2
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
            this.lvList = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.lbPage = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnProv = new System.Windows.Forms.Button();
            this.btnContinue = new System.Windows.Forms.Button();
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
            // lvList
            // 
            this.lvList.BackColor = System.Drawing.Color.Black;
            this.lvList.Columns.Add(this.columnHeader1);
            this.lvList.Columns.Add(this.columnHeader2);
            this.lvList.Columns.Add(this.columnHeader3);
            this.lvList.Columns.Add(this.columnHeader4);
            this.lvList.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
            this.lvList.ForeColor = System.Drawing.Color.White;
            this.lvList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvList.Location = new System.Drawing.Point(0, 0);
            this.lvList.Name = "lvList";
            this.lvList.Size = new System.Drawing.Size(300, 200);
            this.lvList.TabIndex = 3;
            this.lvList.TabStop = false;
            this.lvList.Tag = "True";
            this.lvList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "No";
            this.columnHeader1.Width = 36;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "收货人";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "发货单号";
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "篮号";
            this.columnHeader4.Width = 90;
            // 
            // lbPage
            // 
            this.lbPage.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
            this.lbPage.ForeColor = System.Drawing.Color.White;
            this.lbPage.Location = new System.Drawing.Point(95, 208);
            this.lbPage.Name = "lbPage";
            this.lbPage.Size = new System.Drawing.Size(110, 20);
            this.lbPage.Text = "第0页/共0页";
            this.lbPage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbPage.Visible = false;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Black;
            this.btnNext.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(210, 204);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(80, 25);
            this.btnNext.TabIndex = 9;
            this.btnNext.TabStop = false;
            this.btnNext.Tag = "True";
            this.btnNext.Text = "下页 [&F3]";
            // 
            // btnProv
            // 
            this.btnProv.BackColor = System.Drawing.Color.Black;
            this.btnProv.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
            this.btnProv.ForeColor = System.Drawing.Color.White;
            this.btnProv.Location = new System.Drawing.Point(10, 204);
            this.btnProv.Name = "btnProv";
            this.btnProv.Size = new System.Drawing.Size(80, 25);
            this.btnProv.TabIndex = 7;
            this.btnProv.TabStop = false;
            this.btnProv.Tag = "True";
            this.btnProv.Text = "上页 [&F2]";
            // 
            // btnContinue
            // 
            this.btnContinue.BackColor = System.Drawing.Color.Black;
            this.btnContinue.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
            this.btnContinue.ForeColor = System.Drawing.Color.White;
            this.btnContinue.Location = new System.Drawing.Point(209, 235);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(80, 25);
            this.btnContinue.TabIndex = 6;
            this.btnContinue.TabStop = false;
            this.btnContinue.Tag = "True";
            this.btnContinue.Text = "继续 [&F5]";
            // 
            // UCPickingByTaskID2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.lbPage);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnProv);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.lvList);
            this.Controls.Add(this.btnCancel);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "UCPickingByTaskID2";
            this.Size = new System.Drawing.Size(300, 260);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ListView lvList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label lbPage;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnProv;
        private System.Windows.Forms.Button btnContinue;

    }
}
