namespace SCM.RF.Client.BizEntities.BasicData.Cell
{
    /// <summary>
    /// 库位信息
    /// </summary>
    public class CellViewEntity
    {
        public CellViewEntity() { }

        /// <summary>
        /// 主键
        /// </summary>
        public int SysNo { get; set; }

        /// <summary>
        /// 库位
        /// </summary>
        public string CellNO { get; set; }

        /// <summary>
        /// 库位类型 1-拆零拣货区；2-整箱拣货区；3-存储区；4-周转区；5-限制出货区；6-不良品待退厂区；7不良品报废区
        /// </summary>
        public string CellUse { get; set; }

        /// <summary>
        /// 0-空载；1-部分载货；2-满载；9-禁用；D - 无效（删除状态）
        /// </summary>
        public string Status { get; set; }

        public bool Success { get; set; }

        public string Message { get; set; }
    }
}
