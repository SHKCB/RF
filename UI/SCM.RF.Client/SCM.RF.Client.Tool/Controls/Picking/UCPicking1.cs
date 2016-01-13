using System;
using SCM.RF.Client.Tool;
using SCM.RF.Client.Tool.Controls.Common;
using System.Drawing;
using System.Collections;

namespace SCM.RF.Client.Tool.Controls.Picking
{
    public partial class UCPicking1 : UCBasicControl
    {
        /// <summary>
        /// 权限 列表
        /// </summary>
        private Hashtable _Hashtable;

        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="rf"></param>
        public UCPicking1(RF rf)
            : base(rf)
        {
            InitializeComponent();
        }

        #region 重载 override

        public override void Init()
        {
            base.SetTitle("拣货类型选择");

            this.FocusMenu();
        }

        public override void Proc(EnMessageType type)
        {
            this.FocusMenu();
        }

        #endregion

        #region CLICK

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.btnCancel.Enabled = false;
            base.Cancel();
            this.btnCancel.Enabled = true;
        }

        private void txtMenu_TextChanged(object sender, EventArgs e)
        {
            string txt = this.txtMenu.Text.Trim();

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

        private void FocusMenu()
        {
            this.txtMenu.Text = string.Empty;
            this.txtMenu.Focus();
        }

        private void txtMenu_GotFocus(object sender, EventArgs e)
        {
            this.pbMenu.BackColor = Color.Yellow;
        }

        private void txtMenu_LostFocus(object sender, EventArgs e)
        {
            this.pbMenu.BackColor = Color.White;
        }

        #endregion

        #region PRIVATE FUNCTION

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

                case "3":
                    if (_Hashtable.ContainsKey(3))
                    {
                        return 3;
                    }
                    else
                    {
                        return -1;
                    }

                default: return -1;
            }
        }

        private void GetModel(int key)
        {
            switch (key)
            {
                case 1: ByTask();
                    break;
                case 2: ByOrderID();
                    break;
                case 3: ByDeliveryNo();
                    break;
                default: break;
            }
        }

        #region 1、按 [任务号] - 拣货

        private void ByTask()
        {
            base.RF.HideMenu();
            base.RF.ShowPickingByTaskID();
        }

        #endregion

        #region 2、按 [订单号] - 拣货

        private void ByOrderID()
        {
            //base.RF.ShowTransfer();
        }

        #endregion

        #region 3、按 [运单号] - 拣货
        private void ByDeliveryNo()
        {
            //base.RF.ShowPicking1();
        }
        #endregion

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

        #endregion

        #region PUBLIC FUNCTION

        public void LoadData()
        {
            this._Hashtable = new Hashtable(0);

            this._Hashtable.Add(1, null);
            this._Hashtable.Add(2, null);
            this._Hashtable.Add(3, null);
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
