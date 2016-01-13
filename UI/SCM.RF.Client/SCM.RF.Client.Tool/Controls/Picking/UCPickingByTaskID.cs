using System;
using SCM.RF.Client.Tool;
using SCM.RF.Client.Tool.Controls.Common;
using System.Windows.Forms;
using SCM.RF.Client.Utility;
using System.Drawing;
using SCM.RF.Client.BizEntities.Pick;
using SCM.RF.Client.BizProcess.Pick;

namespace SCM.RF.Client.Tool.Controls.Picking
{
    public partial class UCPickingByTaskID : UCBasicControl
    {
        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="rf"></param>
        public UCPickingByTaskID(RF rf)
            : base(rf)
        {
            InitializeComponent();
        }

        #region 重载 override

        public override void Init()
        {
            base.SetTitle("按 [任务号] - 拣货");

            this.FocusTaskNo();
        }

        public override void Proc(EnMessageType type)
        {
            this.FocusTaskNo();
        }

        #endregion

        #region CLICK

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.btnCancel.Enabled = false;
            base.Cancel();
            this.btnCancel.Enabled = true;
        }

        private void txtTaskNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;

                string txtTaskNo = this.txtTaskNo.Text.Trim().ToUpper();

                if (txtTaskNo.Length > 0)
                {
                    if (StringHelper.ISStringInt32(txtTaskNo))
                    {
                        this.LoadData(txtTaskNo);
                    }
                    else
                    {
                        base.ShowMessage("集合单格式错误！", false, EnMessageType.A, false);
                    }
                }
            }
        }

        private void txtType_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        #endregion

        #region FOCUS

        private void FocusTaskNo()
        {
            this.txtTaskNo.Text = string.Empty;
            this.txtTaskNo.Focus();
        }

        private void FocusType()
        {
            this.txtType.Text = string.Empty;
            this.txtType.Focus();
        }

        private void txtTaskNo_GotFocus(object sender, System.EventArgs e)
        {
            this.pbTaskNo.BackColor = Color.Yellow;
            this.pbType.BackColor = Color.White;
        }

        private void txtTaskNo_LostFocus(object sender, System.EventArgs e)
        {
            this.pbTaskNo.BackColor = Color.White;
        }

        private void txtType_GotFocus(object sender, System.EventArgs e)
        {
            this.pbTaskNo.BackColor = Color.White;
            this.pbType.BackColor = Color.Yellow;
        }

        private void txtType_LostFocus(object sender, System.EventArgs e)
        {
            this.pbType.BackColor = Color.White;
        }

        #endregion

        #region PRIVATE FUNCTION

        private void Proc(int key)
        {
            switch (key)
            {
                case 1:
                    //base.RF.ShowInBound2(EnImpType.BAD);
                    break;
                case 2:
                    //base.RF.ShowInBound2(EnImpType.CHECK);
                    break;
                default: break;
            }
        }

        private void LoadData(string taskno)
        {
            PickViewEntity param = new PickViewEntity(base.UserView);
            param.TaskNo = taskno;

            ////加载数据
            PickViewEntity result = new PickBP().GetEntity(param, base.RemoteServer);

            if (result != null)
            {
                // 状态为 A - 准备移库
                if (result.Success)
                {
                    //base.RF.ShowPicking2(result);

                    this.txtType.ReadOnly = false;
                    this.FocusType();
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

            //LabelViewEntity param = new LabelViewEntity();
            //param.ContainerID = containerid;
            //param.SysNo = 0;
            //param.LabelNO = taskno;
            //param.InUser = base.UserViewEntity.UserName;


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
