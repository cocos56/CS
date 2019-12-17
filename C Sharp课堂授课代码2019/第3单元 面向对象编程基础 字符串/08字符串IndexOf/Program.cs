using System;

namespace _08字符串IndexOf
{
    class Program
    {
        static void Main(string[] args)
        {
            ////方法1：
            ////找出所有a 的位置
            //string str = "asdfasdffdgaagfdgwafdg";
            //for (int i = 0; i < str.Length; i++)
            //{
            //    if (str[i]=='a')
            //    {
            //        Console.Write(i+" ");
            //    }
            //}

            //方法2
            string str = "asdfasdffdgaagfdgwafdg";
            int index = str.IndexOf('a');
            Console.WriteLine("第1次出现a的位置是{0}", index);
            int count = 1;
            while (index != -1)
            {
                count++;
                index = str.IndexOf('a', index + 1);
                Console.WriteLine("第{0}次出现a的位置是{1}", count, index);
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}