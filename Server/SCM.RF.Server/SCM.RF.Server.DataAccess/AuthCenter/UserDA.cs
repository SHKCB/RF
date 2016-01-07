using SCM.RF.Server.Utility;
using System.Collections.Generic;
using System.Data;

namespace SCM.RF.Server.DataAccess.AuthCenter
{
    public class UserDA
    {
        public static IList<int> GetList()
        {
            SQLHelper sqlLocal = new Utility.SQLHelper("");

            string sql = "SELECT [Name] FROM [AuthCenter].[dbo].[Sys_User] AS A WITH(NOLOCK) WHERE A.RF = 'A' AND A.[Status] = 'A' ";

            DataSet ds = sqlLocal.Query(sql);

            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                int count = ds.Tables[0].Rows.Count;

                IList<int> list = new List<int>(count);

                for (int i = 0; i < count; i++)
                {
                    int port = 3000 + int.Parse(ds.Tables[0].Rows[i][0].ToString());

                    list.Add(port);
                }

                return list;
            }

            return new List<int>(0);
        }
    }
}
