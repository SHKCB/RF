using SCM.RF.Client.BizEntities.HandOver;
using SCM.RF.Client.Framework.Core;

namespace SCM.RF.Client.BizProcess.HandOver
{
    public class HOBP
    {
        /// <summary>
        /// 读取交接单号
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="remote"></param>
        /// <returns></returns>
        public HOViewEntity GetEntity(HOViewEntity entity, RemoteServer remote)
        {
            entity = remote.Commond<HOViewEntity>(entity, "7001");

            return entity;
        }

        /// <summary>
        /// 交接
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="remote"></param>
        /// <returns></returns>
        public HOItemViewEntity Insert(HOItemViewEntity entity, RemoteServer remote)
        {
            entity = remote.Commond<HOItemViewEntity>(entity, "7002");

            return entity;
        }

        /// <summary>
        /// 交接old
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="remote"></param>
        /// <returns></returns>
        public HOItemViewEntity Insert2(HOItemViewEntity entity, RemoteServer remote)
        {
            entity = remote.Commond<HOItemViewEntity>(entity, "7003");

            return entity;
        }
    }
}
