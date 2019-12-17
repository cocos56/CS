using System;

namespace _03四种参数类型
{
    class Program
    {
        static void Main(string[] args)
        {
            //值传递 引用传递(ref) 参数数组 输出传递(out)
            //1.值传递
            //int a = 3;
            //M1(a);
            //Console.WriteLine(a);
            //Console.ReadKey();

            //////2.引用传递  
            //int a = 3;
            //M2(ref a);//调用方法之前一定要给引用对象赋值
            //Console.WriteLine(a);
            //Console.ReadKey();

            //3.输出传递(out),可以实现一个方法返回多个值
            int[] a = { 1, 2, 32, 5, 8, 9 };
            int max;
            int min;
            double avg;
            M(out max, out min, out avg, a);
            Console.WriteLine(max + " " + min + " " + avg);
            Console.ReadKey();
        }
        public static void M1(int a)
        {
            a = 5;
        }
        public static void M2(ref int a)
        {
            a = 5;
        }
        public static void M(out int max, out int min, out double avg, int[] a)
        {
            //out 只要在方法里面给这个out类型的参数赋值，那么就可以在外面使用

            #region   方法1
            //max = min = a[0];
            //int sum = 0;
            //for (int i = 0; i < a.Length; i++)
            //{
            //    if (a[i] > max)
            //    {
            //        max = a[i];
            //    }
            //    else if (a[i]<min)
            //    {
            //        min = a[i];
            //    }
            //    sum += a[i];
            //}
            //avg = sum / a.Length;
            #endregion
            //方法2
            Array.Sort(a);
            max = a[a.Length - 1];
            min = a[0];
            int sum = 0;
            foreach (int item in a)
            {
                sum += item;
            }
            //for (int i = 0; i < a.Length; i++)
            //{
            //    sum += a[i];
            //}
            avg = sum / a.Length;
        }
    }
}