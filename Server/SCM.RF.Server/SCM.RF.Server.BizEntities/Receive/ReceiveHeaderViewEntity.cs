using SCM.RF.Server.BizEntities.Sys;

namespace SCM.RF.Server.BizEntities.Receive
{
    public class ReceiveHeaderViewEntity : BaseViewEntity
    {
        /// <summary>
        /// 构造
        /// </summary>
        public ReceiveHeaderViewEntity() { }

        public string Instockcode { get; set; }

        public ReceiveDetailViewEntity[] Detail { get; set; }
    }
}
