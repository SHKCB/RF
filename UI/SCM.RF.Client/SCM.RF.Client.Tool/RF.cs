using System;
using System.Collections;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using SCM.RF.Client.Framework.Core;
using SCM.RF.Client.BizEntities.AuthCenter;
using SCM.RF.Client.Utility;
using SCM.RF.Client.BizProcess.Sys;
using SCM.RF.Client.BizEntities.Sys;
//using SCM.RF.Client.BizEntities.HandOver;
//using SCM.RF.Client.BizEntities.Picking;
//using SCM.RF.Client.BizEntities.Sys;
//using SCM.RF.Client.BizProcess.Sys;
//using SCM.RF.Client.Framework.Core;
//using SCM.RF.Client.Tool.Controls.PutAway;
//using SCM.RF.Client.Utility;
//using Justyle.WMS.RF.Server.BizEntities.Putaway;

namespace SCM.RF.Client.Tool
{
    public partial class RF : Form
    {
        #region 控件

        /// <summary>
        /// 登录
        /// </summary>
        private SCM.RF.Client.Tool.Controls.Login.UCLogin ucLogin;
        /// <summary>
        /// 设置
        /// </summary>
        private SCM.RF.Client.Tool.Controls.Login.UCSetting ucSetting;
        /// <summary>
        /// 目录
        /// </summary>
        private SCM.RF.Client.Tool.Controls.Login.UCMenu ucMenu;
        /// <summary>
        /// 收货主界面
        /// </summary>
        private SCM.RF.Client.Tool.Controls.Receive.UCReceiveMain ucReceive;

        /// <summary>
        /// 拣货1级页面
        /// </summary>
        private SCM.RF.Client.Tool.Controls.Picking.UCPicking1 ucPicking1;
        //private SCM.RF.Client.Tool.Controls.Picking.UCPicking2 ucPicking2;
        //private SCM.RF.Client.Tool.Controls.Picking.UCPicking3 ucPicking3;


        #endregion

        #region 私有变量

        /// <summary>
        /// 定时器
        /// </summary>
        private System.Windows.Forms.Timer myTimer;

        /// <summary>
        /// 热键
        /// </summary>
        //private HookKeyHelper HookKeyHelper = new HookKeyHelper();

        /// <summary>
        /// 热键类型
        /// </summary>
        private EnHookType HookType = EnHookType.Default;

        /// <summary>
        /// 正确的声音
        /// </summary>
        private SoundHelper soundOK = new SoundHelper(string.Concat(Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase), InstanceBP.SystemInstance.SoundOK));

        /// <summary>
        /// 错误的声音
        /// </summary>
        private SoundHelper soundError = new SoundHelper(string.Concat(Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase), InstanceBP.SystemInstance.SoundError));

        #endregion

        public RF()
        {
            InitializeComponent();

            this.myTimer = new Timer();

            this.myTimer.Enabled = true;
            this.myTimer.Interval = 30000;
            this.myTimer.Tick += new EventHandler(myTimer_Tick);
        }

        #region PUBLIC MEMBER

        /// <summary>
        /// 服务器长连接
        /// </summary>
        public RemoteServer RemoteServer { get; set; }

        /// <summary>
        /// 用户实体
        /// </summary>
        public UserViewEntity UserViewEntity { get; set; }

        /// <summary>
        /// 是否需要探测
        /// </summary>
        public bool KeepAlive { get; set; }

        #endregion

        #region PUBLIC FUNCTION

        #region 其他

        /// <summary>
        /// 设置标题
        /// </summary>
        /// <param name="title"></param>
        public void SetTitle(string title)
        {
            this.lbAction.Text = string.Format("当前操作：{0}", title);
        }

        /// <summary>
        /// 设置快捷键类型
        /// </summary>
        /// <param name="type"></param>
        public void SetHookType(EnHookType hookType)
        {
            this.HookType = hookType;
        }

        /// <summary>
        /// 设置用户名
        /// </summary>
        /// <param name="username"></param>
        public void SetUser(string username)
        {
            this.lbUserName.Text = username;

            this.KeepAlive = true;
        }

        /// <summary>
        /// 关闭输入法
        /// </summary>
        public void SetIME()
        {
            //this.inputPanel.Enabled = false;
        }

        /// <summary>
        /// 播放声音
        /// </summary>
        public void PlaySound(bool ok)
        {
            if (ok)
            {
                //this.soundOK.Play();
            }
            else
            {
                //this.soundError.Play();
            }
        }

        #endregion

        #region 登录框

        /// <summary>
        /// 显示登录框
        /// </summary>
        /// <param name="message"></param>
        /// <param name="choise"></param>
        public void ShowLogin()
        {
            if (this.Controls.IndexOf(this.ucLogin) < 0)
            {
                this.ucLogin = new SCM.RF.Client.Tool.Controls.Login.UCLogin(this);
                this.ucLogin.Location = new System.Drawing.Point(10, 30);
                this.ucLogin.Name = "ucLogin";
                this.ucLogin.Size = new System.Drawing.Size(300, 260);
                this.ucLogin.TabIndex = 1;
                this.ucLogin.TabStop = false;
                this.Controls.Add(this.ucLogin);
            }
            this.ucLogin.Visible = true;
            this.ucLogin.BringToFront();
            this.ucLogin.Init(EnHookType.A);
            this.ucLogin.Init();
        }

        /// <summary>
        /// 隐藏登录框
        /// </summary>
        public void HideLogin()
        {
            if (this.ucLogin != null && this.Controls.IndexOf(this.ucLogin) > -1)
            {
                this.ucLogin.Visible = false;
                this.ucLogin = null;
                this.Controls.Remove(this.ucLogin);
            }
        }

        #endregion

        #region 1、收货

        /// <summary>
        /// 显示收货框
        /// </summary>
        /// <param name="message"></param>
        /// <param name="choise"></param>
        public void ShowReceive()
        {
            if (this.Controls.IndexOf(this.ucReceive) < 0)
            {
                this.ucReceive = new SCM.RF.Client.Tool.Controls.Receive.UCReceiveMain(this);
                this.ucReceive.Location = new System.Drawing.Point(10, 30);
                this.ucReceive.Name = "ucReceive";
                this.ucReceive.Size = new System.Drawing.Size(300, 260);
                this.ucReceive.TabIndex = 1;
                this.ucReceive.TabStop = false;
                this.Controls.Add(this.ucReceive);
            }
            this.ucReceive.Visible = true;
            this.ucReceive.BringToFront();
            this.ucReceive.Init(EnHookType.D1);
            this.ucReceive.Init(this.RemoteServer, this.UserViewEntity);
            this.ucReceive.Init();
        }

        /// <summary>
        /// 隐藏收货框
        /// </summary>
        public void HideReceive()
        {
            if (this.ucReceive != null && this.Controls.IndexOf(this.ucReceive) > -1)
            {
                this.ucReceive.Visible = false;
                this.ucReceive = null;
                this.Controls.Remove(this.ucReceive);
            }
        }

        #endregion

        #region 2、定位

        #endregion

        #region 3、上架

        #endregion

        #region 4、拣货

        /// <summary>
        /// 显示拣货
        /// </summary>
        /// <param name="message"></param>
        /// <param name="choise"></param>
        public void ShowPicking1()
        {
            if (this.Controls.IndexOf(this.ucPicking1) < 0)
            {
                this.ucPicking1 = new SCM.RF.Client.Tool.Controls.Picking.UCPicking1(this);
                this.ucPicking1.Location = new System.Drawing.Point(10, 30);
                this.ucPicking1.Name = "ucPicking1";
                this.ucPicking1.Size = new System.Drawing.Size(300, 260);
                this.ucPicking1.TabIndex = 1;
                this.ucPicking1.TabStop = false;
                this.Controls.Add(this.ucPicking1);
            }
            this.ucPicking1.Visible = true;
            this.ucPicking1.BringToFront();
            this.ucPicking1.Init(EnHookType.G1);
            this.ucPicking1.Init(this.RemoteServer, this.UserViewEntity);
            this.ucPicking1.Init();
        }

        /// <summary>
        /// 隐藏拣货
        /// </summary>
        public void HidePicking1()
        {
            if (this.ucPicking1 != null && this.Controls.IndexOf(this.ucPicking1) > -1)
            {
                this.ucPicking1.Visible = false;
                this.ucPicking1 = null;
                this.Controls.Remove(this.ucPicking1);
            }
        }

        #endregion

        #region 5、移库

        #endregion


        #region 设置

        /// <summary>
        /// 显示登录框
        /// </summary>
        /// <param name="message"></param>
        /// <param name="choise"></param>
        public void ShowSetting()
        {
            if (this.Controls.IndexOf(this.ucSetting) < 0)
            {
                this.ucSetting = new SCM.RF.Client.Tool.Controls.Login.UCSetting(this);
                this.ucSetting.Location = new System.Drawing.Point(10, 30);
                this.ucSetting.Name = "ucSetting";
                this.ucSetting.Size = new System.Drawing.Size(300, 260);
                this.ucSetting.TabIndex = 2;
                this.ucSetting.TabStop = false;
                this.Controls.Add(this.ucSetting);
            }
            this.ucSetting.Visible = true;
            this.ucSetting.BringToFront();
            this.ucSetting.Init(EnHookType.C);
            this.ucSetting.Init();
        }

        /// <summary>
        /// 隐藏登录框
        /// </summary>
        public void HideSetting()
        {
            if (this.ucSetting != null && this.Controls.IndexOf(this.ucSetting) > -1)
            {
                this.ucSetting.Visible = false;
                this.ucSetting = null;
                this.Controls.Remove(this.ucSetting);
            }
        }

        #endregion

        #region 目录

        /// <summary>
        /// 显示目录
        /// </summary>
        /// <param name="message"></param>
        /// <param name="choise"></param>
        public void ShowMenu()
        {
            if (this.Controls.IndexOf(this.ucMenu) < 0)
            {
                this.ucMenu = new SCM.RF.Client.Tool.Controls.Login.UCMenu(this);
                this.ucMenu.Location = new System.Drawing.Point(10, 30);
                this.ucMenu.Name = "ucMenu";
                this.ucMenu.Size = new System.Drawing.Size(300, 260);
                this.ucMenu.TabIndex = 3;
                this.ucMenu.TabStop = false;
                this.Controls.Add(this.ucMenu);
            }
            this.ucMenu.Visible = true;
            this.ucMenu.BringToFront();
            this.ucMenu.Init(this.RemoteServer, this.UserViewEntity);
            this.ucMenu.Init(EnHookType.B);
            this.ucMenu.LoadData();
            this.ucMenu.Init();
        }

        /// <summary>
        /// 隐藏登录框
        /// </summary>
        public void HideMenu()
        {
            if (this.ucMenu != null && this.Controls.IndexOf(this.ucMenu) > -1)
            {
                this.ucMenu.Visible = false;
                this.ucMenu = null;
                this.Controls.Remove(this.ucMenu);
            }
        }

        #endregion

        #region 返回

        /// <summary>
        /// 退到登录界面
        /// </summary>
        public void Exit()
        {
            this.RemoteServer = null;

            this.UserViewEntity = null;

            this.lbUserName.Text = string.Empty;

            this.KeepAlive = false;

            this.HideMenu();

            this.Remove();

            this.ShowLogin();
        }

        /// <summary>
        /// 返回到目录
        /// </summary>
        public void Cancel()
        {
            this.Remove();

            this.ShowMenu();
        }

        /// <summary>
        /// 关闭系统
        /// </summary>
        public new void Close()
        {
            this.RemoteServer = null;

            this.UserViewEntity = null;

            this.lbUserName.Text = string.Empty;

            this.KeepAlive = false;

            //this.HookKeyHelper = null;

            Application.Exit();
        }

        #endregion

        #endregion

        #region PRIVATE FUNCTION

        private void RF_Load(object sender, System.EventArgs e)
        {
            this.KeepAlive = false;

            //HookKeyHelper.KeyEvent += new HookKeyHelper.KeyEventHandler(HookKeyHelper_KeyEvent);

            //隐藏窗体边框
            //this.FormBorderStyle = FormBorderStyle.None;

            // WinceHelper.HoldTaskBar();

            this.ShowLogin();
        }

        /// <summary>
        /// 快捷键
        /// </summary>
        /// <param name="KeyValue"></param>
        private void HookKeyHelper_KeyEvent(int KeyValue)
        {
            //登录界面
            if (this.HookType == EnHookType.A)
            {
                switch (KeyValue)
                {
                    #region 快捷键

                    case 112: this.ucLogin.HookLogin(); break;//F1
                    case 115: this.ucLogin.HookReset(); break;//F4
                    case 117: this.ucLogin.HookSetting(); break;//F6
                    default: break;

                    #endregion
                }
            }

            //设置界面
            else if (this.HookType == EnHookType.C)
            {
                switch (KeyValue)
                {
                    #region 快捷键

                    case 112: this.ucSetting.HookExit(); break;//F1
                    case 116: this.ucSetting.HookSave(); break;//F5
                    default: break;

                    #endregion
                }
            }

            //目录
            else if (this.HookType == EnHookType.B)
            {
                switch (KeyValue)
                {
                    #region 快捷键

                    case 112: this.ucMenu.HookExit(); break;//F1
                    default: break;

                    #endregion
                }
            }

            //收货1
            else if (this.HookType == EnHookType.D1)
            {
                switch (KeyValue)
                {
                    #region 快捷键

                    case 115: this.ucReceive.HookExit(); break;//F4
                    //case 116: this.ucReceive1.HookSearch(); break;//F5
                    //case 117: this.ucReceive1.HookReceive(); break;//F6
                    default: break;

                    #endregion
                }
            }

            //收货2
            else if (this.HookType == EnHookType.D2)
            {
                switch (KeyValue)
                {
                    #region 快捷键

                    //case 112: this.ucReceive2.HookExit(); break;//F1
                    //case 113: this.ucReceive2.HookProv(); break;//F2
                    //case 114: this.ucReceive2.HookNext(); break;//F3
                    //case 115: this.ucReceive2.HookDelete(); break;//F4
                    //case 120: this.ucReceive2.HookPrint(); break;//F9
                    //case 121: this.ucReceive2.HookSave(); break;//F10
                    default: break;

                    #endregion
                }
            }

            //清点1
            else if (this.HookType == EnHookType.E1)
            {
                switch (KeyValue)
                {
                    #region 快捷键

                    //case 112: this.ucInBound1.HookExit(); break;//F1
                    default: break;

                    #endregion
                }
            }

            //清点2
            else if (this.HookType == EnHookType.E2)
            {
                switch (KeyValue)
                {
                    #region 快捷键

                    //case 112: this.ucInBound2.HookExit(); break;//F1
                    default: break;

                    #endregion
                }
            }

            //清点3
            else if (this.HookType == EnHookType.E3)
            {
                switch (KeyValue)
                {
                    #region 快捷键

                    //case 112: this.ucInBound3.HookExit(); break;//F1
                    //case 113: this.ucInBound3.HookDefault(); break;//F2
                    //case 114: this.ucInBound3.HookSearch(); break;//F3
                    //case 115: this.ucInBound3.HookReset(); break;//F4
                    //case 116: this.ucInBound3.HookUnboxing(); break;//F5
                    //case 120: this.ucInBound3.HookPrint(); break;//F9
                    //case 121: this.ucInBound3.HookSave(); break;//F10
                    default: break;

                    #endregion
                }
            }

            //拆箱1
            else if (this.HookType == EnHookType.E4)
            {
                switch (KeyValue)
                {
                    #region 快捷键

                    //case 112: this.ucInBound4.HookExit(); break;//F1
                    default: break;

                    #endregion
                }
            }

            //拆箱2
            else if (this.HookType == EnHookType.E5)
            {
                switch (KeyValue)
                {
                    #region 快捷键

                    //case 112: this.ucInBound5.HookExit(); break;//F1
                    //case 113: this.ucInBound5.HookDefault(); break;//F2
                    //case 114: this.ucInBound5.HookSearch(); break;//F3
                    //case 115: this.ucInBound5.HookReset(); break;//F4
                    //case 121: this.ucInBound5.HookSave(); break;//F10
                    default: break;

                    #endregion
                }
            }

            //清点6 商品列表
            else if (this.HookType == EnHookType.E6)
            {
                switch (KeyValue)
                {
                    #region 快捷键

                    //case 112: this.ucProduct.HookExit(); break;//F1
                    //case 113: this.ucProduct.HookProv(); break;//F2
                    //case 114: this.ucProduct.HookNext(); break;//F3
                    //case 115: this.ucProduct.HookDelete(); break;//F4
                    default: break;

                    #endregion
                }
            }

            //上架1
            else if (this.HookType == EnHookType.F1)
            {
                switch (KeyValue)
                {
                    #region 快捷键

                    //case 112: this.ucPutaway1.HookExit(); break;//F1
                    default: break;

                    #endregion
                }
            }

            //上架2
            else if (this.HookType == EnHookType.F2)
            {
                switch (KeyValue)
                {
                    #region 快捷键

                    //case 112: this.ucPutaway2.HookExit(); break;//F1
                    default: break;

                    #endregion
                }
            }

            //上架3
            else if (this.HookType == EnHookType.F3)
            {
                switch (KeyValue)
                {
                    #region 快捷键

                    //case 112: this.ucPutaway3.HookExit(); break;//F1
                    //case 121: this.ucPutaway3.HookSave(); break;//F10
                    default: break;

                    #endregion
                }
            }

            //拣货1
            else if (this.HookType == EnHookType.G1)
            {
                switch (KeyValue)
                {
                    #region 快捷键

                    //case 112: this.ucPicking1.HookExit(); break;//F1
                    default: break;

                    #endregion
                }
            }

            //拣货2
            else if (this.HookType == EnHookType.G2)
            {
                switch (KeyValue)
                {
                    #region 快捷键

                    //case 112: this.ucPicking2.HookExit(); break;//F1
                    //case 113: this.ucPicking2.HookProv(); break;//F2
                    //case 114: this.ucPicking2.HookNext(); break;//F3
                    //case 115: this.ucPicking2.HookDad(); break;//F4
                    //case 116: this.ucPicking2.HookDetail(); break;//F5
                    //case 121: this.ucPicking2.HookSave(); break;//F10
                    default: break;

                    #endregion
                }
            }

            //拣货3
            else if (this.HookType == EnHookType.G3)
            {
                switch (KeyValue)
                {
                    #region 快捷键
                    //case 112: this.ucPicking3.HookExit(); break;//F1
                    //case 114: this.ucPicking3.HookReset(); break;//F3
                    //case 116: this.ucPicking3.HookDetail(); break;//F5
                    //case 117: this.ucPicking3.HookSearch(); break;//F6
                    //case 121: this.ucPicking3.HookBad(); break;//F10
                    default: break;

                    #endregion
                }
            }

            //盘点目录
            else if (this.HookType == EnHookType.H1)
            {
                switch (KeyValue)
                {
                    #region 快捷键
                    //case 112: this.ucStocktaking.HookExit(); break;//F1
                    default: break;

                    #endregion
                }
            }

            //人工盘点
            else if (this.HookType == EnHookType.H2)
            {
                switch (KeyValue)
                {
                    #region 快捷键
                    //case 112: this.ucStocktakUser.HookExit(); break;//F1
                    //case 114: this.ucStocktakUser.HookHty(); break;//F3
                    //case 116: this.ucStocktakUser.HookDetail(); break;//F5
                    //case 117: this.ucStocktakUser.HookSearch(); break;//F6
                    //case 121: this.ucStocktakUser.HookSave(); break;//F10
                    default: break;

                    #endregion
                }
            }

            //任务盘点1
            else if (this.HookType == EnHookType.H3)
            {
                switch (KeyValue)
                {
                    #region 快捷键
                    //case 112: this.ucStocktakSystem1.HookExit(); break;//F1
                    default: break;

                    #endregion
                }
            }

            //任务盘点2
            else if (this.HookType == EnHookType.H4)
            {
                switch (KeyValue)
                {
                    #region 快捷键
                    //case 112: this.ucStocktakSystem2.HookExit(); break;//F1
                    //case 113: this.ucStocktakSystem2.HookProv(); break;//F2
                    //case 114: this.ucStocktakSystem2.HookNext(); break;//F3
                    //case 115: this.ucStocktakSystem2.HookReset(); break;//F4
                    //case 116: this.ucStocktakSystem2.HookDetail(); break;//F5
                    //case 117: this.ucStocktakSystem2.HookSearch(); break;//F6
                    //case 120: this.ucStocktakSystem2.HookHty(); break;//F9
                    //case 121: this.ucStocktakSystem2.HookSave(); break;//F10
                    default: break;

                    #endregion
                }
            }

            //盘点日志
            else if (this.HookType == EnHookType.H5)
            {
                switch (KeyValue)
                {
                    #region 快捷键
                    //case 112: this.ucStocktakLog.HookExit(); break;//F1
                    //case 113: this.ucStocktakLog.HookProv(); break;//F2
                    //case 114: this.ucStocktakLog.HookNext(); break;//F3
                    //case 115: this.ucStocktakLog.HookDelete(); break;//F4
                    default: break;

                    #endregion
                }
            }

            //移库目录
            else if (this.HookType == EnHookType.I1)
            {
                switch (KeyValue)
                {
                    #region 快捷键
                    //case 112: this.ucTransfer.HookExit(); break;//F1
                    default: break;

                    #endregion
                }
            }

            //人工下架1
            else if (this.HookType == EnHookType.I2)
            {
                switch (KeyValue)
                {
                    #region 快捷键
                    //case 112: this.ucTransferUserDirected1.HookExit(); break;//F1
                    default: break;

                    #endregion
                }
            }

            //人工下架2
            else if (this.HookType == EnHookType.I3)
            {
                switch (KeyValue)
                {
                    #region 快捷键
                    //case 112: this.ucTransferUserDirected2.HookExit(); break;//F1
                    //case 114: this.ucTransferUserDirected2.HookHty(); break;//F3
                    //case 116: this.ucTransferUserDirected2.HookDetail(); break;//F5
                    //case 121: this.ucTransferUserDirected2.HookSave(); break;//F10
                    default: break;

                    #endregion
                }
            }

             //人工下架日志
            else if (this.HookType == EnHookType.I4)
            {
                switch (KeyValue)
                {
                    #region 快捷键
                    //case 112: this.ucTransferLog.HookExit(); break;//F1
                    //case 113: this.ucTransferLog.HookProv(); break;//F2
                    //case 114: this.ucTransferLog.HookNext(); break;//F3
                    //case 115: this.ucTransferLog.HookDelete(); break;//F4
                    default: break;

                    #endregion
                }
            }

            //任务下架1
            else if (this.HookType == EnHookType.I5)
            {
                switch (KeyValue)
                {
                    #region 快捷键
                    //case 112: this.ucTransferSysDirected1.HookExit(); break;//F1
                    default: break;

                    #endregion
                }
            }

            //任务下架2
            else if (this.HookType == EnHookType.I6)
            {
                switch (KeyValue)
                {
                    #region 快捷键
                    //case 112: this.ucTransferSysDirected2.HookExit(); break;//F1
                    //case 113: this.ucTransferSysDirected2.HookProv(); break;//F2
                    //case 114: this.ucTransferSysDirected2.HookNext(); break;//F3
                    //case 115: this.ucTransferSysDirected2.HookChange(); break;//F4
                    //case 116: this.ucTransferSysDirected2.HookDetail(); break;//F5
                    //case 117: this.ucTransferSysDirected2.HookHty(); break;//F6
                    //case 121: this.ucTransferSysDirected2.HookSave(); break;//F10
                    default: break;

                    #endregion
                }
            }

            //任务下架日志
            else if (this.HookType == EnHookType.I7)
            {
                switch (KeyValue)
                {
                    #region 快捷键
                    //case 112: this.ucTransferLog2.HookExit(); break;//F1
                    //case 113: this.ucTransferLog2.HookProv(); break;//F2
                    //case 114: this.ucTransferLog2.HookNext(); break;//F3
                    //case 115: this.ucTransferLog2.HookDelete(); break;//F4
                    default: break;

                    #endregion
                }
            }

            //上架1
            else if (this.HookType == EnHookType.I8)
            {
                switch (KeyValue)
                {
                    #region 快捷键
                    //case 112: this.ucTransferPutaway1.HookExit(); break;//F1
                    default: break;

                    #endregion
                }
            }

            //上架2
            else if (this.HookType == EnHookType.I9)
            {
                switch (KeyValue)
                {
                    #region 快捷键
                    //case 112: this.ucTransferPutaway2.HookExit(); break;//F1
                    //case 114: this.ucTransferPutaway2.HookHty(); break;//F3
                    //case 117: this.ucTransferPutaway2.HookSearch(); break;//F6
                    //case 120: this.ucTransferPutaway2.HookPoint(); break;//F9
                    default: break;

                    #endregion
                }
            }

            //上架日志
            else if (this.HookType == EnHookType.I10)
            {
                switch (KeyValue)
                {
                    #region 快捷键
                    //case 112: this.ucTransferLog3.HookExit(); break;//F1
                    //case 113: this.ucTransferLog3.HookProv(); break;//F2
                    //case 114: this.ucTransferLog3.HookNext(); break;//F3
                    //case 115: this.ucTransferLog3.HookDelete(); break;//F4
                    default: break;

                    #endregion
                }
            }
            //特殊移库目录
            else if (this.HookType == EnHookType.J1)
            {
                switch (KeyValue)
                {
                    #region 快捷键
                    //case 112: this.ucXTransfer1.HookExit(); break;//F1
                    default: break;

                    #endregion
                }
            }
            //散货上架/下架/库内返架
            else if (this.HookType == EnHookType.J2)
            {
                switch (KeyValue)
                {
                    #region 快捷键
                    //case 112: this.ucXTransfer2.HookExit(); break;//F1
                    //case 116: this.ucXTransfer2.HookDetail(); break;//F5
                    //case 117: this.ucXTransfer2.HookSearch(); break;//F6
                    //case 121: this.ucXTransfer2.HookSave(); break;//F10
                    default: break;

                    #endregion
                }
            }
            else if (this.HookType == EnHookType.K1)
            {
                switch (KeyValue)
                {
                    #region 快捷键
                    //case 112: this.ucHandOver1.HookExit(); break;//F1
                    //case 121: this.ucHandOver1.HookStart(); break;//F0
                    //case 117: this.ucHandOver1.HookOld(); break;//F6
                    default: break;

                    #endregion
                }
            }
            else if (this.HookType == EnHookType.K2)
            {
                switch (KeyValue)
                {
                    #region 快捷键
                    //case 112: this.ucHandOver2.HookExit(); break;//F1
                    default: break;

                    #endregion
                }
            }
            else if (this.HookType == EnHookType.K3)
            {
                switch (KeyValue)
                {
                    #region 快捷键
                    //case 112: this.ucHandOver3.HookExit(); break;//F1
                    default: break;

                    #endregion
                }
            }
            //库存查询
            else if (this.HookType == EnHookType.X)
            {
                switch (KeyValue)
                {
                    #region 快捷键
                    //case 112: this.ucCellPalByCell.HookExit(); break;//F1
                    //case 113: this.ucCellPalByCell.HookProv(); break;//F2
                    //case 114: this.ucCellPalByCell.HookNext(); break;//F3 
                    default: break;

                    #endregion
                }
            }
            //库存查询
            else if (this.HookType == EnHookType.Y)
            {
                switch (KeyValue)
                {
                    #region 快捷键
                    //case 112: this.ucCellPal.HookExit(); break;//F1
                    //case 113: this.ucCellPal.HookProv(); break;//F2
                    //case 114: this.ucCellPal.HookNext(); break;//F3 
                    default: break;

                    #endregion
                }
            }
        }

        private void myTimer_Tick(object sender, EventArgs e)
        {
            //this.lbPower.Text = string.Format("{0:D}%", WinceHelper.GetBattery());

            if (KeepAlive)
            {
                ///保持心跳
                //new KeepAliveBP().KeepAlive(new KeepAliveEntity() { UserName = this.UserViewEntity.UserName, Message = "", Success = false }, this.RemoteServer);
            }
        }

        /// <summary>
        /// 移除控件  除目录
        /// </summary>
        private void Remove()
        {
            HideSetting();

            //HideReceive1();

            //HideReceive2();

            //HideInBound1();

            //HideInBound2();

            //HideInBound3();

            //HideInBound4();

            //HideInBound5();

            //HideProduct();

            //HidePutaway1();

            //HidePutaway2();

            //HidePutaway3();

            //HidePicking1();

            //HidePicking2();

            //HidePicking3();

            //HideStocktaking();

            //HideStocktakUser();

            //HideStocktakLog();

            //HideStocktakSystem1();

            //HideStocktakSystem2();

            //HideTransferUser2();

            //HideTransferLog();

            //HideTransferSys1();

            //HideTransferSys2();

            //HideTransferLog2();

            //HideTransferLog3();

            //HideTransferPutaway1();

            //HideTransferPutaway2();

            //HideXTransfer();

            //HideXTransferMenu();

            //HideHandOver1();

            //HideHandOver22();

            //HideCellPalByCell();

            //HidePutawayLog();
        }

        #endregion
    }

    #region 枚举

    #region 全局使用

    /*             
        ESC 　　27
        F1 　　112
        F2 　　113 
        F3 　　114
        F4 　　115
        F5 　　116
        F6 　　117
        F7 　　118 
        F8 　　119 
        F9 　　120 
        F0 　　121 
        F11 　 122
        F12 　 123 
        ENT    108
     */

    /// <summary>
    /// 快捷键类型
    /// </summary>
    public enum EnHookType
    {
        /// <summary>
        /// 登陆界面
        /// </summary>
        A = 0,

        /// <summary>
        /// 目录界面
        /// </summary>
        B = 1,

        /// <summary>
        /// 设置界面
        /// </summary>
        C = 2,

        /// <summary>
        /// 收货一级页面
        /// </summary>
        D1 = 3,

        /// <summary>
        /// 收货二级页面 收货
        /// </summary>
        D2 = 4,

        /// <summary>
        /// 清点1
        /// </summary>
        E1 = 5,

        /// <summary>
        /// 清点2
        /// </summary>
        E2 = 6,

        /// <summary>
        /// 清点3
        /// </summary>
        E3 = 7,

        /// <summary>
        /// 拆箱1
        /// </summary>
        E4 = 8,

        /// <summary>
        /// 拆箱2
        /// </summary>
        E5 = 9,

        /// <summary>
        /// 商品列表
        /// </summary>
        E6 = 10,

        /// <summary>
        /// 上架1
        /// </summary>
        F1 = 11,

        /// <summary>
        /// 上架2
        /// </summary>
        F2 = 12,

        /// <summary>
        /// 上架3
        /// </summary>
        F3 = 13,

        /// <summary>
        /// 上架log
        /// </summary>
        F4 = 14,

        /// <summary>
        /// 拣货1
        /// </summary>
        G1 = 15,

        /// <summary>
        /// 拣货2
        /// </summary>
        G2 = 16,

        /// <summary>
        /// 拣货3 病单
        /// </summary>
        G3 = 17,

        /// <summary>
        /// 盘点目录
        /// </summary>
        H1,

        /// <summary>
        /// 人工盘点
        /// </summary>
        H2,

        /// <summary>
        /// 系统盘点1
        /// </summary>
        H3,

        /// <summary>
        /// 系统盘点2
        /// </summary>
        H4,

        /// <summary>
        /// 盘点日志
        /// </summary>
        H5,

        /// <summary>
        /// 移库目录
        /// </summary>
        I1,

        /// <summary>
        /// 人工下架1
        /// </summary>
        I2,

        /// <summary>
        /// 人工下架2
        /// </summary>
        I3,

        /// <summary>
        /// 人工下架日志
        /// </summary>
        I4,

        /// <summary>
        /// 任务下架1
        /// </summary>
        I5,

        /// <summary>
        /// 任务下架2
        /// </summary>
        I6,

        /// <summary>
        /// 任务下架日志
        /// </summary>
        I7,

        /// <summary>
        /// 上架1
        /// </summary>
        I8,

        /// <summary>
        /// 上架2
        /// </summary>
        I9,

        /// <summary>
        /// 上架日志
        /// </summary>
        I10,

        /// <summary>
        /// 特殊移库目录
        /// </summary>
        J1,

        /// <summary>
        /// 散货上架/移虚库
        /// </summary>
        J2,

        /// <summary>
        /// 交接1
        /// </summary>
        K1,

        /// <summary>
        /// 交接2
        /// </summary>
        K2,

        /// <summary>
        /// 交接3
        /// </summary>
        K3,

        /// <summary>
        /// 通过库位查询 该库位上的所有商品库存
        /// </summary>
        X,

        /// <summary>
        /// 库存查询页面
        /// </summary>
        Y,

        /// <summary>
        /// 消息提示框
        /// </summary>
        Z,

        /// <summary>
        /// 默认
        /// </summary>
        Default = -1
    }

    /// <summary>
    /// 消息类型
    /// </summary>
    public enum EnMessageType
    {
        A, B, C, D, E, F, G, H, I
    }

    #endregion

    #region 收货

    /// <summary>
    /// 收货类型
    /// </summary>
    public enum EnReceiveType
    {
        /// <summary>
        /// 正常收货
        /// </summary>
        A,

        /// <summary>
        /// 盲收
        /// </summary>
        B
    }

    #endregion 全局使用

    #region 收货 + 清点

    /// <summary>
    /// 打印类型
    /// </summary>
    public enum EnPrintType
    {
        /// <summary>
        /// 大货 
        /// </summary>
        A,

        /// <summary>
        /// 退货
        /// </summary>
        B
    }

    #endregion

    #region 清点

    /// <summary>
    /// 枚举 类型 清点
    /// </summary>
    public enum EnImpType
    {
        /// <summary>
        /// 次品扫描
        /// </summary>
        BAD,

        /// <summary>
        /// 清点数量
        /// </summary>
        CHECK
    }

    /// <summary>
    /// 默认数量设置页面
    /// </summary>
    public enum EnDefaultType
    {
        /// <summary>
        /// UCInBound3
        /// </summary>
        A,

        /// <summary>
        /// UCInBound5
        /// </summary>
        B,
    }

    /// <summary>
    /// 商品日志页面
    /// </summary>
    public enum EnProductType
    {
        /// <summary>
        /// UCInBound3
        /// </summary>
        A,

        /// <summary>
        /// UCInBound5
        /// </summary>
        B
    }

    #endregion

    #region 库存

    /// <summary>
    /// 库存页面
    /// </summary>
    public enum EnPalType
    {
        /// <summary>
        /// UCPicking3
        /// </summary>
        A,

        /// <summary>
        /// UCStocktakUser
        /// </summary>
        B,

        /// <summary>
        /// UCStocktakSystem2
        /// </summary>
        C,

        /// <summary>
        /// 目录
        /// </summary>
        D,

        /// <summary>
        /// 虚库/散货上架
        /// </summary>
        E,

        /// <summary>
        /// UCTransferPutaway2
        /// </summary>
        F,

        /// <summary>
        /// UCPutaway3
        /// </summary>
        G
    }

    #endregion

    #region 盘点日志

    /// <summary>
    /// 盘点日志
    /// </summary>
    public enum EnLogType
    {
        /// <summary>
        /// UCStocktakUser
        /// </summary>
        A,

        /// <summary>
        /// UCStocktakSystem2
        /// </summary>
        B,
    }

    #endregion

    #region 移库类型+移库删除类型

    /// <summary>
    /// 盘点日志
    /// </summary>
    public enum EnTransferType
    {
        /// <summary>
        /// UCTransferUserDirected2
        /// </summary>
        A,

        /// <summary>
        /// UCTransferSysDirected2
        /// </summary>
        B,

        /// <summary>
        /// UCTransferPutaway2
        /// </summary>
        C
    }

    #endregion

    #region 特殊移库

    /// <summary>
    /// 特殊移库
    /// </summary>
    public enum EnXTransferType
    {
        /// <summary>
        /// 散货 上架
        /// </summary>
        A,

        /// <summary>
        /// 移虚库
        /// </summary>
        B,

        /// <summary>
        /// 库内返架
        /// </summary>
        C,

        /// <summary>
        /// 病转正常
        /// </summary>
        D,

        /// <summary>
        /// 病转缺货
        /// </summary>
        E
    }

    #endregion

    #endregion
}