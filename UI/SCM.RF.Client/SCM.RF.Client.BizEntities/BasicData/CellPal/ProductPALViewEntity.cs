namespace SCM.RF.Client.BizEntities.BasicData.CellPal
{
    /// <summary>
    /// 商品库位库存
    /// </summary>
    public class ProductPALViewEntity
    {
        public ProductPALViewEntity() { }

        public int ProductSysNo { get; set; }

        public string BarCode { get; set; }

        public int CellSysNo { get; set; }

        public string CellNO { get; set; }

        /// <summary>
        /// 可用
        /// </summary>
        public int QCANUSE { get; set; }

        /// <summary>
        /// 财务库存
        /// </summary>
        public int Qty { get; set; }
    }
}
