using System;

namespace SCM.RF.Client.BizEntities.BasicData.Product
{
    /// <summary>
    /// ��Ʒ����ʵ��
    /// </summary>
    /// 
    public class ProductViewEntity
    {
        /// <summary>
        /// ���캯��
        /// </summary>
        public ProductViewEntity() { }

        /// <summary>
        /// ��Ʒ����
        /// </summary>
        public int SysNo
        {
            get;
            set;
        }

        /// <summary>
        /// ����
        /// </summary>
        public string BarCode
        {
            get;
            set;
        }

        /// <summary>
        /// ��Ʒ����
        /// </summary>
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        /// ����
        /// </summary> 
        public string Size
        {
            get;
            set;
        }

        /// <summary>
        /// ��ɫ
        /// </summary>
        public string Color
        {
            get;
            set;
        }

        /// <summary>
        /// �Ƿ�����SN 0 - Ĭ�ϣ� 1 - ���кŹ��� 2 - �����кŹ���
        /// </summary>
        public string Serial
        {
            get;
            set;
        }

        /// <summary>
        /// ���
        /// </summary>
        //public decimal Volume
        //{
        //    get;
        //    set;
        //}

        public bool Success { get; set; }

        public string Message { get; set; }
    }
}
