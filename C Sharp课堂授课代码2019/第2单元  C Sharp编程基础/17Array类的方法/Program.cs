using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17Array类的方法
{
    //C#中的 “ 解析Array类 中的属性与方法”
    //https://blog.csdn.net/qq_34536551/article/details/90694723
    class Program
    {
        static void Main(string[] args)
        {
            int[] list = { 34, 72, 13, 44, 25, 30, 10 };
            int[] temp = list;

            Console.Write("原始数组： ");
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
           
            // 逆转数组
            Array.Reverse(temp);
            Console.Write("逆转数组： ");
            foreach (int i in temp)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            
            // 排序数组
            Array.Sort(list);
            Console.Write("排序数组： ");
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

           Console.ReadKey();
        }
    }
}
