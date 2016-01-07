namespace SCM.RF.Client.BizEntities.Putaway
{
    public class PutawayItemViewEntity
    {
        public PutawayItemViewEntity() { }

        /// <summary>
        /// 编号
        /// </summary>
        public int SysNo { get; set; }

        /// <summary>
        /// 外键
        /// </summary>
        public int MasterSysNo { get; set; }

        /// <summary>
        /// 外键
        /// </summary>
        public int POSysNo { get; set; }

        /// <summary>
        /// A-大货入库； B-返修入库； C-调拨入库； D-RMA入库； E-渠道退货； F-库内返架
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// 上架单号
        /// </summary>
        public string IMPNO { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int POItemSysNo { get; set; }

        /// <summary>
        /// A - 正品 B - 次品
        /// </summary>
        public string IMPType { get; set; }
        ///// <summary>
        ///// 外键
        ///// </summary>
        //public int BOSysNo { get; set; }

        ///// <summary>
        ///// 
        ///// </summary>
        //public int BOItemSysNo { get; set; }

        ///// <summary>
        ///// 采购单号
        ///// </summary>
        //public string PurchaseID { get; set; }

        ///// <summary>
        ///// 合同号
        ///// </summary>
        //public string ContractID { get; set; }

        /// <summary>
        /// 容器号主键
        /// </summary>
        public int ContainerSysNo { get; set; }

        /// <summary>
        /// 容器号
        /// </summary>
        public string ContainerID { get; set; }

        /// <summary>
        /// 商品主键
        /// </summary>
        public int ProductSysNo { get; set; }

        /// <summary>
        /// 商品条码
        /// </summary>
        public string BarCode { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        public string ProductName { get; set; }

        /// <summary>
        /// 颜色
        /// </summary>
        public string ProductColor { get; set; }

        /// <summary>
        /// 尺码
        /// </summary>
        public string ProductSize { get; set; }

        /// <summary>
        /// 库位主键
        /// </summary>
        public int CellSysNo { get; set; }

        /// <summary>
        /// 库位
        /// </summary>
        public string CellNO { get; set; }

        /// <summary>
        /// 总上架数量
        /// </summary>
        public int Qty { get; set; }

        /// <summary>
        /// 剩余数量
        /// </summary>
        public int LessQTY { get; set; }

        /// <summary>
        /// 返回值
        /// </summary>
        public bool Success { get; set; }

        /// <summary>
        /// 返回值对应的信息
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// 当前操作人
        /// </summary>
        public string InUser { get; set; }
    }
}
