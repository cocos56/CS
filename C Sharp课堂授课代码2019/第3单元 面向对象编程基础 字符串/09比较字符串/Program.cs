using System;

namespace _09比较字符串
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "mbcg";
            string str2 = "MbCg";
            //int n=string.Compare(str1, str2,true);
            //Console.WriteLine(n);

            int n2 = str2.CompareTo(str1);
            int n3 = str1.CompareTo(str2);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.ReadKey();
        }
    }
}