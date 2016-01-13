using SCM.RF.Server.BizEntities.Receive;
using SCM.RF.Server.DataAccess.Receive;

namespace SCM.RF.Server.BizProcess.Receive
{
    public class ReceiveBP
    {
        public ReceiveHeaderViewEntity GetReceiveDetail(ReceiveHeaderViewEntity entity)
        {
            entity = ReceiveDA.GetReceiveDetail(ref entity);

            return entity;
        }
    }
}
