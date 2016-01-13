using SCM.RF.Server.BizEntities.Sys;

namespace SCM.RF.Server.BizEntities.Pick
{
    public class PickEnity : BaseViewEntity
    {
        public PickEnity() { }
        /// <summary>
        /// 任务号
        /// </summary>
        public string TaskNo { get; set; }

        public OrderMasterEntity[] OrderMasterList { get; set; }

        public OrderItemEntity[] OrderItemList { get; set; }
    }
}
