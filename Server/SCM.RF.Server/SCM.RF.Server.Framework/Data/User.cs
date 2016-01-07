using System.IO;
using System.Net.Sockets;

namespace SCM.RF.Server.Framework.Data
{
    public class User
    {
        public TcpClient client { get; private set; }
        public BinaryReader br { get; private set; }
        public BinaryWriter bw { get; private set; }
        public string UserName { get; set; }
        public string IP { get; set; }
        public User(TcpClient client)
        {
            this.client = client;
            NetworkStream networkStream = client.GetStream();
            br = new BinaryReader(networkStream, System.Text.Encoding.GetEncoding("GB2312"));
            bw = new BinaryWriter(networkStream, System.Text.Encoding.GetEncoding("GB2312"));
        }

        public void Close()
        {
            br.Close();
            bw.Close();
            client.Close();
        }
    }
}
