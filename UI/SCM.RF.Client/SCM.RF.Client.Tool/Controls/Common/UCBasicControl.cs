using System.Windows.Forms;
using SCM.RF.Client.BizEntities.Sys;
using SCM.RF.Client.Framework.Core;
using SCM.RF.Client.BizEntities.AuthCenter;

namespace SCM.RF.Client.Tool.Controls.Common
{
    public partial class UCBasicControl : UserControl
    {
        #region PRIVATE MEMBER

        /// <summary>
        /// 父级页面
        /// </summary>
        private RF _RF;

        /// <summary>
        /// 服务器长连接
        /// </summary>
        private RemoteServer _RemoteServer;

        /// <summary>
        /// 用户信息
        /// </summary>
        private UserViewEntity _UserViewEntity;

        private EnHookType _EnHookType;

        #endregion

        #region 构造函数

        public UCBasicControl()
        {
            InitializeComponent();
        }

        public UCBasicControl(RF rf)
        {
            this._RF = rf;

            InitializeComponent();

            this.ucMessageBox.MessageEvent += new UCMessageBox.MessageEventHandler(ucMessageBox_MessageEvent);
        }

        #endregion

        #region PUBLIC MEMBER

        /// <summary>
        /// 服务器长连接
        /// </summary>
        public RemoteServer RemoteServer
        {
            get { return this._RemoteServer; }
            set { this._RemoteServer = value; }
        }

        /// <summary>
        /// 用户实体
        /// </summary>
        public UserViewEntity UserView
        {
            get { return this._UserViewEntity; }
            set { this._UserViewEntity = value; }
        }

        public EnHookType HookType
        {
            get { return this._EnHookType; }
            set { this._EnHookType = value; }
        }

        /// <summary>
        /// 主界面
        /// </summary>
        public RF RF { get { return this._RF; } }

        #endregion

        #region PUBLIC FUNCTION

        /// <summary>
        /// 初始化数据通讯
        /// </summary>
        /// <param name="server"></param>
        /// <param name="user"></param>
        public virtual void Init(RemoteServer server, UserViewEntity user)
        {
            this._RemoteServer = server;

            this._UserViewEntity = user;
        }

        /// <summary>
        /// 自定义初始化
        /// </summary>
        public virtual void Init()
        {

        }

        /// <summary>
        /// 初始化快捷键类型
        /// </summary>
        public virtual void Init(EnHookType hookType)
        {
            this._EnHookType = hookType;

            this.SetHookType(hookType);
        }

        /// <summary>
        /// 对话框点击确认
        /// </summary>
        public virtual void Proc(EnMessageType type)
        {

        }

        /// <summary>
        /// 退出到登录页面
        /// </summary>
        public virtual void Exit()
        {
            this._RF.Exit();
        }

        /// <summary>
        /// 返回到目录页面
        /// </summary>
        public virtual void Cancel()
        {
            this._RF.Cancel();
        }

        /// <summary>
        /// 开启 禁用 按钮
        /// </summary>
        /// <param name="value"></param>
        public virtual void DisableButton(bool value)
        {
            //foreach (Control control in this.Controls)
            //{
            //    if (control.Tag != null && control.Tag.Equals("True"))
            //    {
            //        control.Enabled = value;
            //    }
            //}
        }

        /// <summary>
        /// 设置标题
        /// </summary>
        /// <param name="title"></param>
        public virtual void SetTitle(string title)
        {
            this._RF.SetTitle(title);
        }

        /// <summary>
        /// 设置快捷方式
        /// </summary>
        /// <param name="hookType"></param>
        public virtual void SetHookType(EnHookType hookType)
        {
            this._RF.SetHookType(hookType);
        }

        #endregion

        #region 信息框
        /// <summary>
        /// 显示提示信息
        /// </summary>
        /// <param name="message"></param>
        /// <param name="choise"></param>
        public virtual void ShowMessage(string message, bool choise, EnMessageType type)
        {
            this.DisableButton(false);
            this.ucMessageBox.Visible = true;
            this.ucMessageBox.BringToFront();
            this.SetHookType(EnHookType.Default);
            this.ucMessageBox.Init(message, choise, type);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="message">提示信息</param>
        /// <param name="choise">是否具有选择框</param>
        /// <param name="type">类型</param>
        /// <param name="sound">正确/错误的声音</param>
        public virtual void ShowMessage(string message, bool choise, EnMessageType type, bool sound)
        {
            this.RF.PlaySound(sound);
            this.DisableButton(false);
            this.ucMessageBox.Visible = true;
            this.ucMessageBox.BringToFront();
            this.SetHookType(EnHookType.Default);
            this.ucMessageBox.Init(message, choise, type);
        }

        /// <summary>
        /// 隐藏消息框
        /// </summary>
        public virtual void HideMessage(bool param, EnMessageType type)
        {
            this.DisableButton(true);

            this.ucMessageBox.Visible = false;

            Init(this._EnHookType);

            if (param)
            {
                Proc(type);
            }
            else
            {
                Init();
            }
        }

        #endregion

        #region PRIVATE FUNCTION

        private void ucMessageBox_MessageEvent(bool param, EnMessageType type)
        {
            HideMessage(param, type);
        }
        #endregion
    }
}
