using System;
using System.IO;

namespace _04Directory类
{
    class Program
    {
        static void Main(string[] args)
        {
            //File  Path   FileStream  StreamReader  StreamWriter
            //Directory 文件夹 目录
            //创建文件夹
            //Directory.CreateDirectory(@"C:\a");
            //Console.WriteLine("创建成功");
            //Console.ReadKey();

            //删除文件夹
            //Directory.Delete(@"C:\a",true);
            //Console.WriteLine("删除成功");
            //Console.ReadKey();


            //剪切文件夹
            //Directory.Move(@"c:\a", @"D:\new");
            //Console.WriteLine("剪切成功");
            //Console.ReadKey();


            //获得指定文件夹下所有文件的全路径
            string[] path = Directory.GetFiles(@"C:\Users\Administrator\Desktop\文件操作");
            for (int i = 0; i < path.Length; i++)
            {
                Console.WriteLine(path[i]);
            }
            Console.ReadKey();


            //获得指定目录下所有文件夹的全路径
            //string[] path = Directory.GetDirectories(@"C:\Users\SpringRain\Desktop\new");
            //for (int i = 0; i < path.Length; i++)
            //{
            //    Console.WriteLine(path[i]);
            //}
            //Console.ReadKey();


            //判断指定的文件夹是否存在
            //if (Directory.Exists(@"C:\a\b"))
            //{
            //    for (int i = 0; i < 100; i++)
            //    {
            //        Directory.CreateDirectory(@"C:\a\b\" + i);
            //    }   
            //}
            //Console.WriteLine("OK");
            //Console.ReadKey();


            //Directory.Delete(@"C:\a\b", true);
            //Console.ReadKey();
        }
    }
}