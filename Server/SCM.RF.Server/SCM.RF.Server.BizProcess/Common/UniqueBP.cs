using SCM.RF.Server.DataAccess.Common;

/*
 * 取唯一值
 * Add by [火狐] [2012-3-8]
 * Edit by [花名] [时间] [原因]
 */
namespace SCM.RF.Server.BizProcess.Common
{
    public static class UniqueBP
    {
        private static int _Unique = 0;

        /// <summary>
        /// 唯一值
        /// </summary>
        public static int Unique
        {
            get
            {
                if (_Unique == 0)
                {
                    _Unique = GetUnique();

                    _Unique += 1000;

                    UpdateUnique(_Unique);
                }

                _Unique += 1;

                if (_Unique % 1000 == 0)
                {
                    UpdateUnique(_Unique);
                }

                return _Unique;
            }
        }

        /// <summary>
        /// 更新回数据库
        /// </summary>
        /// <param name="UniqueID"></param>
        private static void UpdateUnique(int UniqueID)
        {
            UniqueDA.UpdateUnique(UniqueID);
        }

        /// <summary>
        /// 读取数据库中的值
        /// </summary>
        /// <returns></returns>
        private static int GetUnique()
        {
            return UniqueDA.GetUnique();
        }
    }
}
