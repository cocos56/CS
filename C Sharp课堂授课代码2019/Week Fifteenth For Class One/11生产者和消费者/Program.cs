using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _11生产者和消费者
{
    class Program
    {
        public static void Main(String[] args)
        {
            Thread pt = new Thread(new ThreadStart(Producer));
            Thread ct = new Thread(new ThreadStart(Customer));
            pt.Start();
            ct.Start();
            pt.Join();
            ct.Join();
            Console.ReadKey();
        }
        public static void Producer()//生产者
        {
            do
            {
                Monitor.Enter(obj);
                try
                {
                    Console.Write("生产：");
                    goods = Console.ReadLine();
                    mark = true;
                    Monitor.Pulse(obj);
                    Monitor.Wait(obj);
                }
                finally
                {
                    Monitor.Exit(obj);
                }
            } while (goods != "end");
        }
        public static void Customer()//消费者
        {
            do
            {
                Monitor.Enter(obj);
                try
                {
                    if (!mark)
                        Monitor.Wait(obj);
                    Console.WriteLine("商品：" + goods);
                    mark = false;
                    Monitor.Pulse(obj);
                }
                finally
                {
                    Monitor.Exit(obj);
                }
            } while (goods != "end");
        }
        private static Object obj = new Object();
        private static bool mark = false;
        private static string goods = null;

    }

}
