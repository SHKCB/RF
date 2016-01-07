using System;
using System.Runtime.InteropServices;

namespace SCM.RF.Client.Utility
{
    public class WinceHelper
    {
        #region 任务栏操作

        [DllImport("coredll.dll", EntryPoint = "FindWindow")]
        private static extern int FindWindow(string lpWindowName, string lpClassName);
        [DllImport("coredll.dll", EntryPoint = "ShowWindow")]
        private static extern int ShowWindow(int hwnd, int nCmdShow);
        //[DllImport("coredll.dll", EntryPoint = "EnableWindow")]
        //public static extern bool EnableWindow(IntPtr hwnd, bool bEnable);

        private const int SW_SHOW = 5; //显示窗口常量
        private const int SW_HIDE = 0; //隐藏窗口常量

        /// <summary>
        /// 显示任务栏
        /// </summary>
        /// <returns></returns>
        public static void ShowTaskBar()
        {
            int Hwnd = FindWindow("HHTaskBar", null);
            if (Hwnd != 0)
            {
                ShowWindow(Hwnd, SW_SHOW); //显示任务栏
            }

        }

        /// <summary>
        /// 隐藏任务栏
        /// </summary>
        /// <returns></returns>
        public static void HoldTaskBar()
        {
            int Hwnd = FindWindow("HHTaskBar", null);
            if (Hwnd != 0)
            {
                ShowWindow(Hwnd, SW_HIDE); //显示任务栏
            }
        }
        #endregion

        #region 电池电量

        [StructLayout(LayoutKind.Sequential)]
        private class SYSTEM_POWER_STATUS_EX2
        {
            /// <summary>
            /// 标记是否在使用外接电源  0为未接，1为接AC
            /// </summary>
            public byte ACLineStatus;

            public byte BatteryFlag;
            /// <summary>
            /// 当前电量百分比
            /// </summary>
            public byte BatteryLifePercent;
            public byte Reserved1;
            public uint BatteryLifeTime;
            public uint BatteryFullLifeTime;
            public byte Reserved2;
            public byte BackupBatteryFlag;
            public byte BackupBatteryLifePercent;
            public byte Reserved3;
            public uint BackupBatteryLifeTime;
            public uint BackupBatteryFullLifeTime;
            public uint BatteryVoltage;
            public uint BatteryCurrent;
            public uint BatteryAverageCurrent;
            public uint BatteryAverageInterval;
            public uint BatterymAHourConsumed;
            public uint BatteryTemperature;
            public uint BackupBatteryVoltage;
            public byte BatteryChemistry;
        }

        private const uint POWER_STATE_ON = 0x00010000u;        // on state
        private const uint POWER_STATE_OFF = 0x00020000u;        // no power, full off
        private const uint POWER_STATE_CRITICAL = 0x00040000u;        // critical off
        private const uint POWER_STATE_BOOT = 0x00080000u;        // boot state
        private const uint POWER_STATE_IDLE = 0x00100000u;        // idle state
        private const uint POWER_STATE_SUSPEND = 0x00200000u;        // suspend state
        private const uint POWER_STATE_RESET = 0x00800000u;        // reset state

        private const uint POWER_FORCE = 0x00001000u;

        [DllImport("coredll.dll")]
        private static extern uint GetSystemPowerStatusEx2(SYSTEM_POWER_STATUS_EX2 pSystemPowerStatusEx2, uint dwLen, [MarshalAs(UnmanagedType.Bool)]bool fUpdate);

        /// <summary>
        /// 获取电池电量
        /// </summary>
        /// <returns></returns>
        public static byte GetBattery()
        {
            SYSTEM_POWER_STATUS_EX2 status = new SYSTEM_POWER_STATUS_EX2();
            if (GetSystemPowerStatusEx2(status, (uint)Marshal.SizeOf(typeof(SYSTEM_POWER_STATUS_EX2)), true) > 0)
            {
                return status.BatteryLifePercent;
            }
            else
            {
                return 0;
            }
        }
        #endregion
    }
}
