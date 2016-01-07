namespace SCM.RF.Client.BizEntities.HandOver
{
    public class HOViewEntity
    {
        public HOViewEntity() { }

        /// <summary>
        /// 主键
        /// </summary>
        public int SysNo { get; set; }

        /// <summary>
        /// 交接单号
        /// </summary>
        public string HOID { get; set; }

        /// <summary>
        /// 方案主键
        /// </summary>
        public int SchemeSysNo { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 缩写
        /// </summary>
        public string Key { get; set; }

        /// <summary>
        /// 交接人
        /// </summary>
        public string InUser { get; set; }

        public string Status { get; set; }

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
