using System;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Xml;
using SCM.RF.Client.BizEntities.Sys;
using SCM.RF.Client.Utility;

namespace SCM.RF.Client.BizProcess.Sys
{
    public class InstanceBP
    {
        /// <summary>
        /// 系统配置
        /// </summary>
        private static SystemViewEntity _SystemEntity;

        /// <summary>
        /// 实例
        /// </summary>
        public static SystemViewEntity SystemInstance
        {
            get
            {
                if (_SystemEntity == null)
                {
                    XmlHelper<SystemViewEntity> helper = new XmlHelper<SystemViewEntity>();
                    XmlDocument doc = new XmlDocument();
                    doc.Load(string.Concat(Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase), @"\app.xml"));
                    _SystemEntity = helper.GetEntity(doc);
                }

                return _SystemEntity;
            }
            set
            {
                _SystemEntity = value;
            }
        }

        /// <summary>
        /// 判断是否需要更新
        /// </summary>
        /// <returns></returns>
        public static bool NeedUpdate(out bool hasError)
        {
            string content = string.Empty;

            hasError = false;

            try
            {
                System.Net.WebRequest request = System.Net.WebRequest.Create(new Uri(SystemInstance.UpUrl + "AutoUpdate.ashx"));

                System.Net.WebResponse response = request.GetResponse();

                System.IO.Stream stream = response.GetResponseStream();

                StreamReader reader = new StreamReader(stream);

                content = reader.ReadToEnd();

                stream.Flush();

                reader.Close();

                stream.Close();

                XmlDocument doc = new XmlDocument();

                doc.LoadXml(content);

                string serverVision = doc.SelectSingleNode("AutoUpdate/UpDate").InnerText.Trim();

                if (!String.IsNullOrEmpty(serverVision) && !String.IsNullOrEmpty(SystemInstance.UpDate))
                {
                    if (DateTime.Compare(Convert.ToDateTime(serverVision, CultureInfo.InvariantCulture), Convert.ToDateTime(SystemInstance.UpDate, CultureInfo.InvariantCulture)) > 0)
                    {
                        return true;
                    }
                }
            }
            catch
            {
                hasError = true;
            }

            return false;
        }
    }
}
