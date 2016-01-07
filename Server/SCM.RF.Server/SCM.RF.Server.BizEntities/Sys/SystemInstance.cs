using SCM.RF.Server.Utility;
using System;
using System.Xml;

namespace SCM.RF.Server.BizEntities.Sys
{
    public class SystemInstance
    {
        private static SystemEntity _systemEntityInstance;

        public static SystemEntity SystemEntityInstance
        {
            get
            {
                if (_systemEntityInstance == null)
                {
                    XmlHelper<SystemEntity> helper = new XmlHelper<SystemEntity>();
                    XmlDocument doc = new XmlDocument();
                    doc.Load(string.Concat(AppDomain.CurrentDomain.BaseDirectory, @"appconfig\system.xml"));
                    _systemEntityInstance = helper.GetEntity(doc);
                }

                return _systemEntityInstance;
            }
        }

        public static Boolean IsExit = false;
    }
}
