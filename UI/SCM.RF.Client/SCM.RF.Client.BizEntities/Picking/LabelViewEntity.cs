namespace SCM.RF.Client.BizEntities.Picking
{
    /// <summary>
    /// 集合单
    /// </summary>
    public class LabelViewEntity
    {
        /// <summary>
        /// 主键
        /// </summary>
        public int SysNo { get; set; }

        /// <summary>
        /// 外键
        /// </summary>
        public int MasterSysNo { get; set; }

        /// <summary>
        /// 任务编号
        /// </summary>
        public int TaskSysNo { get; set; }

        /// <summary>
        /// 任务号
        /// </summary>
        public string TaskNO { get; set; }

        /// <summary>
        /// 容器号
        /// </summary>
        public int ContainerSysNo { get; set; }

        /// <summary>
        /// 容器
        /// </summary>
        public string ContainerID { get; set; }

        /// <summary>
        /// 集合单号
        /// </summary>
        public string LabelNO { get; set; }

        /// <summary>
        /// 操作人
        /// </summary>
        public string InUser { get; set; }

        /// <summary>
        /// A - 待拣货；B - 捡货中；C - 拣货完成；D - 无效 
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// 拣货明细
        /// </summary>
        public MulViewEntity[] ItemList { get; set; }

        /// <summary>
        /// 返回值
        /// </summary>
        public bool Success { get; set; }

        /// <summary>
        /// 返回值对应的信息
        /// </summary>
        public string Message { get; set; }
    }
}
