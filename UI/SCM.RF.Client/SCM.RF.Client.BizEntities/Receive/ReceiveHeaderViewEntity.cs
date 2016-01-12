﻿using System.Collections.Generic;
using SCM.RF.Client.BizEntities.Sys;
using System.Collections.Generic;

namespace SCM.RF.Client.BizEntities.Receive
{
    public class ReceiveHeaderViewEntity : BaseViewEntity
    {

         /// <summary>
        /// 构造
        /// </summary>
       public ReceiveHeaderViewEntity() { }

       public string Instockcode { get; set; }

       public string WareHouseId { get; set; }

       public ReceiveDetailViewEntity[] Detail { get; set; }
    }
}
