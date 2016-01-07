using System.IO;
using System.Text;

namespace SCM.RF.Server.Utility
{
    /// <summary>
    /// 日志
    /// </summary>
    public class IOHelper
    {
        /// <summary>
        /// 写文件
        /// </summary>
        /// <param name="path"></param>
        /// <param name="content"></param>
        public static void WriteFile(string path, string content, bool append)
        {
            try
            {
                if (!Directory.Exists(Path.GetDirectoryName(path)))
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(path));
                }

                if (!File.Exists(path))
                {
                    FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None);

                    fs.Close();
                }

                using (StreamWriter writer = new StreamWriter(path, append, System.Text.Encoding.UTF8))
                {
                    writer.WriteLine(content);

                    writer.Flush();

                    writer.Close();
                }
            }
            catch
            { }
        }

        /// <summary>
        /// 读文件
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static string ReadFile(string path)
        {
            StringBuilder sb = new StringBuilder();

            FileStream file = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read);

            string line = string.Empty;

            using (StreamReader sr = new StreamReader(file, System.Text.Encoding.GetEncoding("GB2312")))
            {
                do
                {
                    line = sr.ReadLine();

                    if (line != null)
                    {
                        sb.Append(line);
                    }
                }

                while (line != null);

                sr.Close();
            }

            file.Close();

            return sb.ToString();
        }
    }
}
