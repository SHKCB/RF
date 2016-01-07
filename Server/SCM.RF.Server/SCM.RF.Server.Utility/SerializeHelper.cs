using System;
using System.Text;
using System.Reflection;
using System.Collections;

namespace SCM.RF.Server.Utility
{
    /// <summary>
    /// 序列号
    /// </summary>
    public class SerializeHelper
    {
        //public static string Serialize(object obj)
        //{
        //    //return Converter.Serialize(obj);
        //}

        /// <summary>
        /// Deserialize json string to object.
        /// </summary>
        /// <typeparam name="T">The type to be deserialized.</typeparam>
        /// <param name="jsonString">json string.</param>
        /// <returns>instance of type T.</returns>
        //public static T Deserialize<T>(string jsonString)
        //{
        //    //return Converter.Deserialize<T>(jsonString);
        //}

        /// <summary>
        /// 序列化
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string Serialize(object obj)
        {
            if (obj == null)
            {
                return "{}";
            }

            return Serialize(obj, ",");
        }

        /// <summary>
        /// 序列化
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="quot"></param>
        /// <returns></returns>
        private static string Serialize(object obj, string quot)
        {
            if (obj == null)
            {
                return "{}";
            }

            Type type = obj.GetType();

            BindingFlags bind = BindingFlags.Instance | BindingFlags.Public;

            PropertyInfo[] pis = type.GetProperties(bind);

            StringBuilder json = new StringBuilder("{");

            if (pis != null && pis.Length > 0)
            {
                int i = 0;

                int lastIndex = pis.Length - 1;

                foreach (PropertyInfo p in pis)
                {
                    if (p.PropertyType.Equals(typeof(string)))
                    {
                        json.AppendFormat("\"{0}\":\"{1}\"", p.Name, p.GetValue(obj, null));
                    }

                    #region
                    else if (p.PropertyType.Equals(typeof(int)) || p.PropertyType.Equals(typeof(bool)))
                    {
                        json.AppendFormat("\"{0}\":{1}", p.Name, p.GetValue(obj, null).ToString().ToLower());
                    }
                    #endregion

                    else if (isArrayType(p.PropertyType))
                    {
                        object o = p.GetValue(obj, null);

                        if (o == null)
                        {
                            json.AppendFormat("\"{0}\":{1}", p.Name, "null");
                        }
                        else
                        {
                            json.AppendFormat("\"{0}\":{1}", p.Name, getArrayValue((Array)p.GetValue(obj, null)));
                        }
                    }
                    else if (p.PropertyType.Equals(typeof(DateTime)))
                    {
                        DateTime dt = (DateTime)p.GetValue(obj, null);

                        if (dt == default(DateTime))
                        {
                            json.AppendFormat("\"{0}\":\"\"", p.Name);
                        }
                        else
                        {
                            json.AppendFormat("\"{0}\":\"{1}\"", p.Name, ((DateTime)p.GetValue(obj, null)).ToString("yyyyMMddHHmmss"));
                        }
                    }
                    #region
                    //else if (isCustomClassType(p.PropertyType))
                    //{
                    //    object v = p.GetValue(obj, null);
                    //    if (v is IList)
                    //    {
                    //        IList il = v as IList;

                    //        string subJsString = getIListValue(il);

                    //        json.AppendFormat("\"{0}\":{1}", p.Name, subJsString);
                    //    }
                    //    else
                    //    {
                    //        string subJsString = Serialize(p.GetValue(obj, null));

                    //        json.AppendFormat("\"{0}\":{1}", p.Name, subJsString);
                    //    }
                    //}
                    //else if (p.PropertyType.Equals(typeof(DateTime)))
                    //{
                    //    DateTime dt = (DateTime)p.GetValue(obj, null);

                    //    if (dt == default(DateTime))
                    //    {
                    //        json.AppendFormat("\"{0}\":\"\"", p.Name);
                    //    }
                    //    else
                    //    {
                    //        json.AppendFormat("\"{0}\":\"{1}\"", p.Name, ((DateTime)p.GetValue(obj, null)).ToString("yyyy-MM-dd HH:mm:ss"));
                    //    }
                    //}
                    #endregion
                    else
                    {
                        // TODO: extend.
                    }

                    if (i >= 0 && i != lastIndex)
                    {
                        //json.Append(",");

                        json.Append(quot);
                    }

                    ++i;
                }
            }

            json.Append("}");

            return json.ToString();
        }

        /// <summary>
        /// Deserialize json string to object.
        /// </summary>
        /// <typeparam name="T">The type to be deserialized.</typeparam>
        /// <param name="jsonString">json string.</param>
        /// <returns>instance of type T.</returns>
        public static T Deserialize<T>(string jsonString)
        {
            Type type = typeof(T);

            if (type == null || jsonString.Length == 0)
            {
                return default(T);
            }

            BindingFlags bind = BindingFlags.Instance | BindingFlags.Public;

            PropertyInfo[] pis = type.GetProperties(bind);

            T entity = (T)Activator.CreateInstance(type);

            jsonString = jsonString.TrimStart('{').TrimEnd('}');//.Substring(1).Substring(0, jsonString.Length - 1);

            string[] fields = jsonString.Split(',');

            //"WkNo":"WkNo"
            string fieldName = string.Empty;
            string fieldValue = string.Empty;
            string[] array = null;
            int indexStart = 0;
            int indexEnd = 0;
            int length = 0;

            string year = string.Empty;
            string month = string.Empty;
            string day = string.Empty;
            string hour = string.Empty;
            string minite = string.Empty;
            string second = string.Empty;
            string datetime = string.Empty;

            foreach (string item in fields)
            {
                //自定义类
                //"RightList":[{"SysNo":"1"@"Key":"Key1"@"Name":"Name1"}#{"SysNo":"2"@"Key":"Key2"@"Name":"Name2"}]
                //"BarCodes":["A"#"B"]
                //"datetime":"yyyy-MM-dd HH:mm:ss",
                if (item.IndexOf('[') > 0)
                {
                    fieldName = item.Substring(1, item.IndexOf(':') - 2);

                    indexStart = item.IndexOf('[') + 1;

                    indexEnd = item.LastIndexOf(']');

                    length = indexEnd - indexStart;

                    fieldValue = item.Substring(indexStart, length);
                }
                else
                {
                    //"WkNo":"WkNo",
                    fieldName = item.Split(':')[0].Replace("\"", "");

                    fieldValue = item.Split(':')[1].Replace("\"", "");
                }

                foreach (PropertyInfo p in pis)
                {
                    if (p.PropertyType.Equals(typeof(string)))
                    {
                        if (string.Equals(fieldName, p.Name))
                        {
                            p.SetValue(entity, fieldValue, null);
                        }
                    }
                    else if (p.PropertyType.Equals(typeof(int)))
                    {
                        if (string.Equals(fieldName, p.Name))
                        {
                            p.SetValue(entity, int.Parse(fieldValue), null);
                        }
                    }
                    else if (p.PropertyType.Equals(typeof(bool)))
                    {
                        if (string.Equals(fieldName, p.Name))
                        {
                            p.SetValue(entity, bool.Parse(fieldValue), null);
                        }
                    }
                    else if (p.PropertyType.Equals(typeof(DateTime)))
                    {

                        if (string.Equals(fieldName, p.Name))
                        {
                            if (fieldValue.Length > 0)
                            {
                                //20120303141516
                                year = fieldValue.Substring(0, 4);
                                month = fieldValue.Substring(4, 2);
                                day = fieldValue.Substring(6, 2);
                                hour = fieldValue.Substring(8, 2);
                                minite = fieldValue.Substring(10, 2);
                                second = fieldValue.Substring(12, 2);

                                datetime = string.Format("{0}-{1}-{2} {3}:{4}:{5}", year, month, day, hour, minite, second);

                                p.SetValue(entity, DateTime.Parse(datetime), null);
                            }
                            else
                            {
                                p.SetValue(entity, DateTime.MinValue, null);
                            }
                        }
                    }
                    else if (isArrayType(p.PropertyType))
                    {
                        if (string.Equals(fieldName, p.Name))
                        {
                            if (isCustomClassType(p.PropertyType))
                            {
                                if (fieldValue != "null" && fieldValue.Length > 0)
                                {
                                    p.SetValue(entity, setArrayValue(p, fieldValue), null);
                                }
                                else
                                {
                                    p.SetValue(entity, null, null);
                                }
                            }
                            else
                            {
                                if (fieldValue != "null" && fieldValue.Length > 0)
                                {
                                    //"A"#"B"
                                    array = fieldValue.Replace("\"", "").Split(new char[] { '#' });

                                    p.SetValue(entity, array, null);
                                }
                                else
                                {
                                    p.SetValue(entity, null, null);
                                }
                            }
                        }
                    }
                    else
                    {

                    }
                }
            }

            return entity;
        }

        //"RightList":[{"SysNo":"1"@"Key":"Key1"@"Name":"Name1"}#{"SysNo":"2"@"Key":"Key2"@"Name":"Name2"}]
        private static object setArrayValue(PropertyInfo p, string jsonString)
        {
            string[] fields = jsonString.Split('#');

            string temp = string.Empty;

            Array array = Array.CreateInstance(p.PropertyType.GetElementType(), fields.Length);

            Type type = p.PropertyType.GetElementType();

            BindingFlags bind = BindingFlags.Instance | BindingFlags.Public;

            PropertyInfo[] pis = type.GetProperties(bind);

            string[] A = null;

            string fieldName = string.Empty;

            string fieldValue = string.Empty;

            for (int i = 0; i < fields.Length; i++)
            {
                //{"SysNo":"1"@"Key":"Key1"@"Name":"Name1"}
                temp = fields[i];

                temp = temp.TrimStart('{').TrimEnd('}'); //temp.Substring(1).Substring(0, temp.Length - 2);

                //因SN码冲突
                //A = temp.Split('@');

                A = temp.Split('%');

                object obj = Activator.CreateInstance(type);

                foreach (string item in A)
                {
                    fieldName = item.Split(':')[0].Replace("\"", "");

                    fieldValue = item.Split(':')[1].Replace("\"", "");

                    foreach (PropertyInfo prop in pis)
                    {
                        if (prop.PropertyType.Equals(typeof(string)))
                        {
                            if (string.Equals(fieldName, prop.Name))
                            {
                                prop.SetValue(obj, fieldValue, null);
                            }
                        }
                        else if (prop.PropertyType.Equals(typeof(int)))
                        {
                            if (string.Equals(fieldName, prop.Name))
                            {
                                prop.SetValue(obj, int.Parse(fieldValue), null);
                            }
                        }
                        else if (prop.PropertyType.Equals(typeof(bool)))
                        {
                            if (string.Equals(fieldName, prop.Name))
                            {
                                prop.SetValue(obj, bool.Parse(fieldValue), null);
                            }
                        }
                        else
                        { }
                    }
                }

                array.SetValue(obj, i);
            }

            return array;
        }

        /// <summary>
        /// Get array json format string value.
        /// </summary>
        /// <param name="obj">array object</param>
        /// <returns>js format array string.</returns>
        private static string getArrayValue(Array obj)
        {
            if (obj != null)
            {
                if (obj.Length == 0)
                {
                    return "[]";
                }

                object firstElement = obj.GetValue(0);

                Type et = firstElement.GetType();

                bool quotable = et == typeof(string);

                StringBuilder sb = new StringBuilder("[");

                int index = 0;

                int lastIndex = obj.Length - 1;

                if (quotable)
                {
                    foreach (var item in obj)
                    {
                        sb.AppendFormat("\"{0}\"", item.ToString());

                        if (index >= 0 && index != lastIndex)
                        {
                            //sb.Append(",");

                            sb.Append("#");
                        }

                        ++index;
                    }
                }
                else
                {
                    foreach (var item in obj)
                    {
                        //string str = Serialize(item, "@");

                        //因SN码冲突
                        string str = Serialize(item, "%");


                        sb.Append(str);

                        if (index >= 0 && index != lastIndex)
                        {
                            //sb.Append(",");

                            sb.Append("#");
                        }

                        ++index;
                    }
                }

                sb.Append("]");

                return sb.ToString();
            }

            return "null";
        }

        #region
        //private static string getIListValue(IList obj)
        //{
        //    if (obj != null)
        //    {
        //        if (obj.Count == 0)
        //        {
        //            return "[]";
        //        }

        //        object firstElement = obj[0];

        //        Type et = firstElement.GetType();

        //        bool quotable = et == typeof(string);

        //        StringBuilder sb = new StringBuilder("[");

        //        int index = 0;

        //        int lastIndex = obj.Count - 1;

        //        if (quotable)
        //        {
        //            foreach (var item in obj)
        //            {
        //                sb.AppendFormat("\"{0}\"", item.ToString());

        //                if (index >= 0 && index != lastIndex)
        //                {
        //                    sb.Append(";");
        //                }

        //                ++index;
        //            }
        //        }
        //        else
        //        {
        //            foreach (var item in obj)
        //            {
        //                sb.Append(item.ToString());

        //                if (index >= 0 && index != lastIndex)
        //                {
        //                    sb.Append(";");
        //                }

        //                ++index;
        //            }
        //        }

        //        sb.Append("]");

        //        return sb.ToString();
        //    }

        //    return "null";
        //}

        #endregion

        /// <summary>
        /// Check whether t is array type.
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        private static bool isArrayType(Type t)
        {
            if (t != null)
            {
                return t.IsArray;
            }

            return false;
        }

        /// <summary>
        /// Check whether t is custom class type.
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        private static bool isCustomClassType(Type t)
        {
            if (t != null)
            {
                return t.IsClass && t != typeof(string) && t != typeof(string[]);
            }

            return false;
        }
    }
}
