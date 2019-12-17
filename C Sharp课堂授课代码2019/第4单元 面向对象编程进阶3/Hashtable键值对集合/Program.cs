using System;
using System.Collections;

namespace Hashtable键值对集合
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建了一个键值对集合对象
            Hashtable ht = new Hashtable();
            ht.Add(1, "张三");
            ht.Add(2, true);
            ht.Add(3, '男');
            ht.Add(false, "错误的");
            ht.Add(5, "张三");
            //ht.Add(5, true);键不能重复

            if (!ht.ContainsKey("abc"))
            {
                //"abc"----"cba"
                ht.Add("abc", "cba");
            }
            else
            {
                Console.WriteLine("已经存在abc这个键了");
            }
            //ht.Remove(false);
            ht.Clear();

            foreach (DictionaryEntry dicEntry in ht)
            {
                Console.WriteLine("\t" + dicEntry.Key + "\t" + dicEntry.Value);
            }

            //for (int i = 0; i < ht.Count; i++)
            //{
            //    //在键值对集合中是根据键去找值的
            //    Console.WriteLine("键是-----{0}值是======={1}",i,ht[i]);
            //}
            Console.ReadKey();
        }
    }
}