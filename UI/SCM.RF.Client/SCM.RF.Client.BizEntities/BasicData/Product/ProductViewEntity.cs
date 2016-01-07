using System;

namespace SCM.RF.Client.BizEntities.BasicData.Product
{
    /// <summary>
    /// 商品缓存实体
    /// </summary>
    /// 
    public class ProductViewEntity
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public ProductViewEntity() { }

        /// <summary>
        /// 商品主键
        /// </summary>
        public int SysNo
        {
            get;
            set;
        }

        /// <summary>
        /// 条码
        /// </summary>
        public string BarCode
        {
            get;
            set;
        }

        /// <summary>
        /// 商品名称
        /// </summary>
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        /// 尺码
        /// </summary> 
        public string Size
        {
            get;
            set;
        }

        /// <summary>
        /// 颜色
        /// </summary>
        public string Color
        {
            get;
            set;
        }

        /// <summary>
        /// 是否启用SN 0 - 默认； 1 - 序列号管理； 2 - 非序列号管理；
        /// </summary>
        public string Serial
        {
            get;
            set;
        }

        /// <summary>
        /// 体积
        /// </summary>
        //public decimal Volume
        //{
        //    get;
        //    set;
        //}

        public bool Success { get; set; }

        public string Message { get; set; }
    }
}
