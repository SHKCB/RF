using SCM.RF.Server.BizEntities.Sys;
using System.Collections.Generic;

namespace SCM.RF.Server.BizEntities.Receive
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
