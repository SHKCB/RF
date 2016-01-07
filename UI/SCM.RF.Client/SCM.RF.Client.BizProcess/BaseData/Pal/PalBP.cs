using SCM.RF.Client.BizEntities.BasicData.Pal;
using SCM.RF.Client.Framework.Core;

namespace SCM.RF.Client.BizProcess.BaseData.Pal
{
   public class PalBP
    {
       /// <summary>
       /// 通过条码查询所有库位库存
       /// </summary>
       /// <param name="entity"></param>
       /// <param name="remote"></param>
       /// <returns></returns>
       public PalViewEntity GetEntity(PalViewEntity entity, RemoteServer remote)
       {
           entity = remote.Commond<PalViewEntity>(entity, "0004");

           return entity;
       }

       /// <summary>
       /// 通过库位查询该库位上的所有商品库存
       /// </summary>
       /// <param name="entity"></param>
       /// <param name="remote"></param>
       /// <returns></returns>
       public PalViewEntity GetList(PalViewEntity entity, RemoteServer remote)
       {
           entity = remote.Commond<PalViewEntity>(entity, "0006");

           return entity;
       }
    }
}
