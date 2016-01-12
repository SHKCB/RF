using SCM.RF.Server.BizEntities.Receive;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace SCM.RF.Server.DataAccess.Receive
{
    public class ReceiveDA
    {

        public static ReceiveHeaderViewEntity GetReceiveDetail(ReceiveHeaderViewEntity entity)
        {
           
            SCM.RF.Server.Adapt.IWebWarehouseServiceService service = new Adapt.IWebWarehouseServiceService();

            string param = @"<?xml version=\'1.0\' encoding=\'UTF-8\'?>
                                <rt>
                                <tid>" + entity.TID + @"</tid>
                                <uname>" + entity.UName + @"</uname>
                                <pwd>" + entity.PWD + @"</pwd>
                                <cid>" + entity.CID + @"</cid>
                                <warehouseid>" + entity.WareHouseId + @"</warehouseid>
                                <fromcode>" + entity.Instockcode + @"</fromcode>
                            </rt>";

            string xmlstring = service.getInstockdOfCheck(param);

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xmlstring);

            return entity;

        }
    }
}
