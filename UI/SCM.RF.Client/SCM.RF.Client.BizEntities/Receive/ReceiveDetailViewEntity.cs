
using SCM.RF.Client.BizEntities.Sys;
namespace SCM.RF.Client.BizEntities.Receive
{
    public class ReceiveDetailViewEntity:BaseViewEntity
    {

        /// <summary>
        /// 构造
        /// </summary>
        public ReceiveDetailViewEntity(BaseViewEntity entity) 
        {
            this.CID = entity.CID;
            this.UName = entity.UName;
            this.PWD = entity.PWD;
            this.WareHouseId = entity.WareHouseId;
        }

        public string Did { get; set; }

        public string GName { get; set; }

        public string Outerid { get; set; }

        public string Cbarcode { get; set; }

        public string Spec { get; set; }

        public string Planamount { get; set; }

        public string Arrvaltime { get; set; }

        public string Arrvalamount { get; set; }

        public string Failnum { get; set; }

        public string Protime { get; set; }

    }
}
