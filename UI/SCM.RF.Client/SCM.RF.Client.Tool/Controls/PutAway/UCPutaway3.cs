using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;
using SCM.RF.Client.BizEntities.Putaway;
using SCM.RF.Client.Tool.Controls.Common;
using SCM.RF.Client.Utility;
using Justyle.WMS.RF.Server.BizEntities.Putaway;

namespace SCM.RF.Client.Tool.Controls.PutAway
{
    public partial class UCPutaway3 : UCBasicControl
    {
        #region PRIVATE MEMBER
        /// <summary>
        ///  待上架 数据
        /// </summary>
        private PutawayViewEntity _PutawayEntity;

        /// <summary>
        /// 上架明细
        /// </summary>
        private PutawayItemViewEntity _PutawayItemEntity;

        /// <summary>
        /// 缓存
        /// </summary>
        private Hashtable _Hashtable;

        private EnImpType _EnImpType;

        #endregion

        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="rf"></param>
        public UCPutaway3(RF rf)
            : base(rf)
        {
            InitializeComponent();
        }

        #region 重载 override

        public override void Init()
        {
            base.SetTitle("拆零上架");

            Clear();
        }

        public override void Proc(EnMessageType type)
        {
            if (type == EnMessageType.A)
            {
                this.FocusProduct();
            }
            else if (type == EnMessageType.B)
            {
                base.Exit();
            }
            else if (type == EnMessageType.C)
            {
                base.RF.ShowPutaway1();
            }
            else if (type == EnMessageType.D)
            {
                this.FocusCellNo();
            }
            else if (type == EnMessageType.E)
            {
                this.FocusQty();
            }
            else
            {

            }
        }

        #endregion

        #region CLICK

        private void btnCancel_Click(object sender, EventArgs e)
        {
            base.ShowMessage("返回上级页面？", true, EnMessageType.C);
        }

        private void txtProduct_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;

                string strBarCode = this.txtBarCode.Text.Trim().ToUpper();

                if (strBarCode.Length > 0)
                {
                    if (SCM.RF.Client.Utility.StringHelper.ISStringInt32(strBarCode))
                    {
                        this.LoadData(strBarCode);
                    }
                    else
                    {
                        base.ShowMessage("条码格式错误！", false, EnMessageType.A, false);
                    }
                }
            }
        }

        private void txtCellNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;

                string strCellNo = this.txtCellNo.Text.Trim().ToUpper();

                if (strCellNo.Length > 0)
                {
                    if (SCM.RF.Client.Utility.StringHelper.ISStringInt32(strCellNo))
                    {
                        this.FocusQty();
                    }
                    else
                    {
                        base.ShowMessage("库位格式错误！", false, EnMessageType.D, false);
                    }
                }
            }
        }

        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;

                string strBarCode = this.txtBarCode.Text.Trim().ToUpper();

                string strCellNo = this.txtCellNo.Text.Trim().ToUpper();

                string strCount = this.txtQty.Text.Trim();

                string strNum = this.txtNum.Text.Trim();

                if (strBarCode.Length == 0)
                {
                    base.ShowMessage("请输入条码！", false, EnMessageType.A, false);

                    return;
                }

                if (strCellNo.Length == 0)
                {
                    base.ShowMessage("请输入库位！", false, EnMessageType.D, false);

                    return;
                }

                if (strCount.Length == 0)
                {
                    base.ShowMessage("请输入数量！", false, EnMessageType.E, false);

                    return;
                }

                if (StringHelper.ISStringInt32(strBarCode))
                {
                    if (SCM.RF.Client.Utility.StringHelper.ISStringInt32(strCellNo))
                    {
                        if (SCM.RF.Client.Utility.StringHelper.ISInt32(strCount))
                        {
                            int quantity = int.Parse(strNum);

                            int count = int.Parse(strCount);

                            if (count > quantity)
                            {
                                base.ShowMessage("不能大于总量！", false, EnMessageType.E, false);
                            }
                            else
                            {
                                this.AddData(strBarCode, strCellNo, strCount);
                            }
                        }
                        else
                        {
                            base.ShowMessage("数量格式错误！", false, EnMessageType.E, false);
                        }
                    }
                    else
                    {
                        base.ShowMessage("库位格式错误！", false, EnMessageType.D, false);
                    }
                }
                else
                {
                    base.ShowMessage("条码格式错误！", false, EnMessageType.A, false);
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.btnSearch.Enabled = false;

            base.RF.ShowCellPal(this, EnPalType.G);

            this.btnSearch.Enabled = true;
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            this.btnDetail.Enabled = false;
            base.RF.ShowPutawayLog(this._Hashtable, this);
            this.btnDetail.Enabled = true;
        }

        #endregion

        #region PUBLIC FUNCTION

        public void LoadData(PutawayViewEntity entity, EnImpType impType)
        {
            this._PutawayEntity = entity;

            this._EnImpType = impType;

            //A-大货入库； B-返修入库； C-调拨入库； D-RMA入库； E-渠道退货； F-库内返架
            if (entity.Type == "A")
            {
                this.lbBoxNo2.Text = entity.IMPNO;
            }
            else if (entity.Type == "D")
            {
                this.lbBoxNo2.Text = entity.ContainerID;
            }
            else if (entity.Type == "E")
            {
                this.lbBoxNo2.Text = entity.IMPNO;
            }
            else
            {
                this.lbBoxNo2.Text = "";
            }

            this._Hashtable = new Hashtable(entity.ItemList.Length);

            foreach (PutawayItemViewEntity item in entity.ItemList)
            {
                _Hashtable.Add(item.SysNo, item);
            }
        }

        /// <summary>
        /// 返回到当前页面
        /// </summary>
        public void CallBack()
        {
            base.RF.SetTitle("拆零上架");

            base.RF.HideCellPal();

            base.Init(base.HookType);

            this.Clear();
        }

        public void CallBack2()
        {
            base.RF.SetTitle("拆零上架");

            base.RF.HidePutawayLog();

            base.Init(base.HookType);

            this.Clear();
        }

        #endregion

        #region PRIVATE FUNCTION

        /// <summary>
        /// 完成任务自动退出
        /// </summary>
        private void Clear()
        {
            this.txtBarCode.Text = string.Empty;
            this.txtCellNo.Text = string.Empty;
            this.txtProductColor.Text = string.Empty;
            this.txtProductSize.Text = string.Empty;
            this.txtNum.Text = string.Empty;
            this.txtQty.Text = string.Empty;
            this.txtBarCode.Focus();

            if (this._Hashtable.Count == 0)
            {
                base.RF.ShowPutaway1();
            }
        }

        private void FocusProduct()
        {
            this.txtBarCode.Text = string.Empty;
            this.txtProductColor.Text = string.Empty;
            this.txtProductSize.Text = string.Empty;
            this.txtNum.Text = string.Empty;
            this.txtBarCode.Focus();
        }

        private void FocusQty()
        {
            this.txtQty.Text = string.Empty;

            this.txtQty.Focus();
        }

        private void FocusCellNo()
        {
            this.txtCellNo.Text = string.Empty;

            this.txtCellNo.Focus();
        }

        /// <summary>
        /// 添加数据
        /// </summary>
        /// <param name="barcod"></param>
        private void AddData(string code, string cellno, string count)
        {
            _PutawayItemEntity = null;

            IDictionaryEnumerator IDE = _Hashtable.GetEnumerator();

            PutawayItemViewEntity item = null;

            while (IDE.MoveNext())
            {
                item = IDE.Value as PutawayItemViewEntity;

                if (item != null)
                {
                    if (item.BarCode == code)
                    {
                        this._PutawayItemEntity = item;

                        break;
                    }
                }
            }

            if (this._PutawayItemEntity == null)
            {
                base.ShowMessage("该商品无上架信息或已经上架结束！", false, EnMessageType.A, false);

                this.Clear();

                return;
            }

            /*
 
            new SqlParameter("@SysNo",entity.SysNo),
            new SqlParameter("@InUser",entity.InUser),
            new SqlParameter("@QTY",entity.Qty),
            new SqlParameter("@LessQTY",entity.LessQTY)
             */

            PutawayItemViewEntity param = new PutawayItemViewEntity();

            param.SysNo = this._PutawayItemEntity.SysNo;

            param.POItemSysNo = this._PutawayItemEntity.POItemSysNo;

            param.POSysNo = this._PutawayItemEntity.POSysNo;

            param.InUser = base.UserViewEntity.UserName;

            param.Qty = int.Parse(count);//上架数量

            param.LessQTY = this._PutawayItemEntity.LessQTY;//剩余上架数量

            param.MasterSysNo = this._PutawayItemEntity.MasterSysNo;

            param.CellNO = cellno;

            param.ProductSysNo = this._PutawayItemEntity.ProductSysNo;

            param.BarCode = code;

            param.ContainerSysNo = this._PutawayItemEntity.ContainerSysNo;

            param.Type = this._PutawayItemEntity.Type;

            if (this._EnImpType == EnImpType.CHECK)
            {
                param.IMPType = "A";
            }
            else
            {
                param.IMPType = "B";
            }

            PutawayItemViewEntity result = new SCM.RF.Client.BizProcess.Putaway.PutawayBP().Insert(param, base.RemoteServer);

            if (result != null)
            {
                if (result.Success)
                {
                    //覆盖原值
                    PutawayItemViewEntity temp = this._Hashtable[param.SysNo] as PutawayItemViewEntity;

                    if (temp != null)
                    {
                        if (param.Qty >= param.LessQTY)
                        {
                            this._Hashtable.Remove(param.SysNo);
                        }
                        else
                        {
                            temp.LessQTY = result.LessQTY;

                            this._Hashtable[param.SysNo] = temp;
                        }
                    }

                    base.RF.PlaySound(true);
                }
                else
                {
                    //覆盖原值
                    PutawayItemViewEntity temp = this._Hashtable[param.SysNo] as PutawayItemViewEntity;

                    if (temp != null)
                    {
                        temp.LessQTY = result.LessQTY;

                        this._Hashtable[param.SysNo] = temp;
                    }

                    base.ShowMessage(result.Message, false, EnMessageType.A, false);
                }

                this.Clear();
            }
            else
            {
                base.ShowMessage("错误，重新登录！", false, EnMessageType.B, false);
            }
        }

        /// <summary>
        /// 加载上架数据
        /// </summary>
        /// <param name="code"></param>
        private void LoadData(string code)
        {
            _PutawayItemEntity = null;

            IDictionaryEnumerator IDE = _Hashtable.GetEnumerator();

            PutawayItemViewEntity item = null;

            while (IDE.MoveNext())
            {
                item = IDE.Value as PutawayItemViewEntity;

                if (item != null)
                {
                    if (item.BarCode == code)
                    {
                        this._PutawayItemEntity = item;

                        this.txtNum.Text = item.LessQTY.ToString();

                        this.txtProductSize.Text = item.ProductSize;

                        this.txtProductColor.Text = item.ProductColor;

                        break;
                    }
                }
            }

            if (this._PutawayItemEntity == null)
            {
                base.ShowMessage("该商品无上架信息！", false, EnMessageType.A, false);
            }
            else
            {
                this.FocusCellNo();
            }
        }

        #endregion

        #region FOCUS

        private void txtQty_GotFocus(object sender, EventArgs e)
        {
            this.pbQty.BackColor = Color.Yellow;
        }

        private void txtQty_LostFocus(object sender, EventArgs e)
        {
            this.pbQty.BackColor = Color.White;
        }

        private void txtProduct_GotFocus(object sender, EventArgs e)
        {
            this.pbProduct.BackColor = Color.Yellow;
        }

        private void txtProduct_LostFocus(object sender, EventArgs e)
        {
            this.pbProduct.BackColor = Color.White;
        }

        private void txtCellNo_GotFocus(object sender, EventArgs e)
        {
            this.pbCellNo.BackColor = Color.Yellow;
        }

        private void txtCellNo_LostFocus(object sender, EventArgs e)
        {
            this.pbCellNo.BackColor = Color.White;
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
