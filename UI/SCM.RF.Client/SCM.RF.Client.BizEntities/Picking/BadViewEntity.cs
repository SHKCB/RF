namespace SCM.RF.Client.BizEntities.Picking
{
    /// <summary>
    /// 病单
    /// </summary>
    public class BadViewEntity
    {
        public int SysNo { get; set; }

        /// <summary>
        /// 外键
        /// </summary>
        public int MasterSysNo { get; set; }

        public string LabelNO { get; set; }

        public int ContainerSysNo { get; set; }

        public string ContainerID { get; set; }

        public int OrderSysNo { get; set; }

        public string OrderID { get; set; }

        public int ProductSysNo { get; set; }

        public string BarCode { get; set; }
    
        public int CellSysNo { get; set; }

        public string CellNO { get; set; }

        /// <summary>
        /// 病单数量
        /// </summary>
        public int BadQty { get; set; }
        /// <summary>
        /// 剩余拣货数量
        /// </summary>
        public int LessQTY { get; set; }

        /// <summary>
        /// 操作人
        /// </summary>
        public string InUser { get; set; }

        /// <summary>
        /// A - 待处理 B - 已处理 D - 无效
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// 顺序
        /// </summary>
        public int Index { get; set; }

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
