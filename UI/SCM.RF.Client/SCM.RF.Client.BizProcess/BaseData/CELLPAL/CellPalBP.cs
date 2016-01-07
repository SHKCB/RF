using SCM.RF.Client.BizEntities.BasicData.CellPal;
using SCM.RF.Client.Framework.Core;

namespace SCM.RF.Client.BizProcess.BaseData.CELLPAL
{
    public class CellPalBP
    {
        /// <summary>
        /// 通过库位查询该库位上所有的商品库存
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="remote"></param>
        /// <returns></returns>
        public CellPalViewEntity GetEntity(CellPalViewEntity entity, RemoteServer remote)
        {
            entity = remote.Commond<CellPalViewEntity>(entity, "0003");

            return entity;
        }
    }
}
