namespace SCM.RF.Client.BizEntities.BasicData.XPal
{
    /// <summary>
    /// 容器库存
    /// </summary>
    public class XPalViewEntity
    {
        public int SysNo { get; set; }
        /// <summary>
        /// 1 - 周转箱/笼类容器； 2 - 托盘类容器；3 - 袋式包装；4 - 盒/箱式包装；
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// 容器编码
        /// </summary>
        public int ItemSysNo { get; set; }

        /// <summary>
        /// 容器编码
        /// </summary>
        public string ItemID { get; set; }
        public string Name { get; set; }
        public int ProductSysNo { get; set; }
        public string BarCode { get; set; }
        public int QTY { get; set; }
        public int Sick { get; set; }
        public string EditUser { get; set; }
    }
}
