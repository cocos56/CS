using System;
using System.Threading;

namespace _07交替打印1_100
{
    //课堂练习：写两个线程，交替打印1-100，看谁先执行完
    //ThreadState的四种状态：就绪状态（调用start方法之前） 运行状态（调用start方法之后） 死亡状态（运行结束之后） 阻塞状态（是指线程在等待一个事件（如某个信号量），逻辑上不可执行）

    class Program
    {
        static int a = 0;
        static bool b = true;
        static void Main(string[] args)
        {
            Thread t1 = new Thread(M);
            t1.Name = "t1";
            Thread t2 = new Thread(M);
            t2.Name = "--";
            t1.Priority = ThreadPriority.Highest;//线程优先级：有五种优先级
            t1.Start();//通知cpu线程t1准备好
            t2.Start();//通知cpu线程t2准备好
            Console.ReadKey();

        }
        public static void M()
        {
            //当一个线程达到50时，另一个线程终止
            for (int i = 1; i < 51; i++)
            {
                Thread.Sleep(1);
                if (b)
                {
                    if (i == 50)
                    {
                        b = false;
                    }
                    a++;
                    Console.WriteLine(Thread.
                        CurrentThread.Name + ":" + a);//拿到当前线程名字Thread.CurrentThread.Name                    
                }
            }
        }
    }
}