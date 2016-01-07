namespace SCM.RF.Client.BizEntities.Picking
{
    /// <summary>
    /// 拣货
    /// </summary>
    public class OTSViewEntity
    {
        public int SysNo { get; set; }

        /// <summary>
        /// 外键
        /// </summary>
        public int MasterSysNo { get; set; }

        /// <summary>
        /// 集合单号
        /// </summary>
        public string LabelNO { get; set; }

        /// <summary>
        /// 任务编号
        /// </summary>
        public int TaskSysNo { get; set; }

        /// <summary>
        /// 任务号
        /// </summary>
        public string TaskNO { get; set; }

        /// <summary>
        /// 容器号
        /// </summary>
        public int ContainerSysNo { get; set; }

        /// <summary>
        /// 容器
        /// </summary>
        public string ContainerID { get; set; }

        /// <summary>
        /// 订单号
        /// </summary>
        public int OrderSysNo { get; set; }

        /// <summary>
        /// 订单号
        /// </summary>
        public string OrderID { get; set; }

        /// <summary>
        /// 订单类型 A - 单品；B - 多品；C - 渠道
        /// </summary>
        public string OrderType { get; set; }

        /// <summary>
        /// 商品主键
        /// </summary>
        public int ProductSysNo { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        public string ProductName { get; set; }

        /// <summary>
        /// 尺码
        /// </summary> 
        public string ProductSize { get; set; }

        /// <summary>
        /// 颜色
        /// </summary>
        public string ProductColor { get; set; }

        /// <summary>
        /// 条码
        /// </summary>
        public string BarCode { get; set; }

        /// <summary>
        /// 拣货总数量
        /// </summary>
        public int QTY { get; set; }

        /// <summary>
        /// 库位
        /// </summary>
        public int CellSysNo { get; set; }

        /// <summary>
        /// 库位
        /// </summary>
        public string CellNO { get; set; }

        /// <summary>
        /// 剩余拣货数量
        /// </summary>
        public int LessQTY { get; set; }

        /// <summary>
        /// 操作人
        /// </summary>
        public string InUser { get; set; }

        /// <summary>
        /// A - 待拣货(默认)；B - 正常拣货完成; C - 异常拣货完成；D - 无效
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
