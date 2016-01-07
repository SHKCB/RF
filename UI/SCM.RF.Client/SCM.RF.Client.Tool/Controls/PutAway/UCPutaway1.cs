using System;
using System.Drawing;
using System.Windows.Forms;
using SCM.RF.Client.BizProcess.Putaway;
using SCM.RF.Client.Tool.Controls.Common;
using Justyle.WMS.RF.Server.BizEntities.Putaway;

namespace SCM.RF.Client.Tool.Controls.PutAway
{
    public partial class UCPutaway1 : UCBasicControl
    {
        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="rf"></param>
        public UCPutaway1(RF rf)
            : base(rf)
        {
            InitializeComponent();
        }

        #region 重载 override

        public override void Init()
        {
            base.SetTitle("上架");

            this.FocusBoxNo();
        }

        public override void Proc(EnMessageType type)
        {
            if (type == EnMessageType.A)
            {
                FocusBoxNo();
            }
            else if (type == EnMessageType.B)
            {
                base.Exit();
            }
            else
            {

            }
        }

        #endregion

        #region PRIVARE FUNCTION

        private void FocusBoxNo()
        {
            this.txtBoxNo.Text = string.Empty;

            this.txtBoxNo.Focus();
        }

        /// <summary>
        /// 载入数据
        /// </summary>
        /// <param name="boxno"></param>
        private void LoadData()
        {
            string strBoxNo = this.txtBoxNo.Text.Trim().ToUpper();

            if (strBoxNo.Length == 0)
            {
                return;
            }

            if (SCM.RF.Client.Utility.StringHelper.ISStringInt32(strBoxNo))
            {
                #region 读取上架数据

                PutawayViewEntity param = new PutawayViewEntity();

                param.ContainerID = strBoxNo;

                param.InUser = base.UserViewEntity.UserName;

                PutawayViewEntity result = new PutawayBP().GetEntity(param, base.RemoteServer);

                if (result != null)
                {
                    if (result.Success)
                    {
                        //A-大货入库； B-返修入库； C-调拨入库； D-RMA入库； E-渠道退货； F-库内返架
                        if (result.Type == "A")
                        {
                            base.RF.ShowPutaway3(result, EnImpType.CHECK);
                        }
                        else if (result.Type == "D")
                        {
                            base.RF.ShowPutaway2(result);
                        }
                        else if (result.Type == "E")
                        {
                            base.RF.ShowPutaway2(result);
                        }
                        else
                        { }
                    }
                    else
                    {
                        base.ShowMessage(result.Message, false, EnMessageType.A, false);
                    }
                }
                else
                {
                    base.ShowMessage("错误，重新登录！", false, EnMessageType.B, false);
                }

                #endregion
            }
            else
            {
                base.ShowMessage("格式错误！", false, EnMessageType.A, false);
            }
        }

        #endregion

        #region CLICK

        /// <summary>
        /// 返回
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.btnCancel.Enabled = false;
            base.Cancel();
            this.btnCancel.Enabled = true;
        }

        private void txtBoxNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {
                e.Handled = true;

                LoadData();
            }
        }

        #endregion

        #region FOCUS

        private void txtBoxNo_GotFocus(object sender, EventArgs e)
        {
            this.pbBoxNo.BackColor = Color.Yellow;
        }

        private void txtBoxNo_LostFocus(object sender, EventArgs e)
        {
            this.pbBoxNo.BackColor = Color.White;
        }

        #endregion

        #region 供快捷键调用 本级页面

        /// <summary>
        /// 退出快捷键
        /// </summary>
        public void HookExit()
        {
            btnCancel_Click(null, null);
        }

        #endregion
    }
}
