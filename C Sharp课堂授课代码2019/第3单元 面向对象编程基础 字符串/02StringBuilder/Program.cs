using System;

namespace _02StringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            ////没有开空间，玩的是同一块内存
            //StringBuilder sb = new StringBuilder();
            ////00:00:00.0313108
            ////00:00:35.8147417
            ////需要不断的开辟存储空间
            //string str = null;
            ////创建一个计时器，用于记录程序运行时间
            //Stopwatch sw = new Stopwatch();
            //sw.Start();
            //for (int i = 0; i < 100000; i++)
            //{
            //    str += i;
            //    //sb.Append(i);
            //}
            //sw.Stop();
            ////Console.WriteLine(sb.ToString());
            //Console.WriteLine(str);
            //Console.WriteLine(sw.Elapsed);
            //Console.ReadKey();

           
            
            //StringBuilder sb = new StringBuilder("abc");
            //sb.Remove(0, 1);
            //Console.WriteLine(sb);
            //Console.ReadKey();

            String sb = "abc";
            string ss = sb.Remove(0, 1);
            Console.WriteLine(sb);
            Console.WriteLine(ss);
            Console.ReadKey();
        }
    }
}