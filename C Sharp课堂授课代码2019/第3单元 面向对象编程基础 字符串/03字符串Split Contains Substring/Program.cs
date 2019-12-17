using System;

namespace _03字符串Split_Contains_Substring
{
    class Program
    {
        static void Main(string[] args)
        {

            //string s = "abcdedghij";
            //string ss = s.Substring(2, 3);
            //Console.WriteLine(ss);


            //string s = "2+3";
            ////string s = "2*3";
            ////public string[] Split(params char[] separator);
            //string[] ss = s.Split('+');
            //int a = Convert.ToInt32(ss[0]);//string-->int
            //int b = Convert.ToInt32(ss[1]);//string-->int
            //Console.WriteLine(a + b);

            string s = "15/3";//string s = "15+3"; string s = "15-3"; string s = "15*3";
            int num = GetValue(s);
            Console.WriteLine(num);

            //==比较引用数据类型
        }
        public static int GetValue(string s)
        {
            //算术表达式
            char[] chs = new char[] { '+', '-', '*', '/' };
            string[] ss = s.Split(chs, StringSplitOptions.RemoveEmptyEntries);
            int a = Convert.ToInt32(ss[0]);//string-->int
            int b = Convert.ToInt32(ss[1]);//string-->int
            //32+56
            if (s.Contains("+"))
            {
                return a + b;
            }
            else if (s.Contains("-"))
            {
                return a - b;
            }
            else if (s.Contains("*"))
            {
                return a * b;
            }
            else if (s.Contains("/"))
            {
                return a / b;
            }
            return 0;
        }
    }
}