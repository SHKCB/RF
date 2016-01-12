using SCM.RF.Client.BizEntities.Sys;

namespace SCM.RF.Client.BizEntities.Pick
{
    public class PickViewEntity : BaseViewEntity
    {
        public PickViewEntity(BaseViewEntity entity)
        {
            this.CID = base.CID;
            this.UName = base.UName;
            this.PWD = base.PWD;
            this.WareHouseId = base.WareHouseId;
        }

        /// <summary>
        /// 任务号
        /// </summary>
        public string TaskNo { get; set; }
    }
}
