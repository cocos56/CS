using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _12哲学家进餐
{
    //死锁--->解决方法：资源共享
    class Program
    {
        //两个共享资源
        public static object o1 = new object();
        public static object o2 = new object();
        static void Main(string[] args)
        {
            Thread t1 = new Thread(M1);
            Thread t2 = new Thread(M2);
            t1.Start();
            t2.Start();
            Console.ReadKey();
        }
        //public static void M1()//发生死锁
        //{

        //    lock(o1)
        //    {
        //        Console.WriteLine("拿到o1");
        //        Thread.Sleep(500);
        //        lock(o2)
        //        {
        //            Console.WriteLine("拿到o2");
        //        }
        //        Console.WriteLine("完成");
        //    }
        //}
        public static void M1()
        {
            bool b1 = Monitor.TryEnter(o1);//尝试拿到资源o1,拿不到等待           
            Console.WriteLine("拿到o1");
            Thread.Sleep(2000);
            bool b2 = Monitor.TryEnter(o2);
            Console.WriteLine("拿到o2");
            if (b1)
            {
                Monitor.Exit(o1);//释放资源o1
            }
            if (b2)
            {
                Monitor.Exit(o2);
            }
            Console.WriteLine("完成");


        }
        //public static void M2()//发生死锁
        //{
        //    lock (o2)
        //    {
        //        Console.WriteLine("拿到o2");
        //        Thread.Sleep(500);
        //        lock (o1)
        //        {
        //            Console.WriteLine("拿到o1");
        //        }
        //        Console.WriteLine("完成");
        //    }
        //}
        public static void M2()
        {
            bool b2 = Monitor.TryEnter(o2);
            Console.WriteLine("拿到o2");
            Thread.Sleep(2000);
            bool b1 = Monitor.TryEnter(o1);
            Console.WriteLine("拿到o1");

            if (b2)
            {
                Monitor.Exit(o2);//释放资源o2
            }
            if (b1)
            {
                Monitor.Exit(o1);//释放资源o1
            }
            Console.WriteLine("完成");


        }
    }
}
