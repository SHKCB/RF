
namespace SCM.RF.Client.BizEntities.Pick
{
    /// <summary>
    /// 订单
    /// </summary>
    public class OrderMasterEntity
    {
        public OrderMasterEntity() { }
        public string num { get; set; }
        public string id { get; set; }
        public string tousername { get; set; }
        public string dispatchcode { get; set; }
        public string ordercode { get; set; }
        public string taskid { get; set; }
    }
}
