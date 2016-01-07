using System;
using System.Windows.Forms;

namespace SCM.RF.Client.Tool
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [MTAThread]
        static void Main()
        {
            Application.Run(new RF());
        }
    }
}