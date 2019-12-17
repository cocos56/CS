using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace _06互斥锁
{
    class Program
    {
        public static void Main(string[] args)
        {
            Thread t1 = new Thread(new ThreadStart(ThFunc));
            Thread t2 = new Thread(new ThreadStart(ThFunc));
            t1.Start();
            t2.Start();
        }
        private static void ThFunc()
        {
            lock (obj)
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("当前线程ID：{0}",
                                      Thread.CurrentThread.ManagedThreadId);
                    Thread.Sleep(1000);
                }
            }
        }
        private static object obj = new object();

    }

}
