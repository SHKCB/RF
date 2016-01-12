using SCM.RF.Server.BizEntities.Pick;

namespace SCM.RF.Server.BizProcess.Pick
{
    public class PickBP
    {
        public PickEnity GetPick(PickEnity entity)
        {
            //entity.IsLoggedIn = false;

            //int sysno = LoginDA.Login(ref entity);

            //if (sysno > 0)
            //{
            //    entity.UserName = entity.UserID;

            //    entity.IsLoggedIn = true;
            //}

            return entity;
        }
    }
}
