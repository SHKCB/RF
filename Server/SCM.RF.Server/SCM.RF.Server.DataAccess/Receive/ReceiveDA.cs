using SCM.RF.Server.BizEntities.Receive;
using System.Xml;

namespace SCM.RF.Server.DataAccess.Receive
{
    public class ReceiveDA
    {
        public static ReceiveHeaderViewEntity GetReceiveDetail(ref ReceiveHeaderViewEntity entity)
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
            <rt>
              <tid>20160113105010820</tid>
              <warehouseid>47a7377d4a9e42e3a665af0894946e21</warehouseid>
              <rc>0000</rc>
              <rm>�ɹ�</rm>
              <instockdetails>
                <instockdetail>
                  <outerid>MJ4-01A</outerid>
                  <pres>��</pres>
                  <cbarcode>MJ4-01A</cbarcode>
                  <planamount>5</planamount>
                  <waitamount>5</waitamount>
                  <waittxj>0/0/5</waittxj>
                  <plantxj>0/0/5</plantxj>
                  <param1></param1>
                  <param2></param2>
                  <param3></param3>
                  <param4></param4>
                  <param5></param5>
                  <param6></param6>
                  <param7></param7>
                  <param8></param8>
                  <gname>���׷�������ħ��4�� �����۾� 3D������ʵ�۾�VR�۾��ֻ�ͷ�� ��׿��</gname>
                  <goodsid>53d500e9df8b4ec1a69808d09c72b378</goodsid>
                  <stockstatus>ZC</stockstatus>
                  <inserial>false</inserial>
                  <instockid>e2358a9891144cdc92da9692ec26dcf0</instockid>
                  <instockdetailid>525f6676f6c443d3ae9866f5e0d9350d</instockdetailid>
                  <instockrule>7607ad5822ff485bb7e272810e6a74e2</instockrule>
                </instockdetail>
              </instockdetails>
            </rt>
             */

            string returncode = doc.SelectSingleNode("rt/rc").InnerText;

            if (returncode == "0000")
            {
                XmlNodeList detail = doc.SelectNodes("rt/instockdetails/instockdetail");

                entity.Detail = new ReceiveDetailViewEntity[detail.Count];

                ReceiveDetailViewEntity detailitem;

                for (int i = 0; i < detail.Count; i++)
                {
                    detailitem = new ReceiveDetailViewEntity();

                    detailitem = new SCM.RF.Server.Utility.XmlHelper<ReceiveDetailViewEntity>().GetEntityByNode(detailitem, detail[i]);

                    entity.Detail[i] = detailitem;
                }

                entity.Success = true;
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
