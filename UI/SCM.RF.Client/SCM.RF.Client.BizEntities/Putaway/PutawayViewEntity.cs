using SCM.RF.Client.BizEntities.Putaway;

namespace Justyle.WMS.RF.Server.BizEntities.Putaway
{
    public class PutawayViewEntity
    {
        public PutawayViewEntity() { }

        #region 上架实体

        /// <summary>
        /// 主表编号
        /// </summary>
        public int SysNo { get; set; }

        /// <summary>
        /// 任务号
        /// </summary>
        public int TaskSysNo { get; set; }

        /// <summary>
        /// 任务号
        /// </summary>
        //public int TaskNO { get; set; }

        /// <summary>
        /// 上架单据号
        /// </summary>
        public string IMPNO { get; set; }

        /// <summary>
        /// 外键
        /// </summary>
        public int POSysNo { get; set; }

        /// <summary>
        /// 外键
        /// </summary>
        //public int BOSysNo { get; set; }

        /// <summary>
        /// 采购单号
        /// </summary>
        //public string PurchaseID { get; set; }

        /// <summary>
        /// 合同号
        /// </summary>
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
        /// A-大货入库； B-返修入库； C-调拨入库； D-RMA入库； E-渠道退货； F-库内返架
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// 该箱的上架明细
        /// </summary>
        public PutawayItemViewEntity[] ItemList { get; set; }

        /// <summary>
        /// 返回值
        /// </summary>
        public bool Success { get; set; }

        /// <summary>
        /// 返回值对应的信息
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// A - 人工上架(默认值)；B - 按策略上架
        /// </summary>
        //public string Manual { get; set; }

        /// <summary>
        /// A - 拆零；B - 整托盘；C - 整箱；D - 无效
        /// </summary>
        public string Unbox { get; set; }

        /// <summary>
        /// A - 待上架；B - 上架中； C - 上架结束；D - 无效；E - 异常上架；X - 写入中；Y - 策略待运行； Z - 策略运行中
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// 当前操作人
        /// </summary>
        public string InUser { get; set; }

        #endregion
    }
}
