using SCM.RF.Client.BizEntities.AuthCenter;
using SCM.RF.Server.Utility;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Xml;

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
                                <device>" + entity.Device + @"</device>
                                <cid>" + entity.CID + @"</cid>
                                </rt>";

            string result = service.login(param);

            if (result.IndexOf("<rc>0000</rc>") >= 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }

            /*
<?xml version="1.0" encoding="UTF-8"?>
<rt>
<tid>20140318155513001</tid>
<rc>0000</rc>
<rm>成功</rm>
</rt>
             */

            //<rc>0000</rc><rm>成功</rm><?xml version="1.0" encoding="UTF-8"?><rt><tid>20160107192619929</tid></rt>

            //XmlDocument xml = new XmlDocument();

            //xml.LoadXml(result);

            //return 1;
        }

        /// <summary>
        /// 退出系统
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public static int LointOut(ref UserViewEntity entity)
        {
            SCM.RF.Server.Adapt.IWebWarehouseServiceService service = new Adapt.IWebWarehouseServiceService();

            string param = @"<?xml version='1.0' encoding='UTF-8'?>
                                <rt>
                                <tid>" + DateTime.Now.ToString("yyyyMMddHHmmssfff") + @"</tid>
                                <uname>" + entity.UserID + @"</uname>
                                <pwd>" + entity.Password + @"</pwd>
                                <device>" + entity.Device + @"</device>
                                <cid>" + entity.CID + @"</cid>
                                </rt>";

            string result = service.loginout(param);

            if (result.IndexOf("<rc>0000</rc>") >= 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
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
                new SqlParameter("@UserID", entity.UserID), 
                new SqlParameter("@IP", entity.LocalIP==null?"":entity.LocalIP),
                new SqlParameter("@InDate", DateTime.Now),
                new SqlParameter("@IsLoggedIn", entity.IsLoggedIn) 
            };
            return sqlLocal.ExecuteSql(sql, sqlParams);
        }
    }
}
