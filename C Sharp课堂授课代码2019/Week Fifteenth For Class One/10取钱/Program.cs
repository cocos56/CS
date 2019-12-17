using System;
using System.Threading;

namespace _10取钱
{
    //数据库知识：事务的--原子性，一致性,分离性,持久性
    class Program
    {
        public static int balance = 3000;
		public static object o = new object();
        static void Main(string[] args)
        {
            Program p = new Program();
            Thread t1 = new Thread(p.GetMoney);
			t1.Name = "t1";
            Thread t2 = new Thread(p.GetMoney);
			t2.Name = "t2";

			t1.Start(1000);
            t2.Start(500);

			//t1.Join();
			//t2.Join();

			//Console.WriteLine("\nPress any key to quit.");
			Console.ReadKey();
		}

		public void GetMoney(object num)
        {
            //互斥段在一个时刻内只允许一个线程进入执行，而其他线程必须等待。
            //这是通过在代码块运行期间为给定对象获取互斥锁来实现的。
            //如果你想保护一个类的实例，一般地，你可以使用this；
            //如果你想保护一个静态变量，一般使用类名就可以了
            //lock(o)//互斥锁
            //而且lock(this)只对当前对象有效，如果多个对象之间就达不到同步的效果。
            //lock (this)//互斥锁 拿到当前对象的锁 每一个对象都有一个锁
            //{
            //}
			lock (o)//互斥锁
			{
				int a = (int)num;
				balance -= a;
				Thread.Sleep(500);
				Console.WriteLine(Thread.CurrentThread.Name + ":" + balance);
			}
		}
    }
}