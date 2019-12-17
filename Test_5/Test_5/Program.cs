using System;
using System.Threading;

namespace Test_5
{
    class Program
    {
        //1.尝试开发一个程序，要求通过使用线程休眠控制程序的执行效果。

        static void Main(string[] args)
        {
            Program obj1 = new Program();
            Thread thread1 = new Thread(new ThreadStart(obj1.Count));
            thread1.Name = "线程1";

            Program obj2 = new Program();
            Thread thread2 = new Thread(new ThreadStart(obj2.Count));
            thread2.Name = "线程2";

            Program obj3 = new Program();
            Thread thread3 = new Thread(new ThreadStart(obj3.Count));
            thread3.Name = "线程3";

            thread1.Start();
            thread2.Start();
            thread3.Start();


            Console.ReadKey();
        }

        private int cnt = 0;
        private void Count()
        {
            while (cnt < 10)
            {
                cnt++;
                Console.WriteLine(Thread.CurrentThread.Name + "数到" + cnt);
                Thread.Sleep(100);
            }
        }
    }
}