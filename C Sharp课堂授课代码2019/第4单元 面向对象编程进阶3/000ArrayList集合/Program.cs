using System;
using System.Collections;

namespace _000ArrayList集合
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建一个集合对象
            ArrayList list = new ArrayList();
            //集合：很多数据的一个集合  长度可以任意改变 类型随便
            //数组：长度不可变 类型单一
            list.Add(1);
            list.Add(3.14);
            list.Add(true);
            list.Add("张三");
            list.Add('f');
            list.Add(500m);
            list.Add(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });
            Person p = new Person();
            list.Add(p);
            //list.AddRange(list);
            list.AddRange(new int[] { 55, 66, 77, 88 });
            list.Remove(true);//删除单个元素，是谁就删除谁
            //list.RemoveAt(2);
            list.RemoveRange(2, 5);
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] is Person)
                {
                    ((Person)list[i]).SayHello();
                }
                else if (list[i] is int[])
                {
                    for (int j = 0; j < ((int[])list[i]).Length; j++)
                    {
                        Console.Write(((int[])list[i])[j] + " ");
                    }
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine(list[i]);
                }
            }
            Console.ReadKey();
        }
        public class Person
        {
            public void SayHello()
            {
                Console.WriteLine("我是人类");
            }
        }
    }
}