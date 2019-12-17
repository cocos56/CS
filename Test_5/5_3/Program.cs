using System;
using System.Threading;

namespace _5_3
{
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

			//Console.WriteLine("\nPress any key to quit.");
			Console.ReadKey();
		}

		public void GetMoney(object num)
		{
			//互斥段在一个时刻内只允许一个线程进入执行，而其他线程必须等待。
			//这是通过在代码块运行期间为给定对象获取互斥锁来实现的。
			lock (o)//互斥锁
			{
				int a = (int)num;
				balance -= a;
				Thread.Sleep(100);
				Console.WriteLine(Thread.CurrentThread.Name + ":" + balance);
			}
		}
	}
}