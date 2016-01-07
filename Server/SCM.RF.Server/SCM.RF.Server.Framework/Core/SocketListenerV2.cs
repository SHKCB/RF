using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using SCM.RF.Server.Framework.Commond;
using SCM.RF.Server.Framework.Data;
using SCM.RF.Server.Framework.Handler;

namespace SCM.RF.Server.Framework.Core
{
    /// <summary>
    /// 监听
    /// </summary>
    public class SocketListenerV2
    {
        /// <summary>
        /// 保存连接的所有用户
        /// </summary>
        //private List<User> userList = new List<User>();

        /// <summary>
        /// 监听
        /// </summary>
        private TcpListener _TcpListener;

        /// <summary>
        /// 是否正常退出所有接收线程
        /// </summary>
        //bool Instance.ISExit = false;

        /// <summary>
        /// 接收端口{本地}
        /// </summary>
        private IPEndPoint _IPEndPoint;

        private System.Text.Encoding _Encoding = System.Text.Encoding.GetEncoding("GB2312");

        public SocketListenerV2(String hostName, Int32 port)
        {
            IPHostEntry host = Dns.GetHostEntry(hostName);

            IPAddress[] addressList = host.AddressList;

            this._IPEndPoint = new IPEndPoint(addressList[addressList.Length - 1], port);
        }

        #region public function
        public void Start()
        {
            this._TcpListener = new TcpListener(_IPEndPoint);

            _TcpListener.Start(100);

            Thread myThread = new Thread(ListenClientConnect);

            myThread.Start();
        }

        /// <summary>
        /// 移除用户
        /// </summary>
        /// <param name="user"></param>
        public void RemoveUser(User user)
        {
            Instance.UserList.Remove(user);
            user.Close();
        }

        /// <summary>
        /// 停止服务
        /// </summary>
        public void Stop()
        {
            Instance.ISExit = true;

            for (int i = 0; i < Instance.UserList.Count; i++)
            {
                RemoveUser(Instance.UserList[i]);
            }
            //通过停止监听让myListener.AcceptTcpClient()产生异常退出监听线程
            _TcpListener.Stop();
        }

        /// <summary>
        /// 异步发送信息给所有客户
        /// </summary>
        /// <param name="user"></param>
        /// <param name="message"></param>
        //public void AsyncSendToAllClient(byte[] message)
        //{
        //    foreach (User user in Instance.UserList)
        //    {
        //        AsyncSendToClient(user, message);
        //    }
        //}

        public void AsyncSendToAllClient(string message)
        {
            foreach (User user in Instance.UserList)
            {
                AsyncSendToClient(user, message);
            }
        }
        #endregion

        #region private function
        /// <summary>
        /// 监听客户端请求
        /// </summary>
        private void ListenClientConnect()
        {
            TcpClient newClient = null;
            while (true)
            {
                ListenClientDelegate d = new ListenClientDelegate(ListenClient);
                IAsyncResult result = d.BeginInvoke(out newClient, null, null);
                //使用轮询方式来判断异步操作是否完成
                while (result.IsCompleted == false)
                {
                    if (Instance.ISExit)
                        break;
                    Thread.Sleep(50);
                    //Thread.Sleep(100);
                }
                //获取Begin 方法的返回值和所有输入/输出参数
                d.EndInvoke(out newClient, result);
                if (newClient != null)
                {
                    //每接受一个客户端连接，就创建一个对应的线程循环接收该客户端发来的信息
                    User user = new User(newClient);
                    user.IP = newClient.Client.RemoteEndPoint.ToString();
                    //日志
                    Console.WriteLine(string.Format("用户{0}上线", user.IP));
                    Thread threadReceive = new Thread(ReceiveData);
                    threadReceive.Start(user);
                    Instance.UserList.Add(user);
                }
                else
                {
                    break;
                }
            }
        }

        /// <summary>
        /// 接受挂起的客户端连接请求
        /// </summary>
        /// <param name="newClient"></param>
        private void ListenClient(out TcpClient newClient)
        {
            try
            {
                newClient = _TcpListener.AcceptTcpClient();
            }
            catch
            {
                newClient = null;
            }
        }

        private void ReceiveData(object userState)
        {
            User user = (User)userState;
            TcpClient client = user.client;
            while (!Instance.ISExit)
            {
                string receive = string.Empty;
                ReceiveMessageDelegate d = new ReceiveMessageDelegate(ReceiveMessage);
                IAsyncResult result = d.BeginInvoke(user, out receive, null, null);
                //使用轮询方式来判断异步操作是否完成
                while (!result.IsCompleted)
                {
                    if (Instance.ISExit)
                        break;
                    Thread.Sleep(50);
                    //Thread.Sleep(100);
                }
                //获取Begin方法的返回值和所有输入/输出参数
                d.EndInvoke(out receive, result);
                if (receive.Length == 0 || receive == null)
                {
                    if (!Instance.ISExit)
                    {
                        //日志
                        Console.WriteLine(string.Format("与{0}失去联系，已终止接收该用户信息", user.IP));
                        RemoveUser(user);
                    }
                    break;
                }

                string aswer = string.Empty;
                CommandManage manage = new CommandManage();
                try
                {
                    Console.WriteLine("接受：" + receive);

                    aswer = manage.Proc(receive);

                    Console.WriteLine("应答：" + aswer);
                }
                catch
                {
                    manage.CloseUser = true;
                }

                //foreach (User target in Instance.UserList)
                //{
                //    if (target.IP == client.Client.RemoteEndPoint.ToString())
                //    {
                //        AsyncSendToClient(target, aswer);
                //    }
                //}

                AsyncSendToClient(user, aswer);

                if (manage.CloseUser)
                {
                    this.RemoveUser(user);
                }
            }
        }

        /*
        /// <summary>
        /// 接收客户端发来的信息
        /// </summary>
        /// <param name="user"></param>
        /// <param name="receiveMessage"></param>
        private void ReceiveMessage(User user, out byte[] receive)
        {
            receive = new byte[] { };

            byte[] _Buffer = new byte[1024];

            MemoryStream ms = new MemoryStream();

            int index = 0;

            try
            {
                do
                {
                    index = user.br.Read(_Buffer, 0, 1024);
                    ms.Write(_Buffer, 0, _Buffer.Length);
                }
                while (index >= 1024);
            }
            catch
            {
                //this._HasError = true;

                //this._ErrorInfo = "接收服务器内容失败";

                return;
            }

            receive = ms.ToArray();

            ms.Close();
        }

        /// <summary>
        /// 异步发送message给user
        /// </summary>
        /// <param name="user"></param>
        /// <param name="message"></param>
        private void AsyncSendToClient(User user, byte[] message)
        {
            SendToClientDelegate d = new SendToClientDelegate(SendToClient);
            IAsyncResult result = d.BeginInvoke(user, message, null, null);
            while (result.IsCompleted == false)
            {
                if (Instance.ISExit)
                    break;
                Thread.Sleep(500);
            }
            d.EndInvoke(result);
        }

        /// <summary>
        /// 发送message给user
        /// </summary>
        /// <param name="user"></param>
        /// <param name="message"></param>
        private void SendToClient(User user, byte[] message)
        {
            try
            {
                //将字符串写入网络流，此方法会自动附加字符串长度前缀
                user.bw.Write(message);
                user.bw.Flush();
                //日志
                Console.WriteLine(string.Format("向[{0}]发送：{1}", user.IP, message.Length));
            }
            catch
            {
                //日志
                Console.WriteLine(string.Format("向[{0}]发送信息失败", user.IP));
            }
        }
*/

        /// <summary>
        /// 接收客户端发来的信息
        /// </summary>
        /// <param name="user"></param>
        /// <param name="receiveMessage"></param>
        private void ReceiveMessage(User user, out string receive)
        {
            receive = string.Empty;

            try
            {
                receive = user.br.ReadString();
            }
            catch
            {
                receive = string.Empty;
            }
        }

        /// <summary>
        /// 异步发送message给user
        /// </summary>
        /// <param name="user"></param>
        /// <param name="message"></param>
        private void AsyncSendToClient(User user, string message)
        {
            SendToClientDelegate d = new SendToClientDelegate(SendToClient);
            IAsyncResult result = d.BeginInvoke(user, message, null, null);
            while (result.IsCompleted == false)
            {
                if (Instance.ISExit)
                    break;
                Thread.Sleep(50);
                //Thread.Sleep(100);
            }
            d.EndInvoke(result);
        }

        /// <summary>
        /// 发送message给user
        /// </summary>
        /// <param name="user"></param>
        /// <param name="message"></param>
        private void SendToClient(User user, string message)
        {
            try
            {
                //将字符串写入网络流，此方法会自动附加字符串长度前缀
                user.bw.Write(message);
                user.bw.Flush();
                //日志
                Console.WriteLine(string.Format("向[{0}]发送：{1}", user.IP, message.Length));
            }
            catch
            {
                //日志
                Console.WriteLine(string.Format("向[{0}]发送信息失败", user.IP));
            }
        }
        #endregion
    }
}
