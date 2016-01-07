using SCM.RF.Client.BizEntities.Putaway;
using SCM.RF.Client.Framework.Core;
using Justyle.WMS.RF.Server.BizEntities.Putaway;

namespace SCM.RF.Client.BizProcess.Putaway
{
    public class PutawayBP
    {
        /// <summary>
        /// 根据用户扫描的箱号查询上架详细
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="remote"></param>
        /// <returns></returns>
        public PutawayViewEntity GetEntity(PutawayViewEntity entity, RemoteServer remote)
        {
            entity = remote.Commond<PutawayViewEntity>(entity, "3000");

            return entity;
        }

        /// <summary>
        /// 更新一条明细为上架完成 拆零上架
        /// </summary>
        /// <returns></returns>
        public PutawayItemViewEntity Insert(PutawayItemViewEntity entity, RemoteServer remote)
        {
            entity = remote.Commond<PutawayItemViewEntity>(entity, "3001");

            return entity;
        }

        /// <summary>
        /// 更改主表状态 B - 上架中； C - 上架结束
        /// </summary>
        /// <returns></returns>
        public PutawayViewEntity Update(PutawayViewEntity entity, RemoteServer remote)
        {
            entity = remote.Commond<PutawayViewEntity>(entity, "3002");

            return entity;
        }

        /// <summary>
        /// 整箱上架
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="remote"></param>
        /// <returns></returns>
        public PutawayViewEntity InsertAll(PutawayViewEntity entity, RemoteServer remote)
        {
            entity = remote.Commond<PutawayViewEntity>(entity, "3003");

            return entity;
        }
    }
}
