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
                entity.UserName = entity.UserID;

                entity.IsLoggedIn = true;
            }

            return entity;
        }

        public UserViewEntity LoginOut(UserViewEntity entity)
        {
            entity.IsLoggedIn = true;

            int sysno = LoginDA.LointOut(ref entity);

            if (sysno > 0)
            {
                entity.IsLoggedIn = false;
            }

            return entity;
        }
    }
}
