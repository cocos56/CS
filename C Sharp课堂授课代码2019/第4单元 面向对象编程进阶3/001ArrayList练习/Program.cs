using System;
using System.Collections;

namespace _001ArrayList练习
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 22, 8, 51, 6, 5, 33 };
            ArrayList list = new ArrayList(arr);
            Console.WriteLine("原集合");
            foreach (int item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            #region  方法一
            //for (int i = 1; i < 5; i++)
            //{
            //    list.Add(i + arr.Length);
            //}
            //Console.WriteLine("Add方法");
            //foreach (int item in list)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine();
            //list.Insert(6, 6);
            //Console.WriteLine("Insert方法");
            //foreach (int item in list)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine();
            #endregion

            int[] arr2 = new int[] { 47, 9, 15, 7, 10 };
            list.InsertRange(6, arr2);


            bool b = list.Contains(55);
            if (!list.Contains(55))
            {
                list.Add(55);
            }
            else
            {
                Console.WriteLine("55已存在");
            }
            list.Sort();
            list.Reverse();

            list.Clear();
            foreach (int item in list)
            {
                Console.Write(item + " ");
            }

            int n1 = list.Count;//表示这个集合中实际包含的元素的个数
            int n2 = list.Capacity;//表示这个集合中可以包含的元素的个数

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}