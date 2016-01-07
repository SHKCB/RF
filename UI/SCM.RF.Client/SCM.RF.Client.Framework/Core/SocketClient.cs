using System.IO;
using System.Net;
using System.Net.Sockets;

namespace SCM.RF.Client.Framework.Core
{
    public class SocketClient
    {
        //是否正常退出
        //private bool isExit = false;
        /// <summary>
        /// 缓存
        /// </summary>

        /// <summary>
        /// 是否连接
        /// </summary>
        private bool _Connected;
        /// <summary>
        /// 套接字
        /// </summary>
        private TcpClient _TcpClient;
        /// <summary>
        /// 读
        /// </summary>
        private BinaryReader _BinaryReader;
        /// <summary>
        /// 写
        /// </summary>
        private BinaryWriter _BinaryWriter;

        /// <summary>
        /// 是否包含错误
        /// </summary>
        private bool _HasError = false;

        /// <summary>
        /// 错误信息
        /// </summary>
        private string _ErrorInfo = string.Empty;

        /// <summary>
        /// 地址
        /// </summary>
        private IPEndPoint _IPEndPoint;

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

        public SocketClient(string hostName, int port)
        {
            #region 服务器地址初始化

            IPHostEntry host = Dns.GetHostEntry(hostName);

            IPAddress[] addressList = host.AddressList;

            this._IPEndPoint = new IPEndPoint(addressList[addressList.Length - 1], port);

            #endregion

            this._TcpClient = new TcpClient();
        }

        /// <summary>
        /// 异步方式与服务器进行连接
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Connect()
        {
            try
            {
                //连接
                this._TcpClient.Connect(_IPEndPoint);
            }
            catch
            {
                this._Connected = false;

                this._HasError = true;

                this._ErrorInfo = "与服务器连接失败";

                return;
            }

            _Connected = true;

            //获取网络流
            NetworkStream networkStream = this._TcpClient.GetStream();

            //将网络流作为二进制读写对象
            _BinaryReader = new BinaryReader(networkStream, _Encoding);
            _BinaryWriter = new BinaryWriter(networkStream, _Encoding);
        }

        public void SendData(string msg)
        {
            try
            {
                _BinaryWriter.Write(msg);
                _BinaryWriter.Flush();
            }
            catch
            {
                this._HasError = true;

                this._ErrorInfo = "发送内容失败";

                return;
            }
        }

        public string ReceiveData()
        {
            string receive = string.Empty;

            ReceiveMessage(out receive);

            return receive;
        }

        private void ReceiveMessage(out string receive)
        {
            receive = string.Empty;

            try
            {
                receive = _BinaryReader.ReadString();
            }
            catch
            {
                this._HasError = true;

                this._ErrorInfo = "接收服务器内容失败";

                return;
            }
        }
    }
}
