using System;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace SCM.RF.Server.Tool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.Description = "选择文件夹";
            folderBrowserDialog1.RootFolder = Environment.SpecialFolder.MyComputer;
            folderBrowserDialog1.ShowNewFolderButton = true;
            if (folderBrowserDialog1.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            string path = folderBrowserDialog1.SelectedPath;

            string[] files = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories);

            string xmlPath = AppDomain.CurrentDomain.BaseDirectory + @"AutoUpdater\AutoUpdate.xml";

            long size = 0;

            XmlDocument doc = new XmlDocument();
            doc.Load(xmlPath);
            doc.SelectSingleNode("AutoUpdate/UpDate").InnerText = DateTime.Now.ToString();
            XmlNode node = doc.SelectSingleNode("AutoUpdate/UpFiles/Item");
            XmlNode nodeParent = doc.SelectSingleNode("AutoUpdate/UpFiles");
            foreach (string file in files)
            {
                XmlNode nd = node.Clone();
                
                FileInfo fileInfo = new FileInfo(file);
                size += fileInfo.Length;

                nd.Attributes[0].Value = fileInfo.Length.ToString();

                if (fileInfo.Name.IndexOf("Thumbs.db", StringComparison.OrdinalIgnoreCase) > -1)
                {
                    continue;
                }

                string fileName = fileInfo.Name + ".bak";
                string subPath = file.Replace(path, "").TrimStart('\\');
                nd.InnerText = subPath + ".bak";
                File.Move(file, file + ".bak");
                File.Delete(file);
                nodeParent.AppendChild(nd);
            }
            nodeParent.RemoveChild(node);

            doc.SelectSingleNode("AutoUpdate/UpSize").InnerText = size.ToString();

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog1.FileName;
                using (FileStream fileStream = new FileStream(filePath, FileMode.Create))
                {
                    doc.Save(fileStream);
                    MessageBox.Show("完成。");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "XML文件(*.xml)|*.xml";
            saveFileDialog1.RestoreDirectory = true;
        }
    }
}
