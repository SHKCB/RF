using SCM.RF.Server.BizEntities.Pick;
using System.Xml;

namespace SCM.RF.Server.DataAccess.Pick
{
    public class PickDA
    {
        public static PickEnity GetPickByTaskID(ref PickEnity entity)
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

            string param = @"<?xml version='1.0' encoding='UTF-8'?>
                                <rt>
                                <tid>" + entity.TID + @"</tid>
                                <uname>" + entity.UName + @"</uname>
                                <pwd>" + entity.PWD + @"</pwd>
                                <device>" + entity.Device + @"</device>
                                <cid>" + entity.CID + @"</cid>
                                <warehouseid>" + entity.WareHouseId + @"</warehouseid>
                                <code>" + entity.TaskNo + @"</code>
                            </rt>";

            string result = service.getInstockDetail(param);

            XmlDocument xml = new XmlDocument();

            xml.LoadXml(result);

            string returncode = xml.SelectSingleNode("rt/rc").InnerText;

            if (returncode == "0000")
            {
                entity.WareHouseId = xml.SelectSingleNode("rt/warehouseid").InnerText;
                entity.Success = true;
            }
            else
            {
                entity.Success = false;
                entity.Message = xml.SelectSingleNode("rt/rm").InnerText;
            }

            return entity;
        }
    }
}
