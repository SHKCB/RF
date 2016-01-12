using SCM.RF.Client.BizEntities.Sys;

namespace SCM.RF.Client.BizEntities.Receive
{
    public class ReceiveHeaderViewEntity : BaseViewEntity
    {
        /// <summary>
        /// 构造
        /// </summary>
        public ReceiveHeaderViewEntity(BaseViewEntity entity)
        {
            this.CID = entity.CID;
            this.UName = entity.UName;
            this.PWD = entity.PWD;
            this.WareHouseId = entity.WareHouseId;
        }

        public string Instockcode { get; set; }

        public string WareHouseId { get; set; }

        public ReceiveDetailViewEntity[] Detail { get; set; }
    }
}
