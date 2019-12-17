using System;
using System.Collections.Generic;
using System.Linq;

namespace _01List泛型集合
{
    class Program
    {
        static void Main(string[] args)
        {
            #region List<int>
            //List<int> list = new List<int>() {  1, 2, 3, 4, 5  };
            //list.Add(6);
            //list.Add(7);
            //list.AddRange(new int[] { 8, 9, 10 });
            //list.RemoveAll(n => n > 7);
            //list.RemoveRange(5,2);
            //int[] nums = list.ToArray();
            ////for (int i = 0; i < list.Count; i++)
            ////{
            ////    Console.WriteLine(list[i]);
            ////}
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    Console.WriteLine(nums[i]);
            //}
            #endregion
            //List<string> list2 = new List<string>();
            //string[] str = list2.ToArray();

            char[] chs = new char[] { 'a', 'b', 'c', 'd' };
            List<char> list = chs.ToList();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}