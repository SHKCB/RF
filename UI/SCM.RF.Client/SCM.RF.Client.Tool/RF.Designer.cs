using System.ComponentModel;

namespace SCM.RF.Client.Tool
{
    partial class RF
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        //private System.Windows.Forms.PictureBox pbBackGround;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.Label lbWifi;
        private System.Windows.Forms.Label lbPower;
        private System.Windows.Forms.Label lbAction;
        //private SCM.RF.Client.Tool.Controls.Login.UCLogin ucLogin;
        //private SCM.RF.Client.Tool.Controls.Login.UCSetting ucSetting;
        //private SCM.RF.Client.Tool.Controls.Login.UCMenu ucMenu;
        //private SCM.RF.Client.Tool.Controls.Receiving.UCReceive1 ucReceive1;
        //private SCM.RF.Client.Tool.Controls.Receiving.UCReceive2 ucReceive2;
        //private SCM.RF.Client.Tool.Controls.InBound.UCInBound1 ucInBound1;
        //private SCM.RF.Client.Tool.Controls.InBound.UCInBound2 ucInBound2;
        //private SCM.RF.Client.Tool.Controls.InBound.UCInBound3 ucInBound3;
        //private SCM.RF.Client.Tool.Controls.InBound.UCInBound4 ucInBound4;
        //private SCM.RF.Client.Tool.Controls.InBound.UCInBound5 ucInBound5;
        //private SCM.RF.Client.Tool.Controls.InBound.UCProduct ucProduct;
        //private SCM.RF.Client.Tool.Controls.PutAway.UCPutaway1 ucPutaway1;
        //private SCM.RF.Client.Tool.Controls.PutAway.UCPutaway2 ucPutaway2;
        //private SCM.RF.Client.Tool.Controls.PutAway.UCPutaway3 ucPutaway3;
        //private SCM.RF.Client.Tool.Controls.Picking.UCPicking1 ucPicking1;
        //private SCM.RF.Client.Tool.Controls.Picking.UCPicking2 ucPicking2;
        //private SCM.RF.Client.Tool.Controls.Picking.UCPicking3 ucPicking3;
        //private SCM.RF.Client.Tool.Controls.Common.UCCellPal ucCellPal;
        //private SCM.RF.Client.Tool.Controls.Stocktaking.UCStocktaking ucStocktaking;
        //private SCM.RF.Client.Tool.Controls.Stocktaking.UCStocktakUser ucStocktakUser;
        //private SCM.RF.Client.Tool.Controls.Stocktaking.UCStocktakLog ucStocktakLog;
        //private SCM.RF.Client.Tool.Controls.Stocktaking.UCStocktakSystem1 ucStocktakSystem1;
        //private SCM.RF.Client.Tool.Controls.Stocktaking.UCStocktakSystem2 ucStocktakSystem2;
        //private SCM.RF.Client.Tool.Controls.Transfer.UCTransfer ucTransfer;
        //private SCM.RF.Client.Tool.Controls.Transfer.UCTransferUserDirected1 ucTransferUserDirected1;
        //private SCM.RF.Client.Tool.Controls.Transfer.UCTransferUserDirected2 ucTransferUserDirected2;
        //private SCM.RF.Client.Tool.Controls.Transfer.UCTransferLog ucTransferLog;
        //private SCM.RF.Client.Tool.Controls.Transfer.UCTransferSysDirected1 ucTransferSysDirected1;
        //private SCM.RF.Client.Tool.Controls.Transfer.UCTransferSysDirected2 ucTransferSysDirected2;
        //private SCM.RF.Client.Tool.Controls.Transfer.UCTransferLog2 ucTransferLog2;
        //private SCM.RF.Client.Tool.Controls.Transfer.UCTransferPutaway1 ucTransferPutaway1;
        //private SCM.RF.Client.Tool.Controls.Transfer.UCTransferPutaway2 ucTransferPutaway2;
        //private SCM.RF.Client.Tool.Controls.Transfer.UCTransferLog3 ucTransferLog3;
        //private SCM.RF.Client.Tool.Controls.XTransfer.UCXTransfer1 ucXTransfer1;
        //private SCM.RF.Client.Tool.Controls.XTransfer.UCXTransfer2 ucXTransfer2;

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

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RF));
            this.lbUserName = new System.Windows.Forms.Label();
            this.lbWifi = new System.Windows.Forms.Label();
            this.lbPower = new System.Windows.Forms.Label();
            this.lbAction = new System.Windows.Forms.Label();
            this.pbBackGround = new System.Windows.Forms.PictureBox();
            this.lbTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbUserName
            // 
            this.lbUserName.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
            this.lbUserName.ForeColor = System.Drawing.Color.White;
            this.lbUserName.Location = new System.Drawing.Point(116, 300);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(83, 16);
            this.lbUserName.Text = "-";
            this.lbUserName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbWifi
            // 
            this.lbWifi.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
            this.lbWifi.ForeColor = System.Drawing.Color.White;
            this.lbWifi.Location = new System.Drawing.Point(217, 302);
            this.lbWifi.Name = "lbWifi";
            this.lbWifi.Size = new System.Drawing.Size(24, 16);
            this.lbWifi.Text = "-";
            this.lbWifi.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbPower
            // 
            this.lbPower.BackColor = System.Drawing.Color.BurlyWood;
            this.lbPower.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
            this.lbPower.ForeColor = System.Drawing.Color.Black;
            this.lbPower.Location = new System.Drawing.Point(275, 302);
            this.lbPower.Name = "lbPower";
            this.lbPower.Size = new System.Drawing.Size(32, 12);
            this.lbPower.Text = "0%";
            this.lbPower.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbAction
            // 
            this.lbAction.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
            this.lbAction.ForeColor = System.Drawing.Color.White;
            this.lbAction.Location = new System.Drawing.Point(3, 5);
            this.lbAction.Name = "lbAction";
            this.lbAction.Size = new System.Drawing.Size(182, 16);
            this.lbAction.Text = "当前操作：-";
            // 
            // pbBackGround
            // 
            this.pbBackGround.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbBackGround.Image = ((System.Drawing.Image)(resources.GetObject("pbBackGround.Image")));
            this.pbBackGround.Location = new System.Drawing.Point(0, 0);
            this.pbBackGround.Name = "pbBackGround";
            this.pbBackGround.Size = new System.Drawing.Size(320, 320);
            // 
            // lbTime
            // 
            this.lbTime.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
            this.lbTime.ForeColor = System.Drawing.Color.White;
            this.lbTime.Location = new System.Drawing.Point(191, 5);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(126, 16);
            this.lbTime.Text = "2016/01/01 00:00:00";
            // 
            // RF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(320, 320);
            this.ControlBox = false;
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.lbAction);
            this.Controls.Add(this.lbUserName);
            this.Controls.Add(this.lbWifi);
            this.Controls.Add(this.lbPower);
            this.Controls.Add(this.pbBackGround);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RF";
            this.Load += new System.EventHandler(this.RF_Load);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.PictureBox pbBackGround;
        private System.Windows.Forms.Label lbTime;
    }
}