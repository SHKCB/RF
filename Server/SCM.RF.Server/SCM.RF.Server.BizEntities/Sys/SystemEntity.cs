/*
 * 系统配置
 * Add by [火狐] [2012-3-5]
 * Edit by [花名] [时间] [原因]
 */

namespace SCM.RF.Server.BizEntities.Sys
{
    /// <summary>
    /// 系统配置
    /// </summary>
    public class SystemEntity
    {
        public string wsurl
        {
            get;
            set;
        }

        /// <summary>
        /// 日志路径
        /// </summary>
        public string LogPath
        {
            get;
            set;
        }

        /// <summary>
        /// IP
        /// </summary>
        public string ServerIP
        {
            get;
            set;
        }

        /// <summary>
        /// 端口号
        /// </summary>
        public int Port
        {
            get;
            set;
        }
    }
}
