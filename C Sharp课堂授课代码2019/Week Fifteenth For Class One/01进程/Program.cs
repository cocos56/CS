using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace _01进程
{
    class Program
    {
        static void Main(string[] args)
        {
            ////获得当前程序中所有正在运行的进程
            //Process[] pros = Process.GetProcesses();
            //foreach (var item in pros)
            //{
            //    //不试的不是爷们
            //    //item.Kill();
            //    //Console.WriteLine(item);
            //}
            //Process.Start("shutdown","-s -t 60");//关机
            ////Process.Start("shutdown", "-r -t 0");//重启

            ////通过进程打开一些应用程序
            //Process.Start("calc");//打开计算器
            //Process.Start("mspaint");//打开画图工具
            //Process.Start("notepad");//打开记事本
            //Process.Start("iexplore", "http://www.baidu.com");
            ProcessStartInfo psi = new ProcessStartInfo(@"C:\Users\Administrator\Desktop\2.txt");

            //第一：创建进程对象
            Process p = new Process();
            p.StartInfo = psi;
            p.Start();
            Console.ReadKey();

        }
    }
}
