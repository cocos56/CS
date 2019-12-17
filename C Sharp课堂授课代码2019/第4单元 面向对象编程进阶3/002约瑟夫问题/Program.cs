using System;
using System.Collections;

namespace _002约瑟夫问题
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                Console.WriteLine("请输入学生的人数，开始序号，隔的人数");
                int n = Convert.ToInt16(Console.ReadLine());
                int s = Convert.ToInt16(Console.ReadLine());
                ArrayList list = new ArrayList();
                int m = Convert.ToInt16(Console.ReadLine());
                for (int i = 0; i < n; i++)
                {
                    list.Add(i + 1);
                }
                for (int i = 0; i < n; i++)
                {
                    Console.Write(list[i] + " ");
                }
                Console.WriteLine();
                int t;
                s--;
                for (int i = n - 1; i > 0; i--)     //操作数组下标
                {
                    t = s + m - 1;
                    s = t % i;
                    if (s == 0)
                        s = i;
                    if (t > i)
                    {
                        s--;
                    }
                    Console.Write(list[s] + " ");
                    list.RemoveAt(s);
                }
                Console.Write(list[0]);
                Console.WriteLine();
            }
        }
    }
}
