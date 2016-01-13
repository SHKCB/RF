
namespace SCM.RF.Client.BizEntities.Pick
{
    /// <summary>
    /// 订单明细
    /// </summary>
    public class OrderItemEntity
    {
        public OrderItemEntity() { }

        public string num { get; set; }
        public string outerid { get; set; }
        public string cbarcode { get; set; }
        public string shortname { get; set; }
        public string amount { get; set; }
        public string doneamount { get; set; }
        public string fromitemcode { get; set; }
        public string taskid { get; set; }
        public string taskdid { get; set; }
    }
}
