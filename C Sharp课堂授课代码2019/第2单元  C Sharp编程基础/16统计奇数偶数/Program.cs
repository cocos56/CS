using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16统计奇数偶数
{
    class Program
    {
        static void Main(string[] args)
        {
            int odd = 0, even = 0;
            int[] arr = new int[] { 0, 1, 2, 5, 7, 8, 11 };

            foreach (int i in arr)
            {
                if (i % 2 == 0)
                    even++;
                else
                    odd++;
            }
            Console.WriteLine(@"奇数{0}个，偶数{1}个.",
                              odd, even);

        }
    }
}
