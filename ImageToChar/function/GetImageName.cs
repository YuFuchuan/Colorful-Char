namespace ImageToChar.function
{
    class GetFileName
    {
        /// <summary>
        /// 根据路径获取文件名称(不带文件类型后缀)
        /// </summary>
        /// <param name="FilePath">文件路径</param>
        /// <returns>文件名称</returns>
        public static string Get(string FilePath)
        {
            string[] part = FilePath.Split('\\');
            string[] partName = part[part.Length - 1].Split('.');
            string name = partName[0];
            for(int i = 1; i < partName.Length - 1; ++i)
            {
                name = name + "." + partName[i];
            }

            return name;
        }
    }
}
