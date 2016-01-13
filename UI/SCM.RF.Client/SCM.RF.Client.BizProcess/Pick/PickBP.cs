using SCM.RF.Client.BizEntities.Pick;
using SCM.RF.Client.Framework.Core;

namespace SCM.RF.Client.BizProcess.Pick
{
    public class PickBP
    {
        public PickViewEntity GetEntity(PickViewEntity entity, RemoteServer remote)
        {
            entity = remote.Commond<PickViewEntity>(entity, "4000");

            return entity;
        }
    }
}
