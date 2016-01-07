using SCM.RF.Client.BizEntities.BasicData.Product;
using SCM.RF.Client.Framework.Core;

namespace SCM.RF.Client.BizProcess.BaseData.Product
{
    public class ProductBP
    {
        /// <summary>
        /// 通过条码查询商品信息
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="remote"></param>
        /// <returns></returns>
        public ProductViewEntity GetEntity(ProductViewEntity entity, RemoteServer remote)
        {
            entity = remote.Commond<ProductViewEntity>(entity, "0005");

            return entity;
        }
    }
}
