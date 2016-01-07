using SCM.RF.Client.BizEntities.HandOver;
using SCM.RF.Client.Framework.Core;

namespace SCM.RF.Client.BizProcess.HandOver
{
    public class SchemeBP
    {
        /// <summary>
        /// 7000 取快递方案列表
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="remote"></param>
        /// <returns></returns>
        public SchemeViewEntity GetEntity(SchemeViewEntity entity, RemoteServer remote)
        {
            entity = remote.Commond<SchemeViewEntity>(entity, "7000");

            return entity;
        }
    }
}
