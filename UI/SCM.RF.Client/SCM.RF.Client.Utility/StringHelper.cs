using System.Text.RegularExpressions;

namespace SCM.RF.Client.Utility
{
    public class StringHelper
    {
        /// <summary>
        /// 非零的正整数 ，非0开始的数字
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public static bool ISInt32(string param)
        {
            //EditBy[马丁] Bug:5534
            string pattern = @"^[1-9][0-9]*$";

            Match m = Regex.Match(param, pattern);

            if (m.Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 允许0-9
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public static bool ISInt(string param)
        {
            //EditBy[马丁] Bug:5534
            string pattern = @"^[0-9]*$";

            Match m = Regex.Match(param, pattern);

            if (m.Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 字母+数字+@+\+-
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public static bool ISStringInt32(string param)
        {
            string pattern = @"^[-A-Za-z0-9\\]+$";

            Match m = Regex.Match(param, pattern);

            if (m.Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// IP地址
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public static bool ISIP(string param)
        {
            string pattern = @"^(\d{1,2}|1\d\d|2[0-4]\d|25[0-5])\.(\d{1,2}|1\d\d|2[0-4]\d|25[0-5])\.(\d{1,2}|1\d\d|2[0-4]\d|25[0-5])\.(\d{1,2}|1\d\d|2[0-4]\d|25[0-5])$";

            Match m = Regex.Match(param, pattern);

            if (m.Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
