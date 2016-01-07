
namespace SCM.RF.Client.Framework.Core
{
    public class RemoteServer
    {
        private SocketClient _SocketClient;

        /// <summary>
        /// 是否连接
        /// </summary>
        private bool _Connected;

        /// <summary>
        /// 是否包含错误
        /// </summary>
        private bool _HasError = false;

        /// <summary>
        /// 错误信息
        /// </summary>
        private string _ErrorInfo = string.Empty;

        /// <summary>
        /// 通信内容契约[length={0}]{1}
        /// </summary>
        private string _Contract = "[length={0}]{1}";

        /// <summary>
        /// 编码
        /// </summary>
        public System.Text.Encoding _Encoding = SCM.RF.Client.Utility.EncodingInstance.Instance;

        /// <summary>
        /// 是否连接
        /// </summary>
        public bool Connected
        {
            get
            {
                return this._Connected;
            }
        }

        /// <summary>
        /// 是否包含错误
        /// </summary>
        public bool HasError
        {
            get
            {
                return this._HasError;
            }
        }

        /// <summary>
        /// 错误信息
        /// </summary>
        public string ErrorInfo
        {
            get
            {
                return this._ErrorInfo;
            }
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        public RemoteServer(string hostName, int port)
        {
            _SocketClient = new SocketClient(hostName, port);
        }

        /// <summary>
        /// 连接 
        /// </summary>
        public void Connect()
        {
            _SocketClient.Connect();

            this._Connected = _SocketClient.Connected;

            this._ErrorInfo = _SocketClient.ErrorInfo;

            this._HasError = _SocketClient.HasError;
        }

        /// <summary>
        /// 执行命令
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entity"></param>
        /// <param name="action"></param>
        /// <returns></returns>
        public T Commond<T>(T entity, string action)
        {
            //参数不能为空
            if (entity == null)
            {
                this._ErrorInfo = "参数不能为空";

                this._HasError = true;
            }

            //是否已经连接
            if (!_SocketClient.Connected)
            {
                Connect();
            }

            //判断是否已经连接
            if (!_Connected)
            {
                this._ErrorInfo = "与服务器通信失败";

                this._HasError = true;
            }

            string serialize = SCM.RF.Client.Utility.SerializeHelper.Serialize(entity);

            string command = string.Concat(action, serialize);

            string content = string.Format(_Contract, command.Length, command);

            _SocketClient.SendData(content);

            string desString = _SocketClient.ReceiveData();

            T result = SCM.RF.Client.Utility.SerializeHelper.Deserialize<T>(desString);

            if (result != null)
            {
                return result;
            }

            return default(T);
        }
    }
}
