using System;
using System.Threading;

namespace _16线程同步
{
    class SemClass
    {
        public static void Main(string[] args)
        {
            Thread ta = new Thread(new ThreadStart(ThA));
            Thread tb = new Thread(new ThreadStart(ThB));
            Thread tc = new Thread(new ThreadStart(ThC));
            ta.Start();
            tb.Start();
            tc.Start();

			//Console.WriteLine("\nPress any key to quit.");
			Console.ReadKey();
		}
		private static void ThA()
        {
            Console.WriteLine("A");
            sem1.Release();
        }
        private static void ThB()
        {
            sem1.WaitOne();//阻止当前线程，直到当前WaitHandle收到信号Release	退出信号量并返回前一个计数
            Console.WriteLine("B");
            sem2.Release();
        }
        private static void ThC()
        {
            sem2.WaitOne();
            Console.WriteLine("C");
        }
        private static Semaphore sem1 = new Semaphore(0, 1);
        private static Semaphore sem2 = new Semaphore(0, 1);
    }
}