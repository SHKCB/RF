using SCM.RF.Server.BizEntities.Receive;
using System.Xml;

namespace SCM.RF.Server.DataAccess.Receive
{
    public class ReceiveDA
    {
        public static ReceiveHeaderViewEntity GetReceiveDetail(ReceiveHeaderViewEntity entity)
        {
            SCM.RF.Server.Adapt.IWebWarehouseServiceQYBService service = new Adapt.IWebWarehouseServiceQYBService();

            string param = @"<?xml version='1.0' encoding='UTF-8'?>
                                <rt>
                                <tid>" + entity.TID + @"</tid>
                                <uname>" + entity.UName + @"</uname>
                                <pwd>" + entity.PWD + @"</pwd>
                                <cid>" + entity.CID + @"</cid>
                                <warehouseid>" + entity.WareHouseId + @"</warehouseid>
                                <fromcode>" + entity.Instockcode + @"</fromcode>
                            </rt>";

            string xmlstring = service.getInstockDetail(param);

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xmlstring);

            /*
             <?xml version="1.0" encoding="UTF-8"?>
             * <rt>
                 * <tid>20140318155513001</tid>
                 * <warehouseid>47a7377d4a9e42e3a665af0894946e21</warehouseid>
                 * <rc>1100</rc>
                 * <rm>查询不到待收货商品</rm>
             * </rt>
             */

            string returncode = doc.SelectSingleNode("rt/rc").InnerText;

            if (returncode == "0000")
            {
                entity.Detail = new ReceiveDetailViewEntity[] { };

                //XmlNodeList detail = doc.SelectNodes(rt/rm);
            }
            else 
            {
                entity.Success = false;
                entity.Message = doc.SelectSingleNode("rt/rm").InnerText;
            }

            return entity;

        }
    }
}
