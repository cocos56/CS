using System;
using System.Collections.Generic;

namespace _05泛型集合练习
{
    class Program
    {
        static void Main(string[] args)
        {
            #region List<int>
            ////将整形数组中的所有奇数放到一个集合当中，所有偶数放到另一个集合当中
            ////合并两个集合，奇数在左，偶数在右
            //List<int> listJi = new List<int>();
            //List<int> listOu = new List<int>();
            //int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (nums[i]%2==0)
            //    {
            //        listOu.Add(nums[i]);
            //    }
            //    else
            //    {
            //        listJi.Add(nums[i]);
            //    }
            //}
            //listJi.AddRange(listOu);
            //foreach (var item in listJi)
            //{
            //    Console.Write(item + " ");
            //}
            #endregion            
            #region foreach
            //提示用户输入一个字符串，用foreach循环将用户输入的字符串给一个字符数组
            //Console.WriteLine("请输入一个字符串！");
            //string input = Console.ReadLine();
            //char[] chs = new char[input.Length];
            //int i = 0;
            //foreach (var item in input)
            //{
            //    chs[i] = item;
            //    i++;
            //}
            //foreach (var item in chs)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            //统计一个字符串中每个字符出现的次数，不考虑大小写
            //字符（键）----出现的次数（值）
            string str = "Welcome To China";
            Dictionary<char, int> dic = new Dictionary<char, int>();
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i]==' ')
                {
                    continue;
                }
                if (dic.ContainsKey(str[i]))//如果dic已经包含到了当前循环到的键
                {

                    dic[str[i]]++;
                }
                else//这个字符在集合中是第一次出现
                {
                    dic[str[i]] = 1; 
                }
            }
            foreach (KeyValuePair<char,int>kv in dic)
            {
                Console.WriteLine("{0}----{1}", kv.Key, kv.Value);
            }
        }
    }
}

