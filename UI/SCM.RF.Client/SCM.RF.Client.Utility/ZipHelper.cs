using System.Text;

namespace SCM.RF.Client.Utility
{
    /// <summary>
    /// Ω‚—πÀı
    /// </summary>
    public class ZipHelper
    {
        /// <summary>
        /// Ω‚—π
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static byte[] Unzip(byte[] data, Encoding encoding)
        {
            //MemoryStream mstream = new MemoryStream(data);
            //BZip2InputStream zipInputStream = new BZip2InputStream(mstream);
            //StreamReader readstream = new StreamReader(zipInputStream, EncodingInstance.Instance);
            //String unzipdata = readstream.ReadToEnd();

            //zipInputStream.Close();
            //mstream.Close();
            //return encoding.GetBytes(unzipdata);

            return data;
        }

        /// <summary>
        /// —πÀı
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static byte[] Zip(byte[] data)
        {
            //MemoryStream mstream = new MemoryStream();
            //BZip2OutputStream zipOutStream = new BZip2OutputStream(mstream);
            //zipOutStream.Write(data, 0, data.Length);
            //zipOutStream.Close();
            //byte[] result = mstream.ToArray();
            //mstream.Close();
            //return result;

            return data;
        }
    }
}
