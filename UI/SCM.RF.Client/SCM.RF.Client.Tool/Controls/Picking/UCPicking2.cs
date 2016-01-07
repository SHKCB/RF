using System;
using System.Collections;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using SCM.RF.Client.BizEntities.BasicData.Product;
using SCM.RF.Client.BizEntities.Picking;
using SCM.RF.Client.BizProcess.BaseData.Product;
using SCM.RF.Client.BizProcess.Picking;
using SCM.RF.Client.Tool.Controls.Common;
using SCM.RF.Client.Utility;

namespace SCM.RF.Client.Tool.Controls.Picking
{
    public partial class UCPicking2 : UCBasicControl
    {
        #region PRIVATE MEMBER

        /// <summary>
        /// 待拣货记录
        /// </summary>
        private Hashtable _Hashtable;

        /// <summary>
        /// 主信息
        /// </summary>
        private LabelViewEntity _LabelEntity;

        /// <summary>
        /// 明细
        /// </summary>
        private MulViewEntity _MulViewEntity;

        /// <summary>
        /// 
        /// </summary>
        private DataTable _DataTable;

        /// <summary>
        /// 每页显示数量
        /// </summary>
        private int pagesize = 1;

        /// <summary>
        /// 总页数
        /// </summary>
        private int pagecount = 1;

        /// <summary>
        /// 当前页码
        /// </summary>
        private int pageindex = 1;

        /// <summary>
        /// 分页数据
        /// </summary>
        private DataTablePage _DataTablePage;

        #endregion

        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="rf"></param>
        public UCPicking2(RF rf)
            : base(rf)
        {
            InitializeComponent();

            this._DataTablePage = new DataTablePage();

            this._DataTable = new DataTable();

            this._DataTable.Columns.Add(new DataColumn("NO", typeof(System.String)));

            this._DataTable.Columns.Add(new DataColumn("SysNo", typeof(System.String)));
        }

        #region 重载 override

        public override void Init()
        {
            base.SetTitle("拣货");

            this.Clear();
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
                this.FocusCount();
            }
            else if (type == EnMessageType.D)
            {
                base.RF.ShowPicking1();
            }
            else if (type == EnMessageType.E)
            {
                this.Save();
            }
            else if (type == EnMessageType.F)
            {
                this.Clear();
            }
            else
            {

            }
        }

        #endregion

        #region CLICK

        private void btnDetail_Click(object sender, EventArgs e)
        {
            string strBarCode = this.lbProduct2.Text.Trim().ToUpper();

            if (strBarCode.Length > 0)
            {
                //ProductViewEntity productEntity = SCM.RF.Client.BizProcess.Sys.InstanceBP.ProductCacheInstance[strBarCode] as ProductViewEntity;

                //if (productEntity == null)
                //{
                //    base.ShowMessage("不存在此条码！", false, EnMessageType.A);

                //    return;
                //}

                //base.ShowMessage(productEntity.Name, false, EnMessageType.A);

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
                FocusProduct();
            }
        }

        private void btnProv_Click(object sender, EventArgs e)
        {
            this.btnProv.Enabled = false;

            if (pageindex > 1)
            {
                pageindex--;
            }

            ShowGrid(pageindex);

            this.btnProv.Enabled = true;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.btnNext.Enabled = false;

            if (pageindex < pagecount)
            {
                pageindex++;
            }

            ShowGrid(pageindex);

            this.btnNext.Enabled = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            base.ShowMessage("返回上级页面？", true, EnMessageType.D);
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            base.ShowMessage("完结当前拣货任务？", true, EnMessageType.E);
        }

        private void btnBad_Click(object sender, EventArgs e)
        {
            base.RF.ShowPicking3(this._LabelEntity, this._MulViewEntity, this);
        }

        private void txtProduct_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;

                string strCode = this.txtProduct.Text.Trim().ToUpper();

                if (strCode.Length > 0)
                {
                    if (SCM.RF.Client.Utility.StringHelper.ISStringInt32(strCode))
                    {
                        if (strCode == this.lbProduct2.Text.Trim().ToUpper())
                        {
                            if (this._MulViewEntity != null && this._MulViewEntity.LessQTY == 1)
                            {
                                AddData(strCode, 1);
                            }
                            else
                            {
                                FocusCount();
                            }
                        }
                        else
                        {
                            base.ShowMessage("请输入正确条码！", false, EnMessageType.A, false);
                        }
                    }
                    else
                    {
                        base.ShowMessage("条码格式错误！", false, EnMessageType.A, false);
                    }
                }
            }
        }

        private void txtCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;

                string strCode = this.txtProduct.Text.Trim().ToUpper();

                string strCount = this.txtCount.Text.Trim();

                if (strCode.Length == 0)
                {
                    base.ShowMessage("请输入条码！", false, EnMessageType.A, false);

                    return;
                }

                if (strCount.Length == 0)
                {
                    base.ShowMessage("请输入数量！", false, EnMessageType.C, false);

                    return;
                }

                if (SCM.RF.Client.Utility.StringHelper.ISStringInt32(strCode))
                {
                    if (strCode == this.lbProduct2.Text.Trim().ToUpper())
                    {
                        if (SCM.RF.Client.Utility.StringHelper.ISInt32(strCount))
                        {
                            int quantity = int.Parse(this.lbQty2.Text.Trim());

                            int count = int.Parse(this.txtCount.Text.Trim());

                            if (count > quantity)
                            {
                                base.ShowMessage("不能大于拣货数量！", false, EnMessageType.C, false);
                            }
                            else
                            {
                                AddData(strCode, count);
                            }
                        }
                        else
                        {
                            base.ShowMessage("数量格式错误！", false, EnMessageType.C, false);
                        }
                    }
                    else
                    {
                        base.ShowMessage("请输入正确条码！", false, EnMessageType.A, false);
                    }
                }
                else
                {
                    base.ShowMessage("条码格式错误！", false, EnMessageType.A, false);
                }
            }
        }

        #endregion

        #region FOCUS

        private void txtProduct_GotFocus(object sender, EventArgs e)
        {
            this.pbProduct.BackColor = Color.Yellow;
        }

        private void txtProduct_LostFocus(object sender, EventArgs e)
        {
            this.pbProduct.BackColor = Color.White;
        }

        private void txtCount_GotFocus(object sender, EventArgs e)
        {
            this.pbCount.BackColor = Color.Yellow;
        }

        private void txtCount_LostFocus(object sender, EventArgs e)
        {
            this.pbCount.BackColor = Color.White;
        }

        #endregion

        #region PRIVATE FUNCTION

        private void FocusProduct()
        {
            this.txtProduct.SelectAll();
            this.txtProduct.Focus();
        }

        private void FocusCount()
        {
            this.txtCount.Text = string.Empty;
            this.txtCount.Focus();
        }

        /// <summary>
        /// 清除 数据
        /// </summary>
        private void Clear()
        {
            pageindex = 1;

            this.txtCount.Text = string.Empty;
            this.lbCellNo2.Text = string.Empty;
            this.lbQty2.Text = string.Empty;
            this.lbProduct2.Text = string.Empty;
            this.lbProductName2.Text = string.Empty;
            this.lbProductColor2.Text = string.Empty;
            this.lbProductSize2.Text = string.Empty;
            this.txtProduct.Text = string.Empty;

            if (this._Hashtable.Count == 0)
            {
                base.ShowMessage("拣货完成！", false, EnMessageType.D, true);
            }
            else
            {
                ShowGrid();
            }
        }

        /// <summary>
        /// 拣货
        /// </summary>
        /// <param name="barcode"></param>
        /// <param name="count"></param>
        private void AddData(string barcode, int count)
        {
            if (this._MulViewEntity == null)
            {
                base.ShowMessage("无拣货信息！", false, EnMessageType.A, false);

                return;
            }

            MulViewEntity param = new MulViewEntity();

            param = this._MulViewEntity;
            param.LabelNO = this._LabelEntity.LabelNO;
            param.BarCode = barcode;
            param.QTY = count;
            param.InUser = base.UserViewEntity.UserName;
            param.LessQTY = this._MulViewEntity.LessQTY - count;
            param.Status = param.LessQTY > 0 ? "B" : "C";//A - 待拣货(默认)；B - 捡货中; C - 正常拣货完成；D - 无效；
            param.ContainerID = this._LabelEntity.ContainerID;
            param.ContainerSysNo = this._LabelEntity.ContainerSysNo;
            param.TaskNO = this._LabelEntity.TaskNO;
            param.TaskSysNo = this._LabelEntity.TaskSysNo;

            MulViewEntity result = new LabelBP().Update(param, base.RemoteServer);

            if (result != null)
            {
                if (result.Success)
                {
                    if (param.LessQTY > 0)
                    {
                        MulViewEntity mul = this._Hashtable[this._MulViewEntity.SysNo] as MulViewEntity;

                        if (mul != null)
                        {
                            mul.LessQTY = param.LessQTY;

                            this._Hashtable[this._MulViewEntity.SysNo] = mul;
                        }
                    }
                    else
                    {
                        foreach (DataRow dr in this._DataTable.Rows)
                        {
                            int sysno = int.Parse(dr[1].ToString());

                            if (sysno == this._MulViewEntity.SysNo)
                            {
                                this._DataTable.Rows.Remove(dr);

                                break;
                            }
                        }

                        //删除待拣货
                        this._Hashtable.Remove(this._MulViewEntity.SysNo);
                    }

                    base.ShowMessage(result.Message, false, EnMessageType.F, true);
                }
                else
                {
                    base.ShowMessage(result.Message, false, EnMessageType.G, false);
                }
            }
            else
            {
                base.ShowMessage("错误，重新登录！", false, EnMessageType.B, false);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void ShowGrid()
        {
            pagecount = (int)Math.Ceiling((double)this._DataTable.Rows.Count / pagesize);

            ShowGrid(pageindex);
        }

        /// <summary>
        /// 显示分页
        /// </summary>
        /// <param name="pageindex"></param>
        private void ShowGrid(int pageindex)
        {
            DataTable dt = _DataTablePage.GetPagedTable(this._DataTable, pageindex, pagesize);

            int count = dt.Rows.Count;

            for (int i = 0; i < count; i++)
            {
                string sysno = dt.Rows[i][1].ToString();

                MulViewEntity item = this._Hashtable[int.Parse(sysno)] as MulViewEntity;

                if (item != null)
                {
                    LoadData(item);

                    break;
                }
            }

            if (count > 0)
            {
                this.lbPage.Text = string.Format("第{0}页/共{1}页", pageindex, pagecount);

                this.lbPage.Visible = true;
            }
            else
            {
                this.lbPage.Visible = false;
            }

            ShowNextGrid(pageindex);

            this.FocusProduct();
        }

        /// <summary>
        /// 显示下一条拣货数据
        /// </summary>
        /// <param name="pageindex"></param>
        private void ShowNextGrid(int pageindex)
        {
            if (pageindex < pagecount)
            {
                int nexindex = pageindex + 1;

                DataTable dt = _DataTablePage.GetPagedTable(this._DataTable, nexindex, pagesize);

                int count = dt.Rows.Count;

                for (int i = 0; i < count; i++)
                {
                    string sysno = dt.Rows[i][1].ToString();

                    MulViewEntity item = this._Hashtable[int.Parse(sysno)] as MulViewEntity;

                    if (item != null)
                    {
                        this.lbNext.Text = item.CellNO;

                        this.lbProduct4.Text = item.BarCode;

                        this.lbQty3.Text = item.LessQTY.ToString();

                        break;
                    }
                }
            }
            else
            {
                this.lbNext.Text = string.Empty;

                this.lbProduct4.Text = string.Empty;

                this.lbQty3.Text = string.Empty;
            }
        }

        /// <summary>
        /// 加载数据
        /// </summary>
        /// <param name="ots"></param>
        private void LoadData(MulViewEntity mul)
        {
            this._MulViewEntity = null;

            if (mul == null)
            {
                base.ShowMessage("无拣货信息！", false, EnMessageType.G, false);

                return;
            }

            this.lbProduct2.Text = mul.BarCode;

            this.lbCellNo2.Text = mul.CellNO;

            this.lbQty2.Text = mul.LessQTY.ToString();

            if (mul.LessQTY == 1)
            {
                this.txtCount.Text = "1";
            }
            else
            {
                this.txtCount.Text = string.Empty;
            }

            this.lbProductColor2.Text = mul.ProductColor;

            this.lbProductName2.Text = mul.ProductName;

            this.lbProductSize2.Text = mul.ProductSize;

            this._MulViewEntity = mul;
        }

        /// <summary>
        /// 强制完结
        /// </summary>
        private void Save()
        {
            LabelViewEntity param = new LabelViewEntity();

            param = this._LabelEntity;

            param.InUser = base.UserViewEntity.UserName;

            param.Status = "C";

            LabelViewEntity result = new LabelBP().Update(param, base.RemoteServer);

            if (result != null)
            {
                if (result.Success)
                {
                    Proc(EnMessageType.D);
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

        #region PUBLIC FUNCTION

        public void LoadData(LabelViewEntity entity)
        {
            this._DataTable.Clear();

            this._LabelEntity = entity;

            if (entity.ItemList != null)
            {
                int count = entity.ItemList.Length;

                this._Hashtable = new Hashtable(count);

                for (int i = 0; i < count; i++)
                {
                    this._Hashtable.Add(entity.ItemList[i].SysNo, entity.ItemList[i]);

                    DataRow dr = this._DataTable.NewRow();

                    dr[0] = i + 1;

                    dr[1] = entity.ItemList[i].SysNo;

                    this._DataTable.Rows.Add(dr);
                }
            }
            else
            {
                this._Hashtable = new Hashtable(0);
            }

            this.Clear();
        }

        /// <summary>
        /// 返回到当前页面
        /// </summary>
        public void CallBack()
        {
            base.RF.HidePicking3();

            base.Init(base.HookType);

            this.Init();
        }

        /// <summary>
        /// 转病单
        /// </summary>
        public void ToBad(MulViewEntity mul)
        {
            foreach (DataRow dr in this._DataTable.Rows)
            {
                int sysno = int.Parse(dr[1].ToString());

                if (sysno == mul.SysNo)
                {
                    if (mul.LessQTY <= 0)
                    {
                        this._DataTable.Rows.Remove(dr);
                    }

                    break;
                }
            }

            if (mul.LessQTY <= 0)
            {
                //删除待拣货
                this._Hashtable.Remove(mul.SysNo);
            }
            else
            {
                this._Hashtable[mul.SysNo] = mul;
            }

            CallBack();
        }

        public void Reset(MulViewEntity oldMul, MulViewEntity newMul)
        {
            string index = string.Empty;

            foreach (DataRow dr in this._DataTable.Rows)
            {
                int sysno = int.Parse(dr[1].ToString());

                if (sysno == oldMul.SysNo)
                {
                    index = dr[0].ToString();

                    this._DataTable.Rows.Remove(dr);

                    break;
                }
            }

            //删除待拣货
            this._Hashtable.Remove(oldMul.SysNo);

            //增加新定位数据
            DataRow newDr = this._DataTable.NewRow();

            newDr[0] = index;

            newDr[1] = newMul.SysNo;

            this._DataTable.Rows.Add(newDr);

            this._Hashtable.Add(newMul.SysNo, newMul);

            CallBack();
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
        /// 显示前一页
        /// </summary>
        public void HookProv()
        {
            btnProv_Click(null, null);
        }

        /// <summary>
        /// 设置下一页
        /// </summary>
        public void HookNext()
        {
            btnNext_Click(null, null);
        }

        /// <summary>
        /// 保存快捷键
        /// </summary>
        public void HookSave()
        {
            //btnFinish_Click(null, null);

            this.FocusCount();
        }

        /// <summary>
        ///病单快捷键
        /// </summary>
        public void HookDad()
        {
            btnBad_Click(null, null);
        }

        /// <summary>
        /// 商品名称快捷键
        /// </summary>
        public void HookDetail()
        {
            btnDetail_Click(null, null);
        }

        #endregion
    }
}
