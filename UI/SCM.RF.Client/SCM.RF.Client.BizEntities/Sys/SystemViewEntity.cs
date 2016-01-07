using System;

namespace SCM.RF.Client.BizEntities.Sys
{
    public class SystemViewEntity
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public SystemViewEntity() { }

        /// <summary>
        /// IP地址
        /// </summary>
        public string ServerIp { get; set; }

        /// <summary>
        /// 端口号
        /// </summary>
        public int ServerPort { get; set; }

        /// <summary>
        /// 设备
        /// </summary>
        public string Device { get; set; }

        /// <summary>
        /// 仓库号
        /// </summary>
        public string CID { get; set; }

        /// <summary>
        /// 最后更新时间
        /// </summary>
        public string UpDate { get; set; }

        /// <summary>
        /// 更新地址
        /// </summary>
        public string UpUrl { get; set; }

        /// <summary>
        /// 更新程序的路径
        /// </summary>
        public string UpExe { get; set; }

        /// <summary>
        /// 正确声音
        /// </summary>
        public string SoundOK { get; set; }

        /// <summary>
        /// 错误声音
        /// </summary>
        public string SoundError { get; set; }
    }
}
