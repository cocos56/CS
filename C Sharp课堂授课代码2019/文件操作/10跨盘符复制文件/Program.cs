using System;
using System.IO;

namespace _10跨盘符复制文件
{
    class Program
    {
        static void Main(string[] args)
        {
            string srcPath = @"C:\Users\Administrator\Desktop\文件操作";
            string destPath = @"D:\目标文件夹";
            if (!Directory.Exists(destPath))
            {
                Directory.CreateDirectory(destPath);
                if (Directory.Exists(srcPath) && Directory.Exists(destPath))
                {
                    CopyDirectory(srcPath, destPath);
                }
            }
        }

        public static void CopyDirectory(string srcPath, string destPath)
        {
            try
            {
                DirectoryInfo dir = new DirectoryInfo(srcPath);
                FileSystemInfo[] fileinfo = dir.GetFileSystemInfos();  //获取目录下（不包含子目录）的文件和子目录
                foreach (FileSystemInfo i in fileinfo)
                {
                    if (i is DirectoryInfo)     //判断是否文件夹
                    {
                        if (!Directory.Exists(destPath + "\\" + i.Name))
                        {
                            Directory.CreateDirectory(destPath + "\\" + i.Name);   //目标目录下不存在此文件夹即创建子文件夹
                        }
                        CopyDirectory(i.FullName, destPath + "\\" + i.Name);    //递归调用复制子文件夹
                    }
                    else
                    {
                        File.Copy(i.FullName, destPath + "\\" + i.Name, true);      //不是文件夹即复制文件，true表示可以覆盖同名文件
                    }
                }
            }
            catch (Exception e)
            {
                throw;
            }
        }
    }
}