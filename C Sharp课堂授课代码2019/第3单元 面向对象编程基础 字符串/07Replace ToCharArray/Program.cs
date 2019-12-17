using System;
using System.Text.RegularExpressions;

namespace _07Replace_ToCharArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //方法1
            string str = "我的银行密码是185621";
            //if (str.Contains("185621"))
            //{
            //    str=str.Replace("185621","******");
            //}

            ////方法2
            //char[] chs = str.ToCharArray();
            //for (int i = 0; i < chs.Length; i++)
            //{
            //    if (chs[i]>=48&&chs[i]<=57)
            //    {
            //        chs[i] = '*'; 
            //    }
            //}
            //str=chs.ToString();//错误的方法
            //str = new string(chs);

            //方法3
            Regex reg = new Regex("[0-9]");
            str = reg.Replace(str, "*");
            Console.WriteLine(str);
            Console.ReadKey();
        }
    }
}