using SCM.RF.Server.BizEntities.Pick;
using System.Collections.Generic;
using System.Text;
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

            string param = @"<?xml version='1.0' encoding='UTF-8'?><rt><tid>" + entity.TID + @"</tid><uname>" + entity.UName + @"</uname><pwd>" + entity.PWD + @"</pwd><device>" + entity.Device + @"</device><cid>" + entity.CID + @"</cid><warehouseid>" + entity.WareHouseId + @"</warehouseid><code>" + entity.TaskNo + @"</code></rt>";

            string result = service.getJhOutstockById(param);

            XmlDocument xml = new XmlDocument();

            xml.LoadXml(result);

            string returncode = xml.SelectSingleNode("rt/rc").InnerText;

            if (returncode == "0000")
            {
                #region 获取订单号列表
                XmlNodeList nodeList = xml.SelectNodes("rt/jhoutstocks/outstock");
                List<OrderMasterEntity> list1 = null;
                List<OrderItemEntity> list2 = null;
                StringBuilder sb = new StringBuilder();
                sb.Append("<?xml version='1.0' encoding='UTF-8'?>");
                sb.Append("<rt><tid>" + entity.TID + @"</tid><uname>" + entity.UName + @"</uname><pwd>" + entity.PWD + @"</pwd><device>" + entity.Device + @"</device><cid>" + entity.CID + @"</cid><warehouseid>" + entity.WareHouseId + @"</warehouseid>");
                sb.Append("<id>");

                OrderMasterEntity orderMaster = null;

                list1 = new List<OrderMasterEntity>(nodeList.Count);

                foreach (XmlNode node in nodeList)
                {
                    orderMaster = new OrderMasterEntity();
                    orderMaster.dispatchcode = node.SelectSingleNode("dispatchcode").InnerText;
                    orderMaster.id = node.SelectSingleNode("id").InnerText;
                    orderMaster.num = node.SelectSingleNode("num").InnerText;
                    orderMaster.ordercode = node.SelectSingleNode("ordercode").InnerText;
                    orderMaster.taskid = node.SelectSingleNode("taskid").InnerText;
                    orderMaster.tousername = node.SelectSingleNode("tousername").InnerText;
                    list1.Add(orderMaster);

                    sb.Append("<outstockid>" + orderMaster.id + "</outstockid>");
                }

                sb.Append("</id></rt>");
                #endregion

                #region 通过订单号列表获取商品明细

                result = service.getTaskDByIds(sb.ToString());

                xml.LoadXml(result);

                returncode = xml.SelectSingleNode("rt/rc").InnerText;

                if (returncode == "0000")
                {
                    nodeList = xml.SelectNodes("rt/taskds/taskd");

                    OrderItemEntity orderItem = null;

                    list2 = new List<OrderItemEntity>(nodeList.Count);

                    foreach (XmlNode node in nodeList)
                    {
                        orderItem = new OrderItemEntity();
                        orderItem.amount = node.SelectSingleNode("amount").InnerText;
                        orderItem.cbarcode = node.SelectSingleNode("cbarcode").InnerText;
                        orderItem.doneamount = node.SelectSingleNode("doneamount").InnerText;
                        orderItem.fromitemcode = node.SelectSingleNode("fromitemcode").InnerText;
                        orderItem.num = node.SelectSingleNode("num").InnerText;
                        orderItem.outerid = node.SelectSingleNode("outerid").InnerText;
                        orderItem.shortname = node.SelectSingleNode("shortname").InnerText;
                        orderItem.taskdid = node.SelectSingleNode("taskdid").InnerText;
                        orderItem.taskid = node.SelectSingleNode("taskid").InnerText;

                        list2.Add(orderItem);

                    }
                }

                #endregion

                entity.OrderMasterList = list1.ToArray();
                entity.OrderItemList = list2.ToArray();

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
