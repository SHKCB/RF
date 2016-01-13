using System;
using SCM.RF.Client.Tool;
using SCM.RF.Client.Tool.Controls.Common;
using System.Windows.Forms;
using SCM.RF.Client.Utility;

namespace SCM.RF.Client.Tool.Controls.Picking
{
    public partial class UCPickingByTaskID3 : UCBasicControl
    {
        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="rf"></param>
        public UCPickingByTaskID3(RF rf)
            : base(rf)
        {
            InitializeComponent();
        }

        #region 重载 override

        public override void Init()
        {
            base.SetTitle("按 [任务号] - 拣货");

    
        }

        public override void Proc(EnMessageType type)
        {
           
        }

        #endregion

        #region CLICK

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.btnCancel.Enabled = false;
            base.Cancel();
            this.btnCancel.Enabled = true;
        }

        #endregion

        #region FOCUS

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
            //LabelViewEntity param = new LabelViewEntity();
            //param.ContainerID = containerid;
            //param.SysNo = 0;
            //param.LabelNO = taskno;
            //param.InUser = base.UserViewEntity.UserName;

            ////加载数据
            //LabelViewEntity result = new LabelBP().GetEntity(param, base.RemoteServer);

            //if (result != null)
            //{
            //    // 状态为 A - 准备移库
            //    if (result.Success)
            //    {
            //        base.RF.ShowPicking2(result);
            //    }
            //    else
            //    {
            //        base.ShowMessage(result.Message, false, EnMessageType.A, false);
            //    }
            //}
            //else
            //{
            //    base.ShowMessage("错误，重新登录！", false, EnMessageType.B, false);
            //}
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

        private void btnNext_Click(object sender, EventArgs e)
        {

        }

        private void btnProv_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

     }
}
