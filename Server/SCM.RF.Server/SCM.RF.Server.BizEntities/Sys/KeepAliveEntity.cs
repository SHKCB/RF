using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SCM.RF.Server.BizEntities.Sys
{
    public class KeepAliveEntity
    {
        public KeepAliveEntity() { }

        /// <summary>
        /// 主键
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool Success { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Message { get; set; }
    }
}
