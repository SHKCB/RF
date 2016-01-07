using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using System.Xml;
using System.Threading;

namespace SCM.RF.Client.AutoUpdate
{
    public partial class Update : Form
    {
        private SystemEntity _SystemEntity = null;

        private long totalBytes = 0;

        private long totalDownloadedByte = 0;

        public Update()
        {
            this._SystemEntity = getEntity();

            InitializeComponent();
        }

        private void Update_Load(object sender, EventArgs e)
        {
            this.Show();

            Application.DoEvents();

            Proc();
        }

        /// <summary>
        /// 开始处理
        /// </summary>
        private void Proc()
        {
            Thread.Sleep(5000);

            string content = string.Empty;

            try
            {
                System.Net.WebRequest request = System.Net.WebRequest.Create(new Uri(this._SystemEntity.UpUrl + "AutoUpdate.ashx"));

                System.Net.WebResponse response = request.GetResponse();

                System.IO.Stream stream = response.GetResponseStream();

                StreamReader reader = new StreamReader(stream);

                content = reader.ReadToEnd();

                stream.Flush();

                reader.Close();

                stream.Close();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);

                Application.Exit();
            }

            XmlDocument doc = new XmlDocument();

            doc.LoadXml(content);

            string server = doc.SelectSingleNode("AutoUpdate/UpDate").InnerText.Trim();

            string subPath = doc.SelectSingleNode("AutoUpdate/UpPath").InnerText.Trim();

            string filepath = string.Concat(Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase), @"\");

            totalBytes = long.Parse(doc.SelectSingleNode("AutoUpdate/UpSize").InnerText.Trim());

            if (pbTotal != null)
            {
                pbTotal.Maximum = (int)totalBytes;
            }

            //更新文件
            XmlNodeList list = doc.SelectNodes("AutoUpdate/UpFiles/Item");

            foreach (XmlNode node in list)
            {
                string url = this._SystemEntity.UpUrl + subPath + @"/" + node.InnerText.Trim();

                DownloadFile(url, filepath + node.InnerText.Trim(), node.Attributes[0].Value);
            }

            saveEntity(server);

            StartApp();
        }

        #region 读取XML配置

        /// <summary>
        /// 读取配置
        /// </summary>
        /// <returns></returns>
        private SystemEntity getEntity()
        {
            string path = string.Concat(Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase), @"\app.xml");

            XmlDocument doc = new XmlDocument();

            doc.Load(path);

            SystemEntity entity = new SystemEntity();
            entity.UpUrl = doc.SelectSingleNode("app/UpUrl").InnerText;
            entity.UpDate = doc.SelectSingleNode("app/UpDate").InnerText;

            return entity;
        }

        #endregion

        #region 保存XML配置文件

        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="vision"></param>
        private void saveEntity(string vision)
        {
            string path = string.Concat(Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase), @"\app.xml");

            path = path.Replace(@"file:\", "");

            XmlDocument doc = new XmlDocument();

            doc.Load(path);

            doc.SelectSingleNode("app/UpDate").InnerText = vision;

            doc.Save(path);
        }
        #endregion

        #region 下载文件

        /// <summary>
        /// 下载文件
        /// </summary>
        /// <param name="URL"></param>
        /// <param name="filename"></param>
        /// <param name="size"></param>
        private void DownloadFile(string URL, string filename, string size)
        {
            filename = filename.Replace(".bak", "").Replace(@"file:\", "");

            string dir = Path.GetDirectoryName(filename);

            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            int curt = 0;

            int length = 0;

            float percent = 0;

            try
            {
                System.Net.HttpWebRequest Myrq = (System.Net.HttpWebRequest)System.Net.HttpWebRequest.Create(URL);

                System.Net.HttpWebResponse myrp = (System.Net.HttpWebResponse)Myrq.GetResponse();

                System.IO.Stream st = myrp.GetResponseStream();

                length = int.Parse(size);

                if (pbCurt != null)
                {
                    pbCurt.Maximum = length;

                    pbCurt.Value = curt;
                }

                Application.DoEvents();

                System.IO.Stream so = new System.IO.FileStream(filename, System.IO.FileMode.Create);

                byte[] by = new byte[1024];

                int osize = st.Read(by, 0, (int)by.Length);

                while (osize > 0)
                {
                    totalDownloadedByte = osize + totalDownloadedByte;

                    curt += osize;

                    so.Write(by, 0, osize);

                    if (pbCurt != null)
                    {
                        pbCurt.Value = (int)curt;
                    }

                    if (pbTotal != null)
                    {
                        pbTotal.Value = (int)totalDownloadedByte;
                    }

                    osize = st.Read(by, 0, (int)by.Length);

                    percent = (float)totalDownloadedByte / (float)totalBytes * 100;

                    lbProc.Text = "进度：" + percent.ToString("#.##") + "%";

                    Application.DoEvents();
                }

                so.Close();

                st.Close();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);

                Application.Exit();
            }
        }

        #endregion

        #region 启动程序
        /// <summary>
        /// 启动程序
        /// </summary>
        private void StartApp()
        {
            try
            {
                string path = Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase), "SCM.RF.Client.Tool.exe");

                path = path.Replace(@"file:\", "");

                if (File.Exists(path))
                {
                    Process process = new Process();
                    ProcessStartInfo info = new ProcessStartInfo();
                    info.FileName = path;
                    process.StartInfo = info;
                    process.Start();
                    Application.Exit();
                }
                else
                {
                    MessageBox.Show("没有找到主程序，启动失败！");

                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                Application.Exit();
            }
        }

        #endregion
    }

    public class SystemEntity
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public SystemEntity()
        {

        }

        /// <summary>
        /// IP地址
        /// </summary>
        public string ServerIp
        {
            get;
            set;
        }

        /// <summary>
        /// 端口号
        /// </summary>
        public int ServerPort
        {
            get;
            set;
        }

        /// <summary>
        /// 系统编号
        /// </summary>
        public string ApplicationID
        {
            get;
            set;
        }

        /// <summary>
        /// 商品缓存文件路径
        /// </summary>
        public string ProductPath
        {
            get;
            set;
        }

        /// <summary>
        /// 商品缓存版本
        /// </summary>
        public string ProductVersion
        {
            get;
            set;
        }

        /// <summary>
        /// 最后更新时间
        /// </summary>
        public string UpDate { get; set; }

        /// <summary>
        /// 更新地址
        /// </summary>
        public string UpUrl { get; set; }

        /// <summary>
        /// 更新程序的路径
        /// </summary>
        public string UpExe { get; set; }
    }
}