using System.Collections.Generic;
using SCM.RF.Server.DataAccess.AuthCenter;

namespace SCM.RF.Server.BizProcess.AuthCenter
{
    public class UserBP
    {
        public IList<int> GetList()
        {
            return UserDA.GetList();
        }
    }
}
