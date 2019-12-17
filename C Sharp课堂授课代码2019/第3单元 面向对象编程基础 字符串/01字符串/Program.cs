using System;

namespace _01字符串
{
    class Program
    {
        static void Main(string[] args)
        {
            //string s1 = "123";
            ////s1 = "abc";
            ////string s2 = "123";
            //string s2 = s1;
            //s2 = "abcdefg";

            //Console.WriteLine(s1);
            //Console.WriteLine(s2);
            //Console.ReadKey();

            string s = "abcdef";
            //s = "bbcdef";
            //将string类型看成是char类型的只读数组
            //s[0] = 'b';
            char[] chs = s.ToCharArray();
            chs[0] = 'b';
            //将字符数组转换为字符串
            s = new string(chs);
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}