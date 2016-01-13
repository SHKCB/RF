using SCM.RF.Client.BizEntities.Receive;
using SCM.RF.Client.Framework.Core;

namespace SCM.RF.Client.BizProcess.Receive
{
    public class ReceiveBP
    {
        public ReceiveHeaderViewEntity GetReceiveDetail(ReceiveHeaderViewEntity entity, RemoteServer remote)
        {
            entity = remote.Commond<ReceiveHeaderViewEntity>(entity, "1001");

            return entity;
        }

      public ReceiveDetailViewEntity GetGoodsUnitInfos(ReceiveDetailViewEntity entity, RemoteServer remote)
      {
          entity = remote.Commond<ReceiveDetailViewEntity>(entity, "1002");

          return entity;
      }
    }
}
