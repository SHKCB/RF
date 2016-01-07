using System;
using System.Drawing;
using SCM.RF.Client.BizEntities.BasicData.Product;
using SCM.RF.Client.BizEntities.Picking;
using SCM.RF.Client.BizProcess.BaseData.Product;
using SCM.RF.Client.BizProcess.Picking;
using SCM.RF.Client.Tool.Controls.Common;

namespace SCM.RF.Client.Tool.Controls.Picking
{
    public partial class UCPicking3 : UCBasicControl
    {
        #region PRIVATE MEMBER

        /// <summary>
        /// 父级页面
        /// </summary>
        private UCPicking2 _UCPicking2;

        /// <summary>
        /// 主信息
        /// </summary>
        private LabelViewEntity _LabelEntity;

        /// <summary>
        /// 明细
        /// </summary>
        private MulViewEntity _MulViewEntity;

        #endregion

        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="rf"></param>
        public UCPicking3(RF rf)
            : base(rf)
        {
            InitializeComponent();
        }

        #region 重载 override

        public override void Init()
        {
            base.SetTitle("病单");

            this.FocusCount();
        }

        public override void Proc(EnMessageType type)
        {
            if (type == EnMessageType.A)
            {
                this.FocusCount();
            }
            else if (type == EnMessageType.B)
            {
                base.Exit();
            }
            else if (type == EnMessageType.C)
            {
                this._UCPicking2.CallBack();
            }
            else if (type == EnMessageType.D)
            {
                this.Bad();
            }
            else if (type == EnMessageType.E)
            {
                this.Reset();
            }
            else
            {

            }
        }

        #endregion

        #region CLICK

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.btnCancel.Enabled = false;
            _UCPicking2.CallBack();
            this.btnCancel.Enabled = true;
        }

        /// <summary>
        /// 重定位
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            base.ShowMessage("重定位？", true, EnMessageType.E);
        }

        /// <summary>
        /// 转病单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBad_Click(object sender, EventArgs e)
        {
            string qty = this.txtCount.Text.Trim();

            if (qty.Length > 0)
            {
                if (SCM.RF.Client.Utility.StringHelper.ISInt32(qty))
                {
                    if (int.Parse(qty) > this._MulViewEntity.LessQTY || int.Parse(qty) <= 0)
                    {
                        base.ShowMessage("请输入正确数量！", false, EnMessageType.A, false);
                    }
                    else
                    {
                        base.ShowMessage("转病单？", true, EnMessageType.D);
                    }
                }
                else
                {
                    base.ShowMessage("数量格式错误！", false, EnMessageType.A, false);
                }
            }
            else
            {
                base.ShowMessage("请输入数量！", false, EnMessageType.A, false);
            }
        }

        /// <summary>
        /// 查询库存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.btnSearch.Enabled = false;

            base.RF.ShowCellPal(this, EnPalType.A);

            this.btnSearch.Enabled = true;
        }

        /// <summary>
        /// 察看商品名称
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDetail_Click(object sender, EventArgs e)
        {
            string strBarCode = this.lbProduct2.Text.Trim().ToUpper();

            if (strBarCode.Length > 0)
            {
                ProductViewEntity productEntity = new ProductBP().GetEntity(new ProductViewEntity() { BarCode = strBarCode }, base.RemoteServer);

                if (productEntity != null)
                {
                    if (productEntity.Success)
                    {
                        base.ShowMessage(productEntity.Name, false, EnMessageType.A, true);
                    }
                    else
                    {
                        base.ShowMessage(productEntity.Message, false, EnMessageType.A, false);
                    }
                }
                else
                {
                    base.ShowMessage("错误，重新登录！", false, EnMessageType.B, false);
                }
            }
            else
            {
                FocusCount();
            }
        }

        #endregion

        #region FOCUS

        private void txtCount_GotFocus(object sender, EventArgs e)
        {
            this.pbCount.BackColor = Color.Yellow;
        }

        private void txtCount_LostFocus(object sender, EventArgs e)
        {
            this.pbCount.BackColor = Color.White;
        }

        #endregion

        #region PUBLIC FUNCTION

        public void LoadData(LabelViewEntity label, MulViewEntity mul, UCPicking2 uc)
        {
            this._LabelEntity = label;

            this._MulViewEntity = mul;

            this._UCPicking2 = uc;

            this.LoadData(mul);
        }

        /// <summary>
        /// 返回到当前页面
        /// </summary>
        public void CallBack()
        {
            base.RF.HideCellPal();

            base.Init(base.HookType);

            this.Init();
        }

        #endregion

        #region PRIVATE FUNCTION

        /// <summary>
        /// 加载数据
        /// </summary>
        /// <param name="ots"></param>
        private void LoadData(MulViewEntity mul)
        {
            if (mul == null)
            {
                base.ShowMessage("无拣货信息！", false, EnMessageType.A, false);

                return;
            }

            this.lbProduct2.Text = mul.BarCode;

            this.lbCellNo2.Text = mul.CellNO;

            this.lbQty2.Text = mul.LessQTY.ToString();

            this.lbProductColor2.Text = mul.ProductColor;

            this.lbProductName2.Text = mul.ProductName;

            this.lbProductSize2.Text = mul.ProductSize;

            this.txtCount.Text = this.lbQty2.Text;
        }

        private void FocusCount()
        {
            this.txtCount.SelectAll();
            this.txtCount.Focus();
        }

        /// <summary>
        /// 转病单
        /// </summary>
        /// <param name="qty"></param>
        private void Bad()
        {
            string strQty = this.txtCount.Text.Trim();
            BadViewEntity param = new BadViewEntity();
            param.MasterSysNo = this._MulViewEntity.MasterSysNo;
            param.SysNo = this._MulViewEntity.SysNo;
            param.BadQty = int.Parse(strQty);
            param.BarCode = this._MulViewEntity.BarCode;
            param.CellNO = this._MulViewEntity.CellNO;
            param.CellSysNo = this._MulViewEntity.CellSysNo;
            param.ContainerID = this._LabelEntity.ContainerID;
            param.ContainerSysNo = this._LabelEntity.ContainerSysNo;
            param.Index = this._MulViewEntity.Index;
            param.InUser = base.UserViewEntity.UserName;
            param.LabelNO = this._MulViewEntity.LabelNO;
            param.LessQTY = this._MulViewEntity.LessQTY;
            param.OrderID = this._MulViewEntity.OrderID;
            param.OrderSysNo = this._MulViewEntity.OrderSysNo;
            param.ProductSysNo = this._MulViewEntity.ProductSysNo;

            BadViewEntity result = new LabelBP().Insert(param, base.RemoteServer);

            if (result != null)
            {
                if (result.Success)
                {
                    base.RF.PlaySound(true);

                    this.Visible = false;

                    this._MulViewEntity.LessQTY -= param.BadQty;

                    this._UCPicking2.ToBad(this._MulViewEntity);
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
        /// 重定位
        /// </summary>
        private void Reset()
        {
            //BadViewEntity param = new BadViewEntity();
            //param.BadQty = int.Parse(qty);
            //param.BarCode = this._OTSEntity.BarCode;
            //param.CellNO = this._OTSEntity.CellNO;
            //param.CellSysNo = this._OTSEntity.CellSysNo;
            //param.ContainerID = this._LabelEntity.ContainerID;
            //param.ContainerSysNo = this._LabelEntity.ContainerSysNo;
            //param.Index = this._OTSEntity.Index;
            //param.InUser = base.UserViewEntity.UserName;
            //param.LabelNO = this._OTSEntity.LabelNO;
            //param.LessQTY = this._OTSEntity.LessQTY;
            //param.OrderID = this._OTSEntity.OrderID;
            //param.OrderSysNo = this._OTSEntity.OrderSysNo;
            //param.ProductSysNo = this._OTSEntity.ProductSysNo;

            this._MulViewEntity.InUser = base.UserViewEntity.UserName;

            MulViewEntity result = new LabelBP().Reset(this._MulViewEntity, base.RemoteServer);

            if (result != null)
            {
                if (result.Success)
                {
                    base.RF.PlaySound(true);

                    this.Visible = false;

                    this._UCPicking2.Reset(this._MulViewEntity, result);
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

        #endregion

        #region 供快捷键调用 本级页面

        /// <summary>
        /// 退出快捷键
        /// </summary>
        public void HookExit()
        {
            btnCancel_Click(null, null);
        }

        /// <summary>
        /// 重定位
        /// </summary>
        public void HookReset()
        {
            btnReset_Click(null, null);
        }

        /// <summary>
        /// 病单
        /// </summary>
        public void HookBad()
        {
            btnBad_Click(null, null);
        }

        /// <summary>
        /// 查询库存
        /// </summary>
        public void HookSearch()
        {
            btnSearch_Click(null, null);
        }

        /// <summary>
        /// 察看商品名称
        /// </summary>
        public void HookDetail()
        {
            btnDetail_Click(null, null);
        }

        #endregion
    }
}
