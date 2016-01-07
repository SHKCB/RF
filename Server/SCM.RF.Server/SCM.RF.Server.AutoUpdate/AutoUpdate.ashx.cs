using System;
using System.Web;
using System.Xml;

namespace WMS.Website
{
    /// <summary>
    /// Summary description for UpdateSize
    /// </summary>
    public class UpdateSize : IHttpHandler
    {
        public void ProcessRequest(HttpContext context)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "AutoUpdate.xml";

            string content = SCM.RF.Server.Utility.IOHelper.ReadFile(path);

            #region 读取文件大小
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(content);
            string dirPath = doc.SelectSingleNode("AutoUpdate/UpPath").InnerText;
            long size = GetUpdateSize(AppDomain.CurrentDomain.BaseDirectory + dirPath);
            content = content.Replace("#SIZE#", size.ToString());

            #endregion
            context.Response.ContentType = "text/xml";
            context.Response.Expires = -1;

            context.Response.Write(content);
            context.Response.End();
        }

        /// <summary> 
        /// 获取所有下载文件大小 
        /// </summary> 
        /// <returns>返回值</returns> 
        private static long GetUpdateSize(string dirPath)
        {
            //判断文件夹是否存在，不存在则退出 
            if (!System.IO.Directory.Exists(dirPath))
            {
                return 0;
            }

            long len;
            len = 0;
            System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(dirPath);
            //获取所有文件大小 
            foreach (System.IO.FileInfo fi in di.GetFiles("*.*", System.IO.SearchOption.AllDirectories))
            {
                len += fi.Length;
            }
            return len;
        }

        /// <summary>
        /// 
        /// </summary>
        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}