using SCM.RF.Server.BizEntities.Pick;
using SCM.RF.Server.DataAccess.Pick;

namespace SCM.RF.Server.BizProcess.Pick
{
    public class PickBP
    {
        public PickEnity GetPick(PickEnity entity)
        {
            entity = PickDA.GetPickByTaskID(ref entity);

            return entity;
        }
    }
}
