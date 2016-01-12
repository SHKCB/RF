using SCM.RF.Server.BizEntities.Pick;
using System.Xml;

namespace SCM.RF.Server.DataAccess.Pick
{
    public class PickDA
    {
        public static PickEnity GetPickByTaskID(PickEnity entity)
        {
            SCM.RF.Server.Adapt.IWebWarehouseServiceQYBService service = new Adapt.IWebWarehouseServiceQYBService();

            /*
            <?xml version="1.0" encoding=“UTF-8”?>
            <rt>
            <tid>20140318155513001</tid>
            <uname>009933</uname>
            <pwd>1</pwd>
            <cid>665731</cid>
            <code></code>
            </rt>

             */

            string param = @"<?xml version=\'1.0\' encoding=\'UTF-8\'?>
                                <rt>
                                <tid>" + entity.TID + @"</tid>
                                <uname>" + entity.UName + @"</uname>
                                <pwd>" + entity.PWD + @"</pwd>
                                <cid>" + entity.CID + @"</cid>
                                <code>" + entity.TaskNo + @"</code>
                            </rt>";

            string xmlstring = service.getInstockDetail(param);

            XmlDocument doc = new XmlDocument();

            doc.LoadXml(xmlstring);

            return entity;

        }
    }
}
