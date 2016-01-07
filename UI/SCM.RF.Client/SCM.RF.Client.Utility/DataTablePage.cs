using System.Collections;
using System.Data;

namespace SCM.RF.Client.Utility
{
    public class DataTablePage
    {
        /// <summary>
        /// 分页
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="PageIndex"></param>
        /// <param name="PageSize"></param>
        /// <returns></returns>
        /// <summary>
        /// DataTable分页
        /// </summary>
        /// <param name="dt">DataTable</param>
        /// <param name="PageIndex">页索引,注意：从1开始</param>
        /// <param name="PageSize">每页大小</param>
        /// <returns>分好页的DataTable数据</returns>              第1页        每页10条
        public DataTable GetPagedTable(DataTable dt, int PageIndex, int PageSize)
        {
            if (PageIndex == 0) { return dt; }
            DataTable newdt = dt.Copy();
            newdt.Clear();
            int rowbegin = (PageIndex - 1) * PageSize;
            int rowend = PageIndex * PageSize;

            if (rowbegin >= dt.Rows.Count)
            { return newdt; }

            if (rowend > dt.Rows.Count)
            { rowend = dt.Rows.Count; }
            for (int i = rowbegin; i <= rowend - 1; i++)
            {
                DataRow newdr = newdt.NewRow();
                DataRow dr = dt.Rows[i];
                foreach (DataColumn column in dt.Columns)
                {
                    newdr[column.ColumnName] = dr[column.ColumnName];
                }
                newdt.Rows.Add(newdr);
            }
            return newdt;
        }

        public IList GetPagedTable2(DataTable dt, int PageIndex, int PageSize)
        {
            if (PageIndex == 0)
            {
                return null;
            }
            DataTable newdt = dt.Copy();
            newdt.Clear();
            int rowbegin = (PageIndex - 1) * PageSize;
            int rowend = PageIndex * PageSize;

            if (rowbegin >= dt.Rows.Count)
            {
                return null;
            }

            if (rowend > dt.Rows.Count)
            {
                rowend = dt.Rows.Count;
            }

            IList list = new ArrayList(PageSize);

            for (int i = rowbegin; i <= rowend - 1; i++)
            {
                DataRow dr = dt.Rows[i];

                string[] array = new string[3] { dr[0].ToString(), dr[1].ToString(), dr[2].ToString() };

                list.Add(array);
            }

            return list;
        }

        /// <summary>
        /// 页数
        /// </summary>
        /// <param name="count"></param>
        /// <param name="pageye"></param>
        /// <returns></returns>
        private int PageCount(int count, int PageSize)
        {
            int page = 0;

            int sesepage = PageSize;

            if (count % sesepage == 0)
            {
                page = count / sesepage;
            }
            else
            {
                page = (count / sesepage) + 1;
            }

            if (page == 0)
            {
                page += 1;
            }
            return page;
        }
    }
}
