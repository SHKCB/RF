using System;
using System.Reflection;
using System.Xml;

namespace SCM.RF.Server.Utility
{
    /// <summary>
    /// xml操作
    /// </summary>
    public class XmlHelper<T>
    {
        /// <summary>
        /// 通过XML 获取实体类
        /// </summary>
        /// <param name="doc"></param>
        /// <returns></returns>
        public T GetEntity(XmlDocument doc)
        {
            //跟节点
            XmlNode root = doc.DocumentElement;

            //所有子节点
            XmlNodeList nodeList = root.ChildNodes;

            Type type = typeof(T);

            T entity = (T)Activator.CreateInstance(type);

            if (type == null)
            {
                return default(T);
            }

            System.Reflection.PropertyInfo[] properties = type.GetProperties();

            object value = new object();

            //遍历实体类 成员
            foreach (System.Reflection.PropertyInfo property in properties)
            {
                //遍历xml节点
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

        public T GetEntityByNode(T t, XmlNode node)
        {
            XmlNodeList nodes = node.ChildNodes;
            PropertyInfo[] properties = t.GetType().GetProperties();

            for (int i = 0; i < properties.Length; i++)
            {
                try { properties[i].SetValue(t, node[properties[i].Name.ToLower()].InnerText, null); }
                catch { properties[i].SetValue(t, "", null); }
                
            }

            return t;
        }
    }
}
