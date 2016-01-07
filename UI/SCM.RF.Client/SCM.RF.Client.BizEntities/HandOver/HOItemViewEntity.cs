namespace SCM.RF.Client.BizEntities.HandOver
{
    public class HOItemViewEntity
    {
        public HOItemViewEntity() { }

        public int SysNo { get; set; }

        public int HOSysNo { get; set; }

        public string OrderID { get; set; }

        public string DeliveryNo { get; set; }

        public string Status { get; set; }

        public string InUser { get; set; }

        /// <summary>
        /// 返回值
        /// </summary>
        public bool Success { get; set; }

        /// <summary>
        /// 返回值对应的信息
        /// </summary>
        public string Message { get; set; }
    }
}
