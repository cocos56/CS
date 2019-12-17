using System;

namespace _06字符串练习
{
    //"abc"-----"cba"
    class Program
    {
        static void Main(string[] args)
        {
            //string str = "sdgfmdkljsgkl";
            //char[]chs=str.ToCharArray();
            //for (int i = 0; i < chs.Length/2; i++)
            //{
            //    char temp = chs[i];
            //    chs[i] = chs[chs.Length - 1 - i];
            //    chs[chs.Length - 1 - i] = temp;
            //}
            ////str=chs.ToString();错误写法
            //str = new string(chs);
            //Console.WriteLine(str);
            //Console.ReadKey();

            //练习：从email中提取用户名和域名 abc@163.com
            string str = "abc@163.com";
            int index = str.IndexOf('@');
            string strUser = str.Substring(0, index);
            string strDNS = str.Substring(index + 1);
            Console.WriteLine(strDNS);
            Console.WriteLine(strUser);
            Console.ReadKey();
        }
    }
}