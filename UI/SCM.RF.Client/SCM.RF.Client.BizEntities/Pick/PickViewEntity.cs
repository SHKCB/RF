using SCM.RF.Client.BizEntities.Sys;

namespace SCM.RF.Client.BizEntities.Pick
{
    public class PickViewEntity : BaseViewEntity
    {
        public PickViewEntity() { }

        public PickViewEntity(BaseViewEntity entity)
        {
            this.CID = entity.CID;
            this.UName = entity.UName;
            this.PWD = entity.PWD;
            this.WareHouseId = entity.WareHouseId;
            this.Device = entity.Device;
        }

        /// <summary>
        /// 任务号
        /// </summary>
        public string TaskNo { get; set; }

        public OrderMasterEntity[] OrderMasterList { get; set; }

        public OrderItemEntity[] OrderItemList { get; set; }
    }
}
