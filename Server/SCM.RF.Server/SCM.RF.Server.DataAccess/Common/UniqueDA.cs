using SCM.RF.Server.BizEntities.Sys;
using SCM.RF.Server.Utility;
using System.Data.SqlClient;
/*
 * 取唯一值
 * Add by [火狐] [2012-3-8]
 * Edit by [花名] [时间] [原因]
 */
namespace SCM.RF.Server.DataAccess.Common
{
    /// <summary>
    /// 唯一值
    /// </summary>
    public class UniqueDA
    {
        /// <summary>
        /// 更新数据库的值
        /// </summary>
        /// <param name="UniqueID"></param>
        /// <returns></returns>
        public static int UpdateUnique(int UniqueID)
        {
            SQLHelper sqlLocal = new Utility.SQLHelper("");

            string sql = string.Format("UPDATE [{0}].[dbo].[UNIQUE] SET UniqueID = @UniqueID", "");

            SqlParameter[] sqlParams = new SqlParameter[1] { new SqlParameter("@UniqueID", UniqueID) };

            int reflect = sqlLocal.ExecuteSql(sql, sqlParams);

            return reflect;
        }

        /// <summary>
        /// 取唯一值
        /// </summary>
        /// <returns></returns>
        public static int GetUnique()
        {
            SQLHelper sqlLocal = new Utility.SQLHelper("");

            string sql = string.Format("SELECT TOP(1) [UniqueID] FROM  [{0}].[dbo].[UNIQUE] AS A WITH(NOLOCK)", "");

            object result = sqlLocal.GetSingle(sql);

            if (result == null)
            {
                return 0;
            }

            return int.Parse(result.ToString());
        }
    }
}
