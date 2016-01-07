using SCM.RF.Client.BizEntities.BasicData.Cell;
using SCM.RF.Client.Framework.Core;

namespace SCM.RF.Client.BizProcess.BaseData.Cell
{
    public class CellBP
    {
        /// <summary>
        /// 查询库位
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="remote"></param>
        /// <returns></returns>
        public CellViewEntity GetEntity(CellViewEntity entity, RemoteServer remote)
        {
            entity = remote.Commond<CellViewEntity>(entity, "0002");

            return entity;
        }
    }
}
