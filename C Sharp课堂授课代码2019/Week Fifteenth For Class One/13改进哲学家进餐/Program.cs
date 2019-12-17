using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _13改进哲学家进餐
{
    class Program
    {
        //两个共享资源
        public static object o1 = new object();
        public static object o2 = new object();

        private static Random random = new Random();
        static void Main(string[] args)
        {
            Thread t1 = new Thread(M1);
            Thread t2 = new Thread(M2);
            t1.Start();
            t2.Start();
            Console.ReadKey();
        }

        public static void M1()
        {
            while (true)
            {
                bool b1 = Monitor.TryEnter(o1);//尝试拿到资源o1,拿不到等待    
                if (b1)
                {
                    Console.WriteLine("线程1拿到o1");
                    Thread.Sleep(2000);
                }
                bool b2 = Monitor.TryEnter(o2);
                if (b2)
                    Console.WriteLine("线程1拿到o2");
                if (b1 && b2)
                {
                    Console.WriteLine("线程1进餐完毕");
                    Console.WriteLine("线程1释放o1");
                    Monitor.Exit(o1);//释放资源o1
                    Console.WriteLine("线程1释放o2");
                    Monitor.Exit(o2);
                    break;
                }
                else
                {
                    if (b1)
                    {
                        Console.WriteLine("线程1拿到一根筷子o1,2秒后尝试第二次拿筷子o2");
                        Thread.Sleep(2000);
                        b2 = Monitor.TryEnter(o2);
                        if (b2)
                        {
                            Console.WriteLine("线程1拿到o2");
                            Console.WriteLine("线程1进餐完毕");
                            Console.WriteLine("线程1释放o1");
                            Monitor.Exit(o1);//释放资源o1
                            Console.WriteLine("线程1释放o2");
                            Monitor.Exit(o2);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("线程1没有拿到o2");
                            Console.WriteLine("线程1释放o1");
                            Monitor.Exit(o1);//释放资源o1                           
                            Console.WriteLine("线程1将在2S后重新进行拿o1、o2");
                            Thread.Sleep(2000);
                        }
                    }
                    if (b2)
                    {
                        Console.WriteLine("线程1拿到一根筷子o2,2秒后尝试第二次拿筷子o1");
                        Thread.Sleep(2000);
                        b1 = Monitor.TryEnter(o1);
                        if (b1)
                        {
                            Console.WriteLine("线程1进餐完毕");
                            Console.WriteLine("线程1释放o1");
                            Monitor.Exit(o1);//释放资源o1
                            Console.WriteLine("线程1释放o2");
                            Monitor.Exit(o2);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("线程1没有拿到01");
                            Console.WriteLine("线程1释放o2");
                            Monitor.Exit(o2);
                            Console.WriteLine("线程1将在2S后重新进行拿o1、o2");
                            Thread.Sleep(2000);
                        }
                    }
                }
            }
        }
        public static void M2()
        {
            while (true)
            {
                bool b2 = Monitor.TryEnter(o2);
                if (b2)
                {
                    Console.WriteLine("线程2拿到o2");
                    Thread.Sleep(2000);
                }
                bool b1 = Monitor.TryEnter(o1);
                if (b1)
                    Console.WriteLine("线程2拿到o1");

                if (b1 && b2)
                {
                    Console.WriteLine("线程2进餐完毕");
                    Console.WriteLine("线程2释放o1");
                    Monitor.Exit(o1);//释放资源o1
                    Console.WriteLine("线程2释放o2");
                    Monitor.Exit(o2);//释放资源o2
                    break;
                }
                else
                {
                    if (b2)
                    {
                        Console.WriteLine("线程2拿到一根筷子o2,2秒后尝试第二次拿筷子o1");
                        Thread.Sleep(2000);
                        b1 = Monitor.TryEnter(o1);
                        if (b1)
                        {
                            Console.WriteLine("线程2进餐完毕");
                            Console.WriteLine("线程2释放o1");
                            Monitor.Exit(o1);//释放资源o1
                            Console.WriteLine("线程2释放o2");
                            Monitor.Exit(o2);//释放资源o2
                            break;
                        }
                        else
                        {
                            Console.WriteLine("线程2没有拿到01");
                            Console.WriteLine("线程2释放o2");
                            Monitor.Exit(o2);//释放资源o2
                            Console.WriteLine("线程2将在2S后重新进行拿o1、o2");
                            Thread.Sleep(2000);
                        }
                    }
                    if (b1)
                    {
                        Console.WriteLine("线程2拿到一根筷子o1,2秒后尝试第二次拿筷子o2");
                        Thread.Sleep(2000);
                        b2 = Monitor.TryEnter(o2);
                        if (b2)
                        {
                            Console.WriteLine("线程2进餐完毕");
                            Console.WriteLine("线程2释放o1");
                            Monitor.Exit(o1);//释放资源o1
                            Console.WriteLine("线程2释放o2");
                            Monitor.Exit(o2);//释放资源o2
                            break;
                        }
                        else
                        {
                            Console.WriteLine("线程2没有拿到o2");
                            Console.WriteLine("线程2释放o1");
                            Monitor.Exit(o1);//释放资源o1
                            Console.WriteLine("线程2将在2S后重新进行拿o1、o2");
                            Thread.Sleep(2000);
                        }
                    }
                }
            }
        }
    }
}
