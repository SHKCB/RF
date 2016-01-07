using System.Windows.Forms;

namespace SCM.RF.Client.Tool.Controls.Common
{
    /// <summary>
    /// 消息提示框
    /// </summary>
    public partial class UCMessageBox : UserControl
    {
        /// <summary>
        /// 消息类型
        /// </summary>
        private EnMessageType MessageType;

        public UCMessageBox()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 信息内容
        /// </summary>
        /// <param name="msg"></param>
        public void Init(string message, bool choise, EnMessageType type)
        {
            if (choise)
            {
                this.btnOK.Location = new System.Drawing.Point(35, 216);

                this.btnCancel.Visible = true;
            }
            else
            {
                this.btnOK.Location = new System.Drawing.Point(80, 216);

                this.btnCancel.Visible = false;
            }

            this.lbMsg.Text = message;

            this.MessageType = type;

            this.btnOK.Visible = true;

            this.btnOK.Focus();
        }

        /// <summary>
        /// 返回
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            this.btnCancel.Enabled = false;
            MessageEvent(false, this.MessageType);
            this.btnCancel.Enabled = true;
        }

        /// <summary>
        /// 确定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK_Click(object sender, System.EventArgs e)
        {
            this.btnOK.Enabled = false;
            MessageEvent(true, this.MessageType);
            this.btnOK.Enabled = true;
        }

        /// <summary>
        /// 事件
        /// </summary>
        /// <param name="param"></param>
        /// <param name="type"></param>
        public delegate void MessageEventHandler(bool param, EnMessageType type);

        /// <summary>
        /// 事件
        /// </summary>
        public event MessageEventHandler MessageEvent;
    }
}
