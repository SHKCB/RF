using SCM.RF.Server.BizEntities.Receive;
using SCM.RF.Server.DataAccess.Receive;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SCM.RF.Server.BizProcess.Receive
{
    public class ReceiveBP
    {

        public ReceiveHeaderViewEntity GetReceiveDetail(ReceiveHeaderViewEntity entity)
        {
            ReceiveDA.GetReceiveDetail(entity);

            return entity;
        }
    }
}
