using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11数组
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 数组声明
            //int []a={1,2,3,8,5};
            //int[] b = new int[] { 1, 2, 3, 8, 5 };
            //int[] c = new int[5];
            //c[0] = 1;
            //c[2] = 3;
            //bool[] bArray = new bool[5];
            //Console.WriteLine(bArray[2]);
            ////在数组中整数的默认值是0，bool默认值是false，引用类型是null
            //for (int i = 0; i < c.Length; i++)
            //{
            //    Console.Write(c[i]+" ");
            //}
            //Console.WriteLine();
            //Console.ReadKey();
            #endregion
            //数组练习1
            int[] a = new int[6] { 15, 9, 72, 5, 30, 2 };
            M(a);
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
                sum += a[i];
            }
            Console.ReadKey();
        }
        public static void M(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a.Length - i - 1; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        int temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    }
                }
            }
        }
    }

}
