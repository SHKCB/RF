
namespace SCM.RF.Client.BizEntities.Sys
{
   public class BaseViewEntity
    {
       public string TID { get; set; }

       public string CID { get; set; }

       public string UName { get; set; }

       public string PWD { get; set; }

       /// <summary>
       /// 返回值
       /// </summary>
       public bool Success
       {
           get;
           set;
       }

       /// <summary>
       /// 返回值对应的信息
       /// </summary>
       public string Message
       {
           get;
           set;
       }
    }
}
