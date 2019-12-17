using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _14线程遍历集合
{
    class Program
    {
        //运行结果有误，因为有两个线程：main线程 和chang线程
        static void Main(string[] args)
        {
            //线程调用（CPU说了算）：1、时间片轮转 2、优先级调用  
            //多线程：是相对概念，一个时间片内可以发生多个线程，好像同时发生一样
            Thread t = new Thread(Change);
            List<string> list = new List<string>();
            list.Add("zhang");
            list.Add("li");
            list.Add("wang");
            list.Add("zhao");
            t.Start(list);//通知线程
            Thread.Sleep(1000);//主线程休眠，单位毫秒
            foreach (string s in list)
            {
                Console.WriteLine(s);
            }

        }
        public static void Change(object o)
        {
            //Console.WriteLine(o.GetType());
            //Thread.Sleep(1000);//t线程休眠，单位毫秒
            List<string> list = (List<string>)o;
            for (int i = 0; i < list.Count; i++)
            {
                list[i] = list[i].ToUpper();
            }
        }
    }
}
