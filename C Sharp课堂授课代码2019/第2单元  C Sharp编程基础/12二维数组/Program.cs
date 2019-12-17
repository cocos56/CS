using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12二维数组
{
    class Program
    {
        static void Main(string[] args)
        {
            //二维数组的每一维都是一个一维数组
            int[][] b = new int[3][];
            b[0] = new int[3] { 4, 8, 12 };
            b[1] = new int[4] { 3, 6, 9, 18 };
            b[2] = new int[2];
            for (int i = 0; i < b.Length; i++)
            {
                for (int j = 0; j < b[i].Length; j++)
                {
                    Console.Write(b[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
