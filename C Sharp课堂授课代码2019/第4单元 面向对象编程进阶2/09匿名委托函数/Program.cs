using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _09匿名委托函数
{
    //魏加薪有授课的C#部分视频
    public delegate void DelSayHi(string name);
    class Program
    {
        static void Main(string[] args)
        {
            //DelSayHi del=SayHiChinese;//new DelSayHi(SayHiChinese);
            DelSayHi del = delegate(string name)
            {
                Console.WriteLine("Nice to meet you!" + name);
            };
            
            del("张三");
        }
        //public static void SayHiChinese(string name)
        //{
        //    Console.WriteLine("吃了么" + name);
        //}
        //public static void SayHiEnglish(string name)
        //{
        //    Console.WriteLine("Nice to meet you!" + name);
        //}
    }
}
