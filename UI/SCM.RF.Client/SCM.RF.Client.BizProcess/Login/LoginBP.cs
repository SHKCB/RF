using SCM.RF.Client.BizEntities.Sys;
using SCM.RF.Client.Framework.Core;

namespace SCM.RF.Client.BizProcess.Login
{
    /// <summary>
    /// ��¼
    /// </summary>
    public class LoginBP
    {
        /// <summary>
        /// ��¼ϵͳ
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
        /// �˳�ϵͳ
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
