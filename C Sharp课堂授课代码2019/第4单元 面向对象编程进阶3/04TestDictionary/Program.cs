using System;
using System.Collections.Generic;

namespace _04TestDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dic = new Dictionary<int, string>();
            dic.Add(1, "abc");
            dic.Add(2, "def");
            //dic.Add("3","lmn")错误写法
            //foreach (KeyValuePair<int,string> item in dic)
            //{
            //    Console.WriteLine(item);
            //}
            
            //Dictionary<int, string>.KeyCollection keys = dic.Keys;
            //foreach (int item in keys)
            //{
            //    Console.WriteLine(item);
            //}

            //foreach (var item in dic)
            //{
            //   // Console.WriteLine("{0}----{1}", item.Key, item.Value);
            //    Console.WriteLine("{0}----{1}", item.Key, dic[item.Key]);
            //}

            Dictionary<int, string>.Enumerator er = dic.GetEnumerator();
            while (er.MoveNext())
            {
                Console.WriteLine(er.Current.Value);
            }
        }
    }
}
