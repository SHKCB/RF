using System;
using System.Collections;
using System.Data;
using System.Windows.Forms;
using SCM.RF.Client.BizEntities.Putaway;
using SCM.RF.Client.Tool.Controls.Common;
using SCM.RF.Client.Utility;

namespace SCM.RF.Client.Tool.Controls.PutAway
{
    public partial class UCPutawayLog : UCBasicControl
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
        /// 待shangjia记录
        /// </summary>
        private Hashtable _ItemList = null;

        private UCPutaway3 _UCPutaway3;

        #endregion

        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="rf"></param>
        public UCPutawayLog(RF rf)
            : base(rf)
        {
            _DataTablePage = new DataTablePage();

            this._DataTable = new DataTable();

            this._DataTable.Columns.Add(new DataColumn("BarCode", typeof(System.String)));

            this._DataTable.Columns.Add(new DataColumn("CellNO", typeof(System.String)));

            this._DataTable.Columns.Add(new DataColumn("Qty", typeof(System.String)));

            InitializeComponent();
        }

        #region 重载 override

        public override void Init()
        {

        }

        public override void Proc(EnMessageType type)
        {
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
            this._UCPutaway3.CallBack2();
            this.btnCancel.Enabled = true;
        }
        #endregion

        #region PRIVETE FOUNCTION

        private void ShowGrid()
        {
            pageindex = pagecount = (int)Math.Ceiling((double)this._DataTable.Rows.Count / pagesize);

            ShowGrid(pageindex);
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
        }

        #endregion

        #region PUBLIC FUNCTION

        public void LoadData(Hashtable itemList, UCPutaway3 uc)
        {
            this._DataTable.Clear();

            this._UCPutaway3 = uc;

            IDictionaryEnumerator ide = itemList.GetEnumerator();

            DataTable dtTemp = new DataTable();

            dtTemp = this._DataTable.Clone();

            PutawayItemViewEntity itemEntity = null;

            while (ide.MoveNext())
            {
                itemEntity = ide.Value as PutawayItemViewEntity;

                if (itemEntity != null)
                {
                    DataRow dr = dtTemp.NewRow();

                    dr[0] = itemEntity.BarCode;

                    dr[1] = "";

                    dr[2] = itemEntity.LessQTY;

                    dtTemp.Rows.Add(dr);
                }
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

            ShowGrid();
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
