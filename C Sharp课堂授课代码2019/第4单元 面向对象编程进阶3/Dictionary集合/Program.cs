using System;
using System.Collections;
using System.Collections.Generic;

namespace Dictionary集合
{
    class Program
    {
        static void Main(string[] args)
        {
            //泛型发生在编译期间
            Hashtable ht = new Hashtable();
            Dictionary<int, string> dic = new Dictionary<int, string>();
            dic.Add(1, "abc");
            dic.Add(2, "sfsd");
            dic.Add(3, "hfhj");
            dic.Add(4, "hgjg");
            //dic.Add("", "");//运行出错
            Dictionary<int, string>.KeyCollection keys = dic.Keys;
            foreach (var item in keys)
            {
                Console.WriteLine(item);
            }
            Dictionary<int, string>.Enumerator er = dic.GetEnumerator();
            while (er.MoveNext())
            {
                Console.WriteLine(er.Current.Value);
            }
        }
    }
}