using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using SCM.RF.Client.Utility;
using SCM.RF.Client.BizEntities.BasicData.Pal;
using SCM.RF.Client.BizProcess.BaseData.Pal;
using SCM.RF.Client.BizEntities.BasicData.CellPal;

namespace SCM.RF.Client.Tool.Controls.Common
{
    public partial class UCCellPalByCell : UCBasicControl
    {
        #region PRIVATE MEMBER

        private DataTable _DataTable;

        /// <summary>
        /// 每页显示数量
        /// </summary>
        private int pagesize = 9;

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
        /// 父级页面
        /// </summary>
        private object _T;

        private EnPalType PalType;

        #endregion

        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="rf"></param>
        public UCCellPalByCell(RF rf)
            : base(rf)
        {
            _DataTablePage = new DataTablePage();

            this._DataTable = new DataTable();

            this._DataTable.Columns.Add(new DataColumn("BarCode", typeof(System.String)));

            this._DataTable.Columns.Add(new DataColumn("Qty", typeof(System.String)));

            this._DataTable.Columns.Add(new DataColumn("QcanUse", typeof(System.String)));

            InitializeComponent();
        }

        #region 重载 override

        public override void Init()
        {
            base.RF.SetTitle("库存查询");

            this.lvList.Items.Clear();

            this.lvList.Refresh();

            this.lbPage.Visible = false;

            this.lbPage.Text = "第0页/共0页";

            this.FocusCellNo();
        }

        public override void Proc(EnMessageType type)
        {
            if (type == EnMessageType.A)
            {
                this.FocusCellNo();
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

        #region FOCUS

        private void txtCellNo_GotFocus(object sender, EventArgs e)
        {
            this.pbProduct.BackColor = Color.Yellow;
        }

        private void txtCellNo_LostFocus(object sender, EventArgs e)
        {
            this.pbProduct.BackColor = Color.White;
        }

        #endregion

        #region CLICK

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
            this.btnCancel.Enabled = false;

            base.RF.Cancel();

            this.btnCancel.Enabled = true;
        }

        private void txtCellNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;

                string cellno = this.txtCellNo.Text.Trim().ToUpper();

                if (cellno.Length > 0)
                {
                    if (SCM.RF.Client.Utility.StringHelper.ISStringInt32(cellno))
                    {
                        LoadData(cellno);
                    }
                    else
                    {
                        base.ShowMessage("条码格式错误！", false, EnMessageType.A, false);
                    }
                }
            }
        }

        #endregion

        #region PUBLIC FUNCTION

        public void LoadData(object uc, EnPalType type)
        {
            this.PalType = type;

            this._T = uc;

            this._DataTable.Clear();
        }

        #endregion

        #region PRIVATE FUNCTION

        private void LoadData(string cellno)
        {
            this._DataTable.Clear();

            PalViewEntity param = new PalViewEntity();

            param.CellNO = cellno;

            PalViewEntity result = new PalBP().GetList(param, base.RemoteServer);

            if (result != null)
            {
                if (result.Success)
                {
                    ProductPALViewEntity[] array = result.ItemList;

                    if (array != null)
                    {
                        DataTable dtTemp = new DataTable();

                        dtTemp = this._DataTable.Clone();

                        foreach (ProductPALViewEntity pal in array)
                        {
                            DataRow dr = dtTemp.NewRow();

                            dr[0] = pal.BarCode;

                            dr[1] = pal.Qty;

                            dr[2] = pal.QCANUSE;

                            dtTemp.Rows.Add(dr);
                        }

                        DataRow[] drArray = dtTemp.Select("1=1", "BarCode Asc");

                        foreach (DataRow item in drArray)
                        {
                            DataRow dr = this._DataTable.NewRow();
                            dr[0] = item[0].ToString();
                            dr[1] = item[1].ToString();
                            dr[2] = item[2].ToString();

                            this._DataTable.Rows.Add(dr);
                        }

                        dtTemp = null;

                        drArray = null;
                    }

                    base.RF.PlaySound(true);
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

            ShowGrid();
        }

        private void ShowGrid()
        {
            pageindex = pagecount = (int)Math.Ceiling((double)this._DataTable.Rows.Count / pagesize);

            ShowGrid(pageindex);
        }

        private void FocusCellNo()
        {
            this.txtCellNo.SelectAll();

            this.txtCellNo.Focus();
        }

        /// <summary>
        /// 显示分页
        /// </summary>
        /// <param name="pageindex"></param>
        private void ShowGrid(int pageindex)
        {
            this.lvList.Items.Clear();

            DataTable dt = _DataTablePage.GetPagedTable(this._DataTable, pageindex, pagesize);

            int count = dt.Rows.Count;

            for (int i = 0; i < count; i++)
            {
                this.lvList.Items.Add(new ListViewItem(new string[] { Convert.ToString(i + 1), dt.Rows[i][0].ToString(), dt.Rows[i][1].ToString(), dt.Rows[i][2].ToString() }));
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

            this.FocusCellNo();
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


        #endregion
    }
}
