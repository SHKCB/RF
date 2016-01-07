using SCM.RF.Client.BizEntities.Sys;
using SCM.RF.Client.Framework.Core;

namespace SCM.RF.Client.BizProcess.Sys
{
    /// <summary>
    /// 心跳
    /// </summary>
    public class KeepAliveBP
    {
        public KeepAliveEntity KeepAlive(KeepAliveEntity entity, RemoteServer remote)
        {
            entity = remote.Commond<KeepAliveEntity>(entity, "0009");

            return entity;
        }
    }
}
