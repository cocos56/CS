using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace _01程序集
{
    class Program
    {
        static void Main(string[] args)
        {
            ////获得当前程序中加载的所有程序集
            //Assembly[] asms = AppDomain.CurrentDomain.GetAssemblies();
            //foreach (Assembly asm in asms)
            //{
            //    Console.WriteLine(asm.Location);
            //}
            //string filename = @"C:\Users\Administrator\Desktop\共享文件夹\Week Elevn For Class One\测试程序集\bin\Debug\测试程序集.dll";
            //Assembly asm=Assembly.LoadFile(filename);
            
            Assembly asm=Assembly.LoadFrom("测试程序集.dll");//相对路径

            //Type[] typs = asm.GetTypes();
            //foreach (Type t in typs)
            //{
            //    Console.WriteLine(t);
            //}
            Type type = asm.GetTypes()[1]; //asm.GetType("测试程序集.Student");         
            PropertyInfo[] props = type.GetProperties();
            PropertyInfo pi=type.GetProperty("Count");

            Console.WriteLine(pi.PropertyType.ToString());
            foreach (PropertyInfo prop in props)
            {
                //Console.WriteLine(prop);
            }
        }
    }
}
