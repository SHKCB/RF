namespace SCM.RF.Client.BizEntities.BasicData.CellPal
{
    /// <summary>
    /// 库位库存
    /// </summary>
    public class CellPalViewEntity
    {
        public CellPalViewEntity() { }

        public int SysNo { get; set; }

        public int CellSysNo { get; set; }

        public string CellNO { get; set; }

        public string CellUse { get; set; }

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

        public string BarCode { get; set; }

        /// <summary>
        /// 可用
        /// </summary>
        public int QCANUSE { get; set; }

        /// <summary>
        /// 财务库存
        /// </summary>
        public int Qty { get; set; }

        /// <summary>
        /// 是否为SN码
        /// </summary>
        public bool IsSN { get; set; }

        /// <summary>
        /// 员工
        /// </summary>
        public string InUser { get; set; }

        public bool Success { get; set; }

        public string Message { get; set; }
    }
}
