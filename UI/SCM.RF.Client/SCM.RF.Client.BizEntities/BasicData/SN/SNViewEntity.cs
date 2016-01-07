
/*
 * 唯一码
 * Add by 飞鱼 2012-6-15
 */
namespace SCM.RF.Client.BizEntities.BasicData.SN
{
    public class SNViewEntity
    {
        public SNViewEntity() { }

        public string SNCode { get; set; }

        public string BarCode { get; set; }

        public string ProductID { get; set; }

        public int ProductSysNo { get; set; }

        public int SysNo { get; set; }

        public bool Success { get; set; }

        public string Message { get; set; }

    }
}