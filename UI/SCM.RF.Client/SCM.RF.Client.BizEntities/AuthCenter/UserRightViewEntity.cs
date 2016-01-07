using System;

namespace SCM.RF.Client.BizEntities.AuthCenter
{
    public class UserRightViewEntity
    {
        public UserRightViewEntity() { }

        public int SysNo { get; set; }

        /// <summary>
        /// 1级页面值
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 一级页面名称
        /// </summary>
        public string Category { get; set; }

        /// <summary>
        /// 二级页面名称
        /// </summary>
        public string Page { get; set; }

        /// <summary>
        /// 子级页面
        /// </summary>
        public string Key { get; set; }
    }
}
