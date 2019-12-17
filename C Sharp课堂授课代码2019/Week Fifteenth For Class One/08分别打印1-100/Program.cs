using System;
using System.Threading;

namespace _08分别打印1_100
{
    //课堂练习：写两个线程，交替着分别打印1-100，看谁先执行完

    class Program
    {
        static bool b = true;
        static void Main(string[] args)
        {
            Thread t1 = new Thread(M);
            t1.Name = "t1";
            Thread t2 = new Thread(M);
            t2.Name = "--";
            //t1.Priority = ThreadPriority.Highest;//线程优先级：有五种优先级
            //t1.Priority = ThreadPriority.Lowest;
            t1.Start();//通知cpu线程t1准备好
            t2.Priority = ThreadPriority.Highest;
            t2.Start();//通知cpu线程t2准备好

            Console.ReadKey();

        }
        public static void M()
        {
            //当一个线程达到100时，另一个线程终止
            for (int i = 1; i < 101; i++)
            {
                Thread.Sleep(1);
                if (b)
                {
                    if (i == 100)
                    {
                        b = false;
                    }
                    Console.WriteLine(Thread.CurrentThread.Name + ":" + i);//拿到当前线程名字Thread.CurrentThread.Name
                }
            }
        }
    }   
}