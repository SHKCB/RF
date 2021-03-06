﻿
namespace SCM.RF.Server.BizEntities.Sys
{
    public class BaseViewEntity
    {
        public string TID { get; set; }

        public string CID { get; set; }

        public string UName { get; set; }

        public string PWD { get; set; }

        /// <summary>
        /// 设备号
        /// </summary>
        public string Device { get; set; }

        /// <summary>
        /// 仓库号
        /// </summary>
        public string WareHouseId { get; set; }

        /// <summary>
        /// 返回值
        /// </summary>
        public bool Success
        {
            get;
            set;
        }

        /// <summary>
        /// 返回值对应的信息
        /// </summary>
        public string Message
        {
            get;
            set;
        }
    }
}
