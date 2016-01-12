using SCM.RF.Client.BizEntities.AuthCenter;
using SCM.RF.Server.BizEntities.Pick;
using SCM.RF.Server.BizEntities.Receive;
using SCM.RF.Server.BizEntities.Sys;
using SCM.RF.Server.BizProcess.Login;
using SCM.RF.Server.BizProcess.Receive;
using SCM.RF.Server.Framework.Net;
using SCM.RF.Server.Utility;

namespace SCM.RF.Server.Framework.Commond
{
    /// <summary>
    /// 执行命令
    /// </summary>
    public class CommandManage
    {
        private bool _CloseUser;

        private System.Text.Encoding _Encoding = System.Text.Encoding.GetEncoding("GB2312");

        public bool CloseUser
        {
            get
            {
                return this._CloseUser;
            }
            set
            {
                this._CloseUser = true;
            }
        }

        public CommandManage()
        {
        }

        public string Proc(string receive)
        {
            string result = string.Empty;

            RequestHandler handler = new RequestHandler();

            string[] array = handler.GetActualString(receive);

            foreach (string item in array)
            {
                string action = item.Substring(0, 4);
                string content = item.Substring(4);

                //登录
                if (action == "0000")
                {
                    result = LoginIn(content);
                }
                else if (action == "1001")
                {
                    result = GetReceiveDetail(content);
                }
                //else if (action == "0002")
                //{
                //    result = CellSelect(content);
                //}
                //else if (action == "0003")
                //{
                //    result = CellPalSelect(content);
                //}
                //else if (action == "0004")
                //{
                //    result = PalSelect(content);
                //}
                //else if (action == "0005")
                //{
                //    result = ProductSelect(content);
                //}
                //else if (action == "0006")
                //{
                //    result = CellPalSelectByCell(content);
                //}
                //else if (action == "0009")
                //{
                //    result = KeepAlive(content);
                //}
                //else if (action == "1000")
                //{
                //    result = ASNEntitySelete(content);
                //}
                //else if (action == "1001")
                //{
                //    result = BoxSerialInsert(content);
                //}
                //else if (action == "1002")
                //{
                //    result = ASNBoxSerialInsert(content);
                //}
                //else if (action == "1003")
                //{
                //    result = BoxSerialEntitySelete(content);
                //}
                //else if (action == "1004")
                //{
                //    result = CheckInInsert(content);
                //}
                //else if (action == "1005")
                //{
                //    result = BoxSerialEntityUpdate(content);
                //}
                //else if (action == "1006")
                //{
                //    result = ASNEntityUpdate(content);
                //}
                //else if (action == "1007")
                //{
                //    result = CheckInDelete(content);
                //}
                //else if (action == "1008")
                //{
                //    result = ASNBoxSerialDelete(content);
                //}
                //else if (action == "1009")
                //{
                //    result = CheckInUpdate(content);
                //}
                //else if (action == "1010")
                //{
                //    result = CheckInReset(content);
                //}
                //else if (action == "1011")
                //{
                //    result = BoxSerialEntityUnBoxSelete(content);
                //}
                //else if (action == "3000")
                //{
                //    result = PutawaySelete(content);
                //}
                //else if (action == "3001")
                //{
                //    result = PutawayInsert(content);
                //}
                else if (action == "4001")
                {
                    result = GetPick(content);
                }
                //else if (action == "4002")
                //{
                //    result = TransferItemInsert(content);
                //}
                //else if (action == "4003")
                //{
                //    result = TransferMasterUpdate(content);
                //}
                //else if (action == "4004")
                //{
                //    result = TransferItemDelete(content);
                //}
                //else if (action == "4005")
                //{
                //    result = INSelect(content);
                //}
                //else if (action == "4006")
                //{
                //    result = INInsert(content);
                //}
                //else if (action == "4007")
                //{
                //    result = TransferMasterSelect(content);
                //}
                //else if (action == "4008")
                //{
                //    result = TransferItemInsert2(content);
                //}
                //else if (action == "4009")
                //{
                //    result = TransferItemDelete2(content);
                //}
                //else if (action == "4010")
                //{
                //    result = InItemDelete(content);
                //}
                //else if (action == "4011")
                //{
                //    result = INUpdate(content);
                //}
                //else if (action == "4012")
                //{
                //    result = TransferMasterChange(content);
                //}
                //else if (action == "4013")
                //{
                //    result = InItemUpdate(content);
                //}
                //else if (action == "4014")
                //{
                //    result = XTransferUpdate(content);
                //}
                //else if (action == "5000")
                //{
                //    result = CCSelect(content);
                //}
                //else if (action == "5001")
                //{
                //    result = CCLogInsert(content);
                //}
                //else if (action == "5002")
                //{
                //    result = CCInsert(content);
                //}
                //else if (action == "5003")
                //{
                //    result = CCReset(content);
                //}
                //else if (action == "5004")
                //{
                //    result = CCUpdate(content);
                //}
                //else if (action == "5005")
                //{
                //    result = CCDelete(content);
                //}
                //else if (action == "5006")
                //{
                //    result = CCItemInsert(content);
                //}
                //else if (action == "6000")
                //{
                //    result = LabelSelect(content);
                //}
                //else if (action == "6001")
                //{
                //    result = MulUpdate(content);
                //}
                //else if (action == "6002")
                //{
                //    result = LabelUpdate(content);
                //}
                //else if (action == "6003")
                //{
                //    result = BadInsert(content);
                //}
                //else if (action == "6004")
                //{
                //    result = MulReset(content);
                //}
                //else if (action == "7000")
                //{
                //    result = SchemeSelect(content);
                //}
                //else if (action == "7001")
                //{
                //    result = HandOverInsert(content);
                //}
                //else if (action == "7002")
                //{
                //    result = HandOverItemInsert(content);
                //}
                //else if (action == "7003")
                //{
                //    result = HandOverItemInsertByOld(content);
                //}
                else if (action == "9999")
                {
                    result = LoginOut(content);
                }
                else
                { }
            }

            return result;
        }

        #region 登录
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="receive"></param>
        /// <returns></returns>
        private string LoginIn(string receive)
        {
            UserViewEntity param = SerializeHelper.Deserialize<UserViewEntity>(receive);

            UserViewEntity entity = new LoginBP().Login(param);

            string result = SerializeHelper.Serialize(entity);

            return result;
        }

        /// <summary>
        /// 心跳
        /// </summary>
        /// <param name="receive"></param>
        /// <returns></returns>
        private string KeepAlive(string receive)
        {
            KeepAliveEntity param = SerializeHelper.Deserialize<KeepAliveEntity>(receive);

            KeepAliveEntity entity = new KeepAliveEntity();

            entity.Success = true;

            entity.Message = string.Empty;

            entity.UserName = string.Empty;

            string result = SerializeHelper.Serialize(entity);

            return result;
        }
        #endregion

        #region 收货

        private string GetReceiveDetail(string receive)
        {
            ReceiveHeaderViewEntity param = SerializeHelper.Deserialize<ReceiveHeaderViewEntity>(receive);

            ReceiveHeaderViewEntity entity = new ReceiveBP().GetReceiveDetail(param);

            string result = SerializeHelper.Serialize(entity);

            return result;
        }


        #endregion

        #region 拣货

        private string GetPick(string receive)
        {
            //PickEnity param = SerializeHelper.Deserialize<PickEnity>(receive);

            //PickEnity entity = new ReceiveBP().GetReceiveDetail(param);

            //string result = SerializeHelper.Serialize(entity);

            //return result;


            return "";
        }

        #endregion

        #region 退出系统

        private string LoginOut(string receive)
        {
            UserViewEntity param = SerializeHelper.Deserialize<UserViewEntity>(receive);

            UserViewEntity entity = new LoginBP().LoginOut(param);

            string result = SerializeHelper.Serialize(entity);

            return result;

            //UserViewEntity entity = SerializeHelper.Deserialize<UserViewEntity>(receive);

            //entity.IsLoggedIn = false;

            //_CloseUser = true;

            //string result = SerializeHelper.Serialize(entity);

            //return result;
        }

        #endregion
    }
}
