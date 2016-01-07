using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;
using SCM.RF.Client.Tool.Controls.Common;

namespace SCM.RF.Client.Tool.Controls.Login
{
    public partial class UCMenu : UCBasicControl
    {
        #region PRIVARE MEMBER

        /// <summary>
        /// 权限 列表
        /// </summary>
        private Hashtable _Hashtable;

        /// <summary>
        /// 权限显示名称
        /// </summary>
        private string LineTxt = "{0}、{1}";

        /// <summary>
        /// 横坐标
        /// </summary>
        private int X = 0;

        /// <summary>
        /// 纵坐标
        /// </summary>
        private int Y = 0;

        #endregion

        public UCMenu(RF rf)
            : base(rf)
        {
            InitializeComponent();
        }

        #region PUBLIC FUNCTION

        /// <summary>
        /// 加载权限
        /// </summary>
        public void LoadData()
        {
            this.panelMenu.Controls.Clear();

            if (base.UserViewEntity.ItemList == null)
            {
                this._Hashtable = new Hashtable(0);
            }
            else
            {
                #region 加载 权限

                int count = base.UserViewEntity.ItemList.Length;

                this._Hashtable = new Hashtable(count);

                System.Windows.Forms.Label lable = null;

                int index = 1;

                for (int i = 0; i < count; i++)
                {
                    if (this._Hashtable.ContainsKey(base.UserViewEntity.ItemList[i].Description))
                    {
                        continue;
                    }

                    lable = new Label();

                    if (i > 0)
                    {
                        Y = Y + 25;
                    }

                    lable.BackColor = System.Drawing.Color.Black;
                    lable.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
                    lable.ForeColor = System.Drawing.Color.White;
                    lable.Location = new System.Drawing.Point(X, Y);
                    lable.Name = "lb" + base.UserViewEntity.ItemList[i].Description;
                    lable.Size = new System.Drawing.Size(300, 25);
                    lable.Text = string.Format(LineTxt, base.UserViewEntity.ItemList[i].Description, base.UserViewEntity.ItemList[i].Category);
                    lable.Tag = base.UserViewEntity.ItemList[i].Description;
                    lable.BringToFront();
                    this.panelMenu.Controls.Add(lable);
                    index++;
                    this._Hashtable.Add(base.UserViewEntity.ItemList[i].Description, null);
                }

                #endregion
            }
        }

        #endregion

        #region CLICK

        /// <summary>
        /// 退出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.btnExit.Enabled = false;
            Exit();
            this.btnExit.Enabled = true;
        }

        /// <summary>
        /// 输入值 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                        IEnumerator iEnum = this.panelMenu.Controls.GetEnumerator();

                        while (iEnum.MoveNext())
                        {
                            if (iEnum.Current is Label)
                            {
                                Label lable = iEnum.Current as Label;

                                if (lable != null && lable.Tag != null && int.Parse(lable.Tag.ToString()) == keyvalue)
                                {
                                    GetModel(int.Parse(lable.Tag.ToString()));
                                }
                            }
                        }
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
        private void txtMenu_GotFocus(object sender, EventArgs e)
        {
            this.pbMenu.BackColor = Color.Yellow;
        }

        private void txtMenu_LostFocus(object sender, EventArgs e)
        {
            this.pbMenu.BackColor = Color.White;
        }

        #endregion

        #region PRIVARE FUNCTION

        private void FocusMenu()
        {
            this.txtMenu.Text = string.Empty;
            this.txtMenu.Focus();
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
                    if (_Hashtable.ContainsKey("1"))
                    {
                        return 1;
                    }
                    else
                    {
                        return -1;
                    }

                case "2":
                    if (_Hashtable.ContainsKey("2"))
                    {
                        return 2;
                    }
                    else
                    {
                        return -1;
                    }

                case "3":
                    if (_Hashtable.ContainsKey("3"))
                    {
                        return 3;
                    }
                    else
                    {
                        return -1;
                    }

                case "4":
                    if (_Hashtable.ContainsKey("4"))
                    {
                        return 4;
                    }
                    else
                    {
                        return -1;
                    }

                case "5":
                    if (_Hashtable.ContainsKey("5"))
                    {
                        return 5;
                    }
                    else
                    {
                        return -1;
                    }

                case "6":
                    if (_Hashtable.ContainsKey("6"))
                    {
                        return 6;
                    }
                    else
                    {
                        return -1;
                    }

                case "7":
                    if (_Hashtable.ContainsKey("7"))
                    {
                        return 7;
                    }
                    else
                    {
                        return -1;
                    }

                case "8":
                    if (_Hashtable.ContainsKey("8"))
                    {
                        return 8;
                    }
                    else
                    {
                        return -1;
                    }

                case "9":
                    if (_Hashtable.ContainsKey("9"))
                    {
                        return 9;
                    }
                    else
                    {
                        return -1;
                    }
                case "0":
                    if (_Hashtable.ContainsKey("0"))
                    {
                        return 0;
                    }
                    else
                    {
                        return -1;
                    }

                default: return -1;
            }
        }

        #region 功能选择模块

        /// <summary>
        /// 加载对应的功能
        /// </summary>
        /// <param name="key"></param>
        private void GetModel(int key)
        {
            switch (key)
            {

                case 3: PutAway();
                    break;
                case 4: Transfer();
                    break;
  
                case 6: Picking();
                    break;

                case 8: Pal();
                    break;
                case 9: PalByCell();
                    break;
                case 0: HandOver();
                    break;
                default: break;
            }
        }

        
        
        #region 3上架

        private void PutAway()
        {
            base.RF.ShowPutaway1();
        }

        #endregion
        #region 4移库

        private void Transfer()
        {
            //base.RF.ShowTransfer();
        }

        #endregion
        
        #region 6拣货
        private void Picking()
        {
            base.RF.ShowPicking1();
        }
        #endregion
        
        #region 8库存查询

        private void Pal()
        {
            base.RF.ShowCellPal(null, EnPalType.D);
        }

        #endregion
        #region 9库存查询2
        private void PalByCell()
        {
            base.RF.ShowCellPalByCell(null, EnPalType.D);
        }

        #endregion
        #region 0交接
        private void HandOver()
        {
            base.RF.ShowHandOver1();
        }

        #endregion
        #endregion

        #endregion

        #region 重载 override

        public override void Init()
        {
            X = 0;
            Y = 0;
            FocusMenu();
            base.SetTitle("选择菜单");
        }

        public override void Proc(EnMessageType type)
        {
            FocusMenu();
        }

        /// <summary>
        /// 只是隐藏，并且清除权限
        /// </summary>
        public override void Exit()
        {
            this.btnExit.Enabled = false;

            base.UserViewEntity.ItemList = null;

            base.UserViewEntity = new SCM.RF.Client.BizProcess.Login.LoginBP().LoginOut(base.UserViewEntity, base.RemoteServer);

            this.panelMenu.Controls.Clear();

            this.btnExit.Enabled = true;

            base.Exit();
        }

        #endregion

        #region 供快捷键调用

        /// <summary>
        /// 退出快捷键
        /// </summary>
        public void HookExit()
        {
            btnExit_Click(null, null);
        }

        #endregion
    }
}
