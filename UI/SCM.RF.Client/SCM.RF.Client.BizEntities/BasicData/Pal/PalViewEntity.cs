using SCM.RF.Client.BizEntities.BasicData.CellPal;

namespace SCM.RF.Client.BizEntities.BasicData.Pal
{
    /// <summary>
    /// 总库存
    /// </summary>
    public class PalViewEntity
    {
        public PalViewEntity() { }

        public int ProductSysNo { get; set; }

        public string BarCode { get; set; }

        public int CellSysNo { get; set; }

        public string CellNO { get; set; }

        public ProductPALViewEntity[] ItemList { get; set; }

        public bool Success { get; set; }

        public string Message { get; set; }
    }
}
