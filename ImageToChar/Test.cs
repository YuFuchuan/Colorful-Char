using System;

namespace ImageToChar
{
    class Test
    {
        public static void TryTransform(string imagePath, String savaPath, int wSpan, int hSpan, string replaceChar)
        {
            try
            {
                Transformation.ImageToChar(imagePath, savaPath, wSpan, hSpan, replaceChar);
                Console.WriteLine(replaceChar.Length + "分度字符画创建成功!");
            }
            finally { }
        }
    }
}
