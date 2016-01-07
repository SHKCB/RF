using System;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace SCM.RF.Server.Utility
{
    public static class StringHelper
    {
        //去掉所有html标记
        public static string GetContextWithOutLink(string allCode)
        {
            string m_outstr = allCode;

            //2008-04-10修改代码开始
            //去掉<head></head>之间的所有内容
            //m_outstr = new Regex(@"<\s*head.*\/head\s*>",RegexOptions.Multiline | RegexOptions.IgnoreCase).Replace(m_outstr,"");
            m_outstr = new Regex(@"(?m)<head[^>]*>(\w|\W)*?</head[^>]*>", RegexOptions.Multiline | RegexOptions.IgnoreCase).Replace(m_outstr, "");
            // return m_outstr;
            //去掉<script></script>之间的所有内容
            // m_outstr = new Regex(@"<\s*script.*>", RegexOptions.Multiline | RegexOptions.IgnoreCase).Replace(m_outstr, "");
            m_outstr = new Regex(@"(?m)<script[^>]*>(\w|\W)*?</script[^>]*>", RegexOptions.Multiline | RegexOptions.IgnoreCase).Replace(m_outstr, "");
            //去掉css内部样式
            // m_outstr = new Regex(@"<\s*style.*>", RegexOptions.Multiline | RegexOptions.IgnoreCase).Replace(m_outstr, "");
            m_outstr = new Regex(@"(?m)<style[^>]*>(\w|\W)*?</style[^>]*>", RegexOptions.Multiline | RegexOptions.IgnoreCase).Replace(m_outstr, "");
            //非贪心去掉html标记
            m_outstr = new Regex(@"<.*?>", RegexOptions.Multiline | RegexOptions.IgnoreCase).Replace(m_outstr, "");
            //去掉&nbsp；(空格),&quot；（双引号），&lt; &gt; &amp; &reg; &copy; &trade; &ensp; &emsp
            m_outstr = new Regex(@"(&nbsp;|&quot;|&lt;|&gt;|&amp;|&reg;|&copy;|&trade;|&ensp;|&emsp;)", RegexOptions.Multiline | RegexOptions.IgnoreCase).Replace(m_outstr, "");
            //去掉连续的空格
            Regex objReg = new System.Text.RegularExpressions.Regex("(<[^>]+?>)|&nbsp;", RegexOptions.Multiline | RegexOptions.IgnoreCase);
            m_outstr = objReg.Replace(m_outstr, "");
            Regex objReg2 = new System.Text.RegularExpressions.Regex("(\\s)+", RegexOptions.Multiline | RegexOptions.IgnoreCase);
            m_outstr = objReg2.Replace(m_outstr, " ");

            return m_outstr;
            //2008-04-10修改代码结束
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public static String EncryptCode(string password)
        {
            Byte[] clearBytes = Encoding.Default.GetBytes(password);
            Byte[] hashedBytes = ((HashAlgorithm)CryptoConfig.CreateFromName("MD5")).ComputeHash(clearBytes);
            return BitConverter.ToString(hashedBytes).Replace("-", "");
        }

        /// <summary>
        /// 读取MD5
        /// </summary>
        /// <param name="encryptStr"></param>
        /// <returns></returns>
        public static string getMD5(string encryptStr)
        {
            System.Security.Cryptography.MD5 md5 = new MD5CryptoServiceProvider();
            byte[] bytResult = md5.ComputeHash(System.Text.Encoding.Default.GetBytes(encryptStr));
            string strResult = BitConverter.ToString(bytResult);
            strResult = strResult.Replace("-", "");
            return strResult;
        }

        /// <summary>
        /// 读取订单号
        /// </summary>
        /// <returns></returns>
        public static string GetOrderNo()
        {
            int iSeed = 10;
            string strDt = "";
            Random ro = new Random(iSeed);
            long tick = DateTime.Now.Ticks;
            Random ran = new Random((int)(tick & 0xffffffffL) | (int)(tick >> 32));
            int iResult; int iUp = 999999; int iDown = 100000;
            iResult = ran.Next(iDown, iUp);
            strDt = DateTime.Now.ToString("yyMMddHHmm");
            return strDt + iResult.ToString();
        }
    }
}
