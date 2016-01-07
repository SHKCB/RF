
namespace SCM.RF.Client.BizEntities.AuthCenter
{
    public class UserViewEntity
    {
        /// <summary>
        /// 构造
        /// </summary>
        public UserViewEntity() { }


        public int UserID { get; set; }

        /// <summary>
        /// 登录名
        /// </summary>
        public string WkNo { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// 客户端IP地址
        /// </summary>
        public string LocalIP { get; set; }

        /// <summary>
        /// 系统号
        /// </summary>
        public string ApplicationID { get; set; }

        /// <summary>
        /// 当前登录状态
        /// </summary>
        public bool IsLoggedIn { get; set; }

        /// <summary>
        /// 权限列表
        /// </summary>
        public UserRightViewEntity[] ItemList { get; set; }
    }
}
