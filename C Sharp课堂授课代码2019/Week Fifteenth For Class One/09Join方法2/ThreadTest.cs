using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _09Join方法2
{
    class ThreadTest
    {
        public static void Main(String[] args)
        {
            ThreadTest tt = new ThreadTest();
            Thread t = new Thread(tt.th);//创建一个线程
            Console.WriteLine("创建一个子线程");
            t.Start();					// 启动线程
            t.Join();					// 等待子线程结束
            Console.WriteLine("主线程终止");
        }
        public void th()
        {
            while (num < 20)
            {
                Console.WriteLine(++num);
                Thread.Sleep(1000);
            }
        }
        private static int num = 0;

    }
}
