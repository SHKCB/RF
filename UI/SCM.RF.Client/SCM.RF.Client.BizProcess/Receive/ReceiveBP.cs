using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using SCM.RF.Client.BizEntities.Receive;
using SCM.RF.Client.Framework.Core;

namespace SCM.RF.Client.BizProcess.Receive
{
  public  class ReceiveBP
    {
      public List<ReceiveDetailViewEntity> GetReceiveDetail(ReceiveHeaderViewEntity entity, RemoteServer remote)
      {
          List<ReceiveDetailViewEntity> result = remote.Commond<>(entity, "1001");

          return result;
      }
    }
}
