namespace SCM.RF.Client.BizEntities.HandOver
{
    /// <summary>
    /// 快递方案
    /// </summary>
    public class SchemeViewEntity
    {
        public int SysNo { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 缩写
        /// </summary>
        public string Key { get; set; }

        public SchemeItemViewEntity[] ItemList { get; set; }

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
