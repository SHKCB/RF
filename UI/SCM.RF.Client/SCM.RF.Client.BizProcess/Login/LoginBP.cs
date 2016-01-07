using SCM.RF.Client.BizEntities.Sys;
using SCM.RF.Client.Framework.Core;

namespace SCM.RF.Client.BizProcess.Login
{
    /// <summary>
    /// 登录
    /// </summary>
    public class LoginBP
    {
        /// <summary>
        /// 登录系统
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="remote"></param>
        /// <returns></returns>
        public UserViewEntity LoginIn(UserViewEntity entity, RemoteServer remote)
        { 
            entity = remote.Commond<UserViewEntity>(entity, "0000");

            return entity;
        }

        /// <summary>
        /// 退出系统
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="remote"></param>
        public UserViewEntity LoginOut(UserViewEntity entity, RemoteServer remote)
        {
            entity = remote.Commond<UserViewEntity>(entity, "9999");

            return entity;
        }
    }
}
