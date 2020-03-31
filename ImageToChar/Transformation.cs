using System;
using System.Text;
using System.Drawing;
using System.IO;

namespace ImageToChar
{
    class Transformation
    {
        /// <summary>
        /// 将图片转换为文本
        /// </summary>
        /// <param name="imagePath">图像文件路径</param>
        /// <param name="savaPath">文本保存路径</param>
        /// <param name="wSpan">横向像素点跨度</param>
        /// <param name="hSpan">纵向像素点跨度</param>
        /// <param name="replaceChar">替代字符串</param>
        public static void ImageToChar(string imagePath, String savaPath, int wSpan, int hSpan, string replaceChar)
        {
            StringBuilder sb = new StringBuilder();
            Bitmap bitmap = new Bitmap(imagePath);

            for (int i = 0; i < bitmap.Height; i += hSpan)
            {
                for (int j = 0; j < bitmap.Width; j += wSpan)
                {
                    Color c = bitmap.GetPixel(j, i);
                    double rgb = c.R * .3 + c.G * .59 + c.B * .11;      //灰度值公式
                    int index = (int)(rgb / 256.0 * replaceChar.Length);
                    //int index = (int)(bitmap.GetPixel(j, i).R * .3 + bitmap.GetPixel(j, i).G * .59 + bitmap.GetPixel(j, i).B * .11 / 256.0 * replaceChar.Length);
                    sb.Append(replaceChar[index]);
                }
                sb.Append("\r\n");
            }

            // 写入文件
            using (FileStream fs = new FileStream(savaPath, FileMode.Create, FileAccess.Write))
            {
                byte[] b = Encoding.Default.GetBytes(sb.ToString());
                fs.Write(b, 0, b.Length);
            }
        }
    }
}
