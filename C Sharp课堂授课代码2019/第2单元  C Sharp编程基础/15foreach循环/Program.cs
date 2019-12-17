using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15foreach循环
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] nums = { 1, 2, 3, 4, 5, 6, 48, 66, 33, 22 };
            int[] nums = new int[100000000];
            Stopwatch sw = new Stopwatch();
            sw.Start();
            for (int i = 0; i < nums.Length; i++)
            {
                //Console.Write(nums[i]+" ");//需要有数组下标
            }
            sw.Stop();
            Console.WriteLine(sw.Elapsed);

            //00:00:00.3178235
            //00:00:00.4936962

            Console.WriteLine();
            Console.WriteLine("=======================");

            foreach (int i in nums)
            {
                //Console.Write(i + " ");//i--数组中的项
            }

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
