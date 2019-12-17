using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace _05Join
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(new ThreadStart(th));
            Console.WriteLine("启动线程t1之前");
            t1.Start();
            t1.Join();//等待线程t1终止
            Console.WriteLine("线程t1终止之后");
            Console.ReadKey();
        }
        static void th()
        {
            Console.WriteLine("开始执行线程t1");
            Thread.Sleep(2000);
            Console.WriteLine("结束线程t1");
        }

    }
}
