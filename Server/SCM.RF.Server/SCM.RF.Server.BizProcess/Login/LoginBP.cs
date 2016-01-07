using SCM.RF.Client.BizEntities.AuthCenter;
using SCM.RF.Server.DataAccess.Login;
using System.Data;

/*
 * 登录 返回登录成功状态与权限 
 * Add by [火狐] [2012-3-5]
 * Edit by [飞鱼] [2012-6-14] [扩展商品缓存内容]
 */
namespace SCM.RF.Server.BizProcess.Login
{
    public class LoginBP
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public UserViewEntity Login(UserViewEntity entity)
        {
            entity.IsLoggedIn = false;

            int sysno = LoginDA.Login(ref entity);

            if (sysno > 0)
            {
                //A.SysNo,A.[Key],A.Name
                DataSet ds = LoginDA.GetList(sysno, entity.ApplicationID);

                if (ds.Tables.Count > 0)
                {
                    DataTable dt = ds.Tables[0];

                    int count = dt.Rows.Count;

                    UserRightViewEntity[] array = new UserRightViewEntity[count];

                    UserRightViewEntity right = null;

                    for (int i = 0; i < count; i++)
                    {
                        //A.Description,A.Name AS Category,C.Name AS [Page],C.[Key]
                        right = new UserRightViewEntity();
                        right.Description = dt.Rows[i][0].ToString().Trim().Replace(System.Environment.NewLine, "");
                        right.Category = dt.Rows[i][1].ToString().Trim().Replace(System.Environment.NewLine, "");
                        right.Page = dt.Rows[i][2].ToString().Trim().Replace(System.Environment.NewLine, "");
                        right.Key = dt.Rows[i][3].ToString().Trim().Replace(System.Environment.NewLine, "");
                        array[i] = right;
                    }

                    entity.IsLoggedIn = true;
                    entity.ItemList = array;
                }
            }
            LoginDA.LoginLog(entity);
            return entity;
        }
    }
}
