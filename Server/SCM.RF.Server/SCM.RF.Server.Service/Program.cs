using SCM.RF.Server.BizEntities.Sys;
using SCM.RF.Server.Framework.Core;
using System;
using System.Collections;
using System.Collections.Generic;

namespace SCM.RF.Server.Form
{
    static class Program
    {
        static Hashtable ht = new Hashtable();

        [STAThread]
        static void Main()
        {
            System.Timers.Timer timer = new System.Timers.Timer(10000);

            timer.Elapsed += new System.Timers.ElapsedEventHandler(timer_Elapsed);

            timer.Enabled = true;

            timer.Start();

            Console.ReadLine();
        }

        static void timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            Proc();
        }

        static void Proc()
        {
            IList<int> list = new List<int>() { 7777 };// null;// new SCM.RF.Server.BizProcess.AuthCenter.UserBP().GetList();

            foreach (int port in list)
            {
                if (!ht.ContainsKey(port))
                {
                    ht.Add(port, null);

                    SocketListenerV2 _SocketListenerV2 = new SocketListenerV2(SystemInstance.SystemEntityInstance.ServerIP, port);

                    Console.WriteLine("端口：" + port + " 开始监听。");

                    _SocketListenerV2.Start();
                }
            }
        }
    }
}
