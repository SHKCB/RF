
using SCM.RF.Client.BizEntities.Sys;
namespace SCM.RF.Client.BizEntities.AuthCenter
{
    public class UserViewEntity : BaseViewEntity
    {
        /// <summary>
        /// 构造
        /// </summary>
        public UserViewEntity() { }

        /// <summary>
        /// 用户真名
        /// </summary>
        public string RealName { get; set; }

        /// <summary>
        /// 客户端IP地址
        /// </summary>
        public string LocalIP { get; set; }

        /// <summary>
        /// 当前登录状态
        /// </summary>
        public bool IsLoggedIn { get; set; }
    }
}
