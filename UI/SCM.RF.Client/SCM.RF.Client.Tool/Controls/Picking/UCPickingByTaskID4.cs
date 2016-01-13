using System;
using SCM.RF.Client.Tool;
using SCM.RF.Client.Tool.Controls.Common;
using System.Windows.Forms;
using SCM.RF.Client.Utility;
using SCM.RF.Client.BizEntities.Pick;
using System.Collections;
using System.Data;

namespace SCM.RF.Client.Tool.Controls.Picking
{
    public partial class UCPickingByTaskID4 : UCBasicControl
    {
        /// <summary>
        /// 
        /// </summary>
        private DataTable _DataTable;

        /// <summary>
        /// 待拣货记录
        /// </summary>
        private Hashtable _Hashtable;

        /// <summary>
        /// 主信息
        /// </summary>
        private PickViewEntity _PickViewEntity;

        private OrderItemEntity _OrderItemEntity;

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

        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="rf"></param>
        public UCPickingByTaskID4(RF rf)
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
            base.SetTitle("拣货中");
        }

        public override void Proc(EnMessageType type)
        {
            if (type == EnMessageType.A)
            {
                base.RF.ShowPicking1();
            }
            else
            {

            }
        }

        #endregion

        #region CLICK

        private void btnCancel_Click(object sender, EventArgs e)
        {
            base.ShowMessage("返回上级页面？", true, EnMessageType.A);
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

        private void btnFinish_Click(object sender, EventArgs e)
        {

        }

        private void btnPackage_Click(object sender, EventArgs e)
        {

        }

        private void btnDetail_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region FOCUS

        private void txtCellNo_GotFocus(object sender, EventArgs e)
        {

        }

        private void txtCellNo_LostFocus(object sender, EventArgs e)
        {

        }

        private void txtCellNo_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtCount_GotFocus(object sender, EventArgs e)
        {

        }

        private void txtCount_LostFocus(object sender, EventArgs e)
        {

        }

        private void txtCount_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtBarcode_GotFocus(object sender, EventArgs e)
        {

        }

        private void txtBarcode_LostFocus(object sender, EventArgs e)
        {

        }

        private void txtBarcode_KeyPress(object sender, KeyPressEventArgs e)
        {

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

        /// <summary>
        /// 清除 数据
        /// </summary>
        private void Clear()
        {
            pageindex = 1;

            this.lbProduct2.Text = string.Empty;
            this.lbBarCode2.Text = string.Empty;

            this.lbCellNo2.Text = string.Empty;
            this.lbQty2.Text = string.Empty;

            this.lbNext.Text = string.Empty;
            this.lbProduct4.Text = string.Empty;
            this.txtCount.Text = string.Empty;
            this.txtBarcode.Text = string.Empty;
            this.txtCellNo.Text = string.Empty;

            if (this._Hashtable.Count == 0)
            {
                base.ShowMessage("拣货完成！", false, EnMessageType.D, true);
            }
            else
            {
                ShowGrid();
            }
        }

        private void LoadData(OrderItemEntity item)
        {
            this._OrderItemEntity = null;

            if (item == null)
            {
                base.ShowMessage("无拣货信息！", false, EnMessageType.G, false);

                return;
            }

            this.lbProduct2.Text = item.outerid;//商家编码

            this.lbBarCode2.Text = item.cbarcode;//商品条码

            this.lbCellNo2.Text = item.fromitemcode;//拣货库位

            this.lbQty2.Text = item.amount;//待拣货数量

            if (item.amount == "1")
            {
                this.txtCount.Text = "1";
            }
            else
            {
                this.txtCount.Text = string.Empty;
            }

            this._OrderItemEntity = item;
        }

        /// <summary>
        /// 拣货
        /// </summary>
        /// <param name="barcode"></param>
        /// <param name="count"></param>
        private void AddData(string cellno, string barcode, int count)
        {
            //if (this._MulViewEntity == null)
            //{
            //    base.ShowMessage("无拣货信息！", false, EnMessageType.A, false);

            //    return;
            //}

            //MulViewEntity param = new MulViewEntity();

            //param = this._MulViewEntity;
            //param.LabelNO = this._LabelEntity.LabelNO;
            //param.BarCode = barcode;
            //param.QTY = count;
            //param.InUser = base.UserViewEntity.UserName;
            //param.LessQTY = this._MulViewEntity.LessQTY - count;
            //param.Status = param.LessQTY > 0 ? "B" : "C";//A - 待拣货(默认)；B - 捡货中; C - 正常拣货完成；D - 无效；
            //param.ContainerID = this._LabelEntity.ContainerID;
            //param.ContainerSysNo = this._LabelEntity.ContainerSysNo;
            //param.TaskNO = this._LabelEntity.TaskNO;
            //param.TaskSysNo = this._LabelEntity.TaskSysNo;

            //MulViewEntity result = new LabelBP().Update(param, base.RemoteServer);

            //if (result != null)
            //{
            //    if (result.Success)
            //    {
            //        if (param.LessQTY > 0)
            //        {
            //            MulViewEntity mul = this._Hashtable[this._MulViewEntity.SysNo] as MulViewEntity;

            //            if (mul != null)
            //            {
            //                mul.LessQTY = param.LessQTY;

            //                this._Hashtable[this._MulViewEntity.SysNo] = mul;
            //            }
            //        }
            //        else
            //        {
            //            foreach (DataRow dr in this._DataTable.Rows)
            //            {
            //                int sysno = int.Parse(dr[1].ToString());

            //                if (sysno == this._MulViewEntity.SysNo)
            //                {
            //                    this._DataTable.Rows.Remove(dr);

            //                    break;
            //                }
            //            }

            //            //删除待拣货
            //            this._Hashtable.Remove(this._MulViewEntity.SysNo);
            //        }

            //        base.ShowMessage(result.Message, false, EnMessageType.F, true);
            //    }
            //    else
            //    {
            //        base.ShowMessage(result.Message, false, EnMessageType.G, false);
            //    }
            //}
            //else
            //{
            //    base.ShowMessage("错误，重新登录！", false, EnMessageType.B, false);
            //}
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

                OrderItemEntity item = this._Hashtable[sysno] as OrderItemEntity;

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

            this.ShowNextGrid(pageindex);

            this.FocusCellNo();
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

                    OrderItemEntity item = this._Hashtable[sysno] as OrderItemEntity;

                    if (item != null)
                    {
                        this.lbNext.Text = item.fromitemcode;

                        this.lbProduct4.Text = item.cbarcode;

                        this.lbQty3.Text = item.amount.ToString();

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

        private void FocusCellNo()
        {
            this.txtCellNo.SelectAll();
            this.txtCellNo.Focus();
        }

        private void FocusBarcoe()
        {
            this.txtBarcode.SelectAll();
            this.txtBarcode.Focus();
        }

        private void FocusCount()
        {
            this.txtCount.Text = string.Empty;
            this.txtCount.Focus();
        }

        #endregion

        #region PUBLIC FUNCTION

        public void LoadData(PickViewEntity entity)
        {
            this._DataTable.Clear();

            this._PickViewEntity = entity;

            if (entity.OrderItemList != null)
            {
                int count = entity.OrderItemList.Length;

                this._Hashtable = new Hashtable(count);

                for (int i = 0; i < count; i++)
                {
                    this._Hashtable.Add(entity.OrderItemList[i].num, entity.OrderItemList[i]);

                    DataRow dr = this._DataTable.NewRow();

                    dr[0] = i + 1;

                    dr[1] = entity.OrderItemList[i].num;

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
            //base.RF.HidePicking3();

            base.Init(base.HookType);

            this.Init();
        }

        //public void Reset(MulViewEntity oldMul, MulViewEntity newMul)
        //{
        //    string index = string.Empty;

        //    foreach (DataRow dr in this._DataTable.Rows)
        //    {
        //        int sysno = int.Parse(dr[1].ToString());

        //        if (sysno == oldMul.SysNo)
        //        {
        //            index = dr[0].ToString();

        //            this._DataTable.Rows.Remove(dr);

        //            break;
        //        }
        //    }

        //    //删除待拣货
        //    this._Hashtable.Remove(oldMul.SysNo);

        //    //增加新定位数据
        //    DataRow newDr = this._DataTable.NewRow();

        //    newDr[0] = index;

        //    newDr[1] = newMul.SysNo;

        //    this._DataTable.Rows.Add(newDr);

        //    this._Hashtable.Add(newMul.SysNo, newMul);

        //    CallBack();
        //}

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

            //this.FocusCount();
        }

        /// <summary>
        /// 明细快捷键
        /// </summary>
        public void HookDetail()
        {
            btnDetail_Click(null, null);
        }

        /// <summary>
        /// 篮号快捷键
        /// </summary>
        public void HookPackage()
        {
            btnDetail_Click(null, null);
        }

        #endregion
    }
}
