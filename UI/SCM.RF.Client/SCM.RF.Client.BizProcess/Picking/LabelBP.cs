using SCM.RF.Client.BizEntities.Picking;
using SCM.RF.Client.Framework.Core;

namespace SCM.RF.Client.BizProcess.Picking
{
    public class LabelBP
    {
        /// <summary>
        /// 根据集合单号和容器号，进行绑定 
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="remote"></param>
        /// <returns></returns>
        public LabelViewEntity GetEntity(LabelViewEntity entity, RemoteServer remote)
        {
            entity = remote.Commond<LabelViewEntity>(entity, "6000");

            return entity;
        }

        /// <summary>
        /// 拣货
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="remote"></param>
        /// <returns></returns>
        public MulViewEntity Update(MulViewEntity entity, RemoteServer remote)
        {
            entity = remote.Commond<MulViewEntity>(entity, "6001");

            return entity;
        }

        /// <summary>
        /// 完结
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="remote"></param>
        /// <returns></returns>
        public LabelViewEntity Update(LabelViewEntity entity, RemoteServer remote)
        {
            entity = remote.Commond<LabelViewEntity>(entity, "6002");

            return entity;
        }

        /// <summary>
        /// 病单
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="remote"></param>
        /// <returns></returns>
        public BadViewEntity Insert(BadViewEntity entity, RemoteServer remote)
        {
            entity = remote.Commond<BadViewEntity>(entity, "6003");

            return entity;
        }

        /// <summary>
        /// 重定位
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="remote"></param>
        /// <returns></returns>
        public MulViewEntity Reset(MulViewEntity entity, RemoteServer remote)
        {
            entity = remote.Commond<MulViewEntity>(entity, "6004");

            return entity;
        }
    }
}
