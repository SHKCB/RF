using System;
using SCM.RF.Client.Tool;
using SCM.RF.Client.Tool.Controls.Common;
using System.Windows.Forms;
using SCM.RF.Client.Utility;
using System.Drawing;
using SCM.RF.Client.BizEntities.Pick;
using SCM.RF.Client.BizProcess.Pick;
using System.Collections;

namespace SCM.RF.Client.Tool.Controls.Picking
{
    public partial class UCPickingByTaskID : UCBasicControl
    {
        /// <summary>
        /// 权限 列表
        /// </summary>
        private Hashtable _Hashtable;

        private PickViewEntity _PickViewEntity;

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

            this._PickViewEntity = null;

            this.FocusTaskNo();
        }

        public override void Proc(EnMessageType type)
        {
            if (type == EnMessageType.A)
            {
                base.RF.ShowPicking1();
                base.RF.HidePickingByTaskID();
            }
        }

        #endregion

        #region CLICK

        private void btnCancel_Click(object sender, EventArgs e)
        {
            base.ShowMessage("返回上级页面？", true, EnMessageType.A);
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

        private void txtType_TextChanged(object sender, EventArgs e)
        {
            string txt = this.txtType.Text.Trim();

            if (txt.Length > 0)
            {
                if (!SCM.RF.Client.Utility.StringHelper.ISInt(txt))
                {
                    base.ShowMessage("请输入正确指令！", false, EnMessageType.A, false);
                }
                else
                {
                    //判断是否有权限，并且按对键
                    int keyvalue = GetKey(txt);

                    if (keyvalue > -1)
                    {
                        GetModel(int.Parse(txt));
                    }
                    else
                    {
                        base.ShowMessage("请输入正确指令！", false, EnMessageType.A, false);
                    }
                }
            }
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
                    this._PickViewEntity = result;

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
        }

        /// <summary>
        /// 加载对应的功能
        /// </summary>
        /// <param name="key"></param>
        private void GetModel(int key)
        {
            switch (key)
            {
                case 1:
                    base.RF.ShowUCPickingByTaskID4(this._PickViewEntity);
                    break;
                //case 2: Location();
                //    break;
                default: break;
            }
        }

        /// <summary>
        /// 判断是否有效按键，否者返回。
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        private int GetKey(string txtValue)
        {
            switch (txtValue)
            {
                case "1":
                    if (_Hashtable.ContainsKey(1))
                    {
                        return 1;
                    }
                    else
                    {
                        return -1;
                    }

                case "2":
                    if (_Hashtable.ContainsKey(2))
                    {
                        return 2;
                    }
                    else
                    {
                        return -1;
                    }

                default: return -1;
            }
        }

        #endregion

        #region PUBLIC FUNCTION

        public void LoadData()
        {
            this._Hashtable = new Hashtable(0);

            this._Hashtable.Add(1, null);
            this._Hashtable.Add(2, null);
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
