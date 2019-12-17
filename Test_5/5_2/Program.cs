using System;
using System.Threading;

namespace _5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //2.写两个线程，交替打印1-100，看谁先执行完；写两个线程，分别打印1-100，看谁先执行完。
            //3.写两个线程，运用互斥锁（在一个时刻内只允许一个线程进入执行，而其他线程必须等待）原理解决取钱问题。
            
            Program obj1 = new Program();
            Thread thread1 = new Thread(new ThreadStart(obj1.Count1));
            thread1.Name = "线程1";

            Program obj2 = new Program();
            Thread thread2 = new Thread(new ThreadStart(obj2.Count1));
            thread2.Name = "线程2";

            thread1.Start();
            thread2.Start();


            Console.ReadKey();
        }

        private static int cnt1 = 0;
        private int cnt2 = 1;

        private void Count1()
        {
            while (cnt1 < 100)
            {
                cnt1++;
                Console.WriteLine(Thread.CurrentThread.Name + "数到" + cnt1);
                Thread.Sleep(100);
            }
        }

        private void Count2()
        {
            while (cnt2 < 100)
            {
                cnt2++;
                Console.WriteLine(Thread.CurrentThread.Name + "数到" + cnt2);
                Thread.Sleep(100);
            }
        }
    }
}