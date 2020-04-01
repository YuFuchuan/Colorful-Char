using ImageToChar.page;

namespace ImageToChar.function
{
    class GetErrorPage
    {
        /// <summary>
        /// 打开一个报错窗口,并传递错误信息
        /// </summary>
        /// <param name="error">错误信息</param>
        public static void Get(string error)
        {
            ErrorForm page = new ErrorForm();
            page.SetError(error);
            page.ShowDialog();
        }
    }
}
