using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace _03程序集
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = @"C:\Users\Administrator\Desktop\共享文件夹\Week Elevn For Class One\测试程序集\bin\Debug\测试程序集.dll";
            Assembly asm = Assembly.LoadFile(filename);
            Type t = asm.GetTypes()[0];
            object o=Activator.CreateInstance(t);
            Console.WriteLine(o);
        }
    }
}
