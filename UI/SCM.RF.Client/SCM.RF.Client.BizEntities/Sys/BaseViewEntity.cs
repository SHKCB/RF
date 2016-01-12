using System;

namespace SCM.RF.Client.BizEntities.Sys
{
    public class BaseViewEntity
    {
        private string _TID;

        public BaseViewEntity() { }

        /// <summary>
        /// 唯一序列号，用时间表示
        /// </summary>
        public string TID
        {
            get
            {
                this._TID = DateTime.Now.ToString("yyyyMMddHHmmssfff");
                return this._TID;
            }
            set
            {
                value = _TID;
            }
        }

        /// <summary>
        /// 配置值
        /// </summary>
        public string CID { get; set; }

        /// <summary>
        /// 帐号
        /// </summary>
        public string UName { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
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
