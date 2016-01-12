using System.Collections.Generic;
using SCM.RF.Client.BizEntities.Sys;
using System.Collections.Generic;

namespace SCM.RF.Client.BizEntities.Receive
{
    public class ReceiveHeaderViewEntity : BaseViewEntity
    {
        /// <summary>
        /// 构造
        /// </summary>
        public ReceiveHeaderViewEntity(BaseViewEntity entity)
        {
            this.CID = base.CID;
            this.UName = base.UName;
            this.PWD = base.PWD;
            this.WareHouseId = base.WareHouseId;
        }

        public string Instockcode { get; set; }

        public string WareHouseId { get; set; }

        public ReceiveDetailViewEntity[] Detail { get; set; }
    }
}
