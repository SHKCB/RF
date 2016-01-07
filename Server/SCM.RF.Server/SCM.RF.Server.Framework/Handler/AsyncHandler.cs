using System.Net.Sockets;
using SCM.RF.Server.Framework.Data;

namespace SCM.RF.Server.Framework.Handler
{
    public delegate void ListenClientDelegate(out TcpClient client);

    public delegate void ReceiveMessageDelegate(User user, out string receive);

    public delegate void SendToClientDelegate(User user, string message);
}
