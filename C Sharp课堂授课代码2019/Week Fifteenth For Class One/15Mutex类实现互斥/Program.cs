using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _15Mutex类实现互斥
{
    public class MutexTest
    {
        public static void Main(String[] args)
        {
            Thread t1 = new Thread(new ThreadStart(Th));
            Thread t2 = new Thread(new ThreadStart(Th));
            t1.Start();
            t2.Start();
            t1.Join();
            t2.Join();
        }
        public static void Th()
        {
            Process();
        }
        private static void Process()
        {
            for (int i = 0; i < 10; i++)
            {
                mut.WaitOne();//等待一个mutex结束:阻止当前线程，直到当前 WaitHandle 收到释放信号。
                Console.WriteLine("当前线程：" + Thread.CurrentThread.ManagedThreadId + "开始");
                Thread.Sleep(1000);
                Console.WriteLine("当前线程：" + Thread.CurrentThread.ManagedThreadId + "结束");
                mut.ReleaseMutex();//释放获取的mutex
            }
        }
        private static Mutex mut = new Mutex();//创建一个Mutex对象
    }

}
