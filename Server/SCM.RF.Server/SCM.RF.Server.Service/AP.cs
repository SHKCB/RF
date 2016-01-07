using SCM.RF.Server.BizEntities.Sys;
using SCM.RF.Server.Framework.Core;
using System.Threading;
using System.Windows.Forms;

namespace SCM.RF.Server.Form
{
    public partial class AP : System.Windows.Forms.Form
    {
        private delegate void AddOnlineDelegate();

        private SocketListenerV2 _SocketListenerV2;

        public AP()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void btnStop_Click(object sender, System.EventArgs e)
        {
            _SocketListenerV2.Stop();
        }

        private void btnStart_Click(object sender, System.EventArgs e)
        {
            _SocketListenerV2 = new SocketListenerV2(SystemInstance.SystemEntityInstance.ServerIP, SystemInstance.SystemEntityInstance.Port);

            _SocketListenerV2.Start();
        }

        public void AddOnline()
        {
            while (true)
            {
                if (gridUser.InvokeRequired)
                {
                    AddOnlineDelegate d = new AddOnlineDelegate(AddOnline);
                    gridUser.Invoke(d, new object[] { SCM.RF.Server.Framework.Data.Instance.UserList });
                }
                else
                {
                    gridUser.DataSource = SCM.RF.Server.Framework.Data.Instance.UserList;
                }

                Thread.Sleep(10000);
            }
        }

        private void AP_Load(object sender, System.EventArgs e)
        {
            Thread t = new Thread(new ThreadStart(AddOnline));

            t.Start();
        }
    }
}
