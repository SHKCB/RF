using System;
using System.Xml;

namespace SCM.RF.Client.Utility
{
    /// <summary>
    /// xml����
    /// </summary>
    public class XmlHelper<T>
    {
        /// <summary>
        /// ͨ��XML ��ȡʵ����
        /// </summary>
        /// <param name="doc"></param>
        /// <returns></returns>
        public T GetEntity(XmlDocument doc)
        {
            //���ڵ�
            XmlNode root = doc.DocumentElement;

            //�����ӽڵ�
            XmlNodeList nodeList = root.ChildNodes;

            Type type = typeof(T);

            T entity = (T)Activator.CreateInstance(type);

            if (type == null)
            {
                return default(T);
            }

            System.Reflection.PropertyInfo[] properties = type.GetProperties();

            object value = new object();

            //����ʵ���� ��Ա
            foreach (System.Reflection.PropertyInfo property in properties)
            {
                //����xml�ڵ�
                foreach (XmlNode node in nodeList)
                {
                    if (node != null && string.Equals(node.Name.ToUpper(), property.Name.ToUpper(), StringComparison.Ordinal))
                    {
                        if (property.PropertyType.Equals(typeof(string)))
                        {
                            value = node.InnerText.Trim().ToString();
                        }
                        else if (property.PropertyType.Equals(typeof(int)))
                        {
                            value = Convert.ToInt32(node.InnerText.Trim().ToString());
                        }
                        else
                        {
                            continue;
                        }

                        property.SetValue(entity, value, null);

                    }
                }
            }

            return entity;
        }
    }
}
