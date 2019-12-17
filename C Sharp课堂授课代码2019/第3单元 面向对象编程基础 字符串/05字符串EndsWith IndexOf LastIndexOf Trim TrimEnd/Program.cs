using System;

namespace _05字符串EndsWith_IndexOf_LastIndexOf_Trim_TrimEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            //string str = "今天天气好晴朗，处处好天天风光";
            //if (str.EndsWith("好风"))
            //{
            //    Console.WriteLine("是的");
            //}
            //else
            //{
            //    Console.WriteLine("否");
            //}

            ////int index=str.IndexOf('天');
            //int indexEnd = str.LastIndexOf('天');
            //Console.WriteLine(indexEnd);
            //Console.ReadKey();

            //string str = "      hahahaha     ";
            ////str=str.Trim();
            //str = str.TrimEnd();
            //Console.WriteLine(str);
            //Console.ReadKey();

            //string str = "asdfmksljf";
            //if (string.IsNullOrEmpty(str))
            //{
            //     Console.WriteLine("是的");
            //}
            //else
            //{
            //    Console.WriteLine("否");
            //}
            //Console.ReadKey();

            string[] names = { "张三", "李四", "王五", "武大郎", "西门庆" };
            string strNew = string.Join("|", names);
            Console.WriteLine(strNew);
            Console.ReadKey();
        }
    }
}