using SCM.RF.Client.BizEntities.AuthCenter;
using SCM.RF.Server.Utility;
using System;
using System.Data;
using System.Data.SqlClient;

/*
 * 登录
 * Add by [火狐] [2012-3-5]
 * Edit by [花名] [时间] [原因]
 */
namespace SCM.RF.Server.DataAccess.Login
{
    /// <summary>
    /// 登录
    /// </summary>
    public class LoginDA
    {
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public static int Login(ref UserViewEntity entity)
        {
            SCM.RF.Server.Adapt.IWebWarehouseServiceService service = new Adapt.IWebWarehouseServiceService();

            string param = @"<?xml version='1.0' encoding='UTF-8'?>
                                <rt>
                                <tid>" + DateTime.Now.ToString("yyyyMMddHHmmssfff") + @"</tid>
                                <uname>" + entity.UserID + @"</uname>
                                <pwd>" + entity.Password + @"</pwd>
                                <device>0</device>
                                </rt>";

            string result = service.login(param);

            return 0;


            //SQLHelper sqlLocal = new Utility.SQLHelper(SystemDA.SystemEntityInstance.authcenter);

            //string sql = "SELECT [SysNo],[DisplayName] FROM [AuthCenter].[dbo].[Sys_User] AS U WITH(NOLOCK) WHERE U.Name = @Name AND U.Password = @Password";

            //SqlParameter[] sqlParams = new SqlParameter[2] 
            //{ 
            //    new SqlParameter("@Name", entity.WkNo), 
            //    new SqlParameter("@Password", entity.Password) 
            //};

            //DataSet ds = sqlLocal.Query(sql, sqlParams);

            //if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            //{
            //    string username = ds.Tables[0].Rows[0][1].ToString();
            //    string sysno = ds.Tables[0].Rows[0][0].ToString();

            //    entity.UserName = username;

            //    return int.Parse(sysno);
            //}

            //return 0;
        }

        /// <summary>
        /// 获取用户权限
        /// </summary>
        /// <param name="sysno"></param>
        /// <param name="appid"></param>
        /// <returns></returns>
        public static DataSet GetList(int sysno, string appid)
        {
            SQLHelper sqlLocal = new Utility.SQLHelper("");

            SqlParameter[] sqlParams = new SqlParameter[2] 
            { 
                new SqlParameter("@USERID", sysno), 
                new SqlParameter("@ApplicationID",appid) 
            };

            //A.Description,A.Name AS Category,C.Name AS [Page],C.[Key]
            DataSet ds = sqlLocal.QueryTransaction("P_RIGHT", sqlParams);

            return ds;
        }

        /// <summary>
        /// 登录日志
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public static int LoginLog(UserViewEntity entity)
        {
            SQLHelper sqlLocal = new Utility.SQLHelper("");
            string sql = string.Format("INSERT INTO [{0}].[dbo].[LOGINLOG] ([UserName],[PassWord],[WKNo],[IP],[InDate],[IsLoggedIn])VALUES(@UserName,@PassWord,@WKNo,@IP,@InDate,@IsLoggedIn)", "");
            SqlParameter[] sqlParams = new SqlParameter[6] 
            { 
                new SqlParameter("@UserName", entity.UserName), 
                new SqlParameter("@PassWord", entity.Password),
                new SqlParameter("@WKNo", entity.WkNo), 
                new SqlParameter("@IP", entity.LocalIP==null?"":entity.LocalIP),
                new SqlParameter("@InDate", DateTime.Now),
                new SqlParameter("@IsLoggedIn", entity.IsLoggedIn) 
            };
            return sqlLocal.ExecuteSql(sql, sqlParams);
        }
    }
}
