
namespace SCM.RF.Client.BizEntities.AuthCenter
{
    public class UserViewEntity
    {
        /// <summary>
        /// 构造
        /// </summary>
        public UserViewEntity() { }

        /// <summary>
        /// 用户帐号
        /// </summary>
        public string UserID { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// 用户真名
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// 客户端IP地址
        /// </summary>
        public string LocalIP { get; set; }

        /// <summary>
        /// 系统号
        /// </summary>
        public string CID { get; set; }

        /// <summary>
        /// 设备
        /// </summary>
        public string Device { get; set; }

        /// <summary>
        /// 当前登录状态
        /// </summary>
        public bool IsLoggedIn { get; set; }

        /// <summary>
        /// 登录返回信息
        /// </summary>
        public string WareHouseId { get; set; }
    }
}
