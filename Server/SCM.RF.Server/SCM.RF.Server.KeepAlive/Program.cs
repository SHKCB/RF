using System;
using System.Diagnostics;

namespace SCM.RF.Server.KeepAlive
{
    class Program
    {
        private static object obj = new object();

        static void Main(string[] args)
        {
            System.Timers.Timer timer = new System.Timers.Timer(10000);

            timer.Enabled = true;

            timer.Elapsed += new System.Timers.ElapsedEventHandler(timer_Elapsed);

            Console.ReadLine();
        }

        static void timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            lock (obj)
            {
                DateTime t = DateTime.Now;

                if (t.Hour == 7 && t.Minute == 10)
                {
                    Proc();
                }
            }
        }

        static void Proc()
        {
            Process[] arrayProcess = Process.GetProcessesByName("SCM.RF.Server.Form");

            foreach (Process p in arrayProcess)
            {
                p.Kill();
            }

            Process process = new Process();
            //C:\APP\RFV2\SCM.RF.Server.Form.exe
            process.StartInfo.FileName = @"C:\APP\RFV2\SCM.RF.Server.Form.exe";
            process.Start();
        }
    }
}
