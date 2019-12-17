using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07方法重载
{
    class Program
    {
        static void F()
        {
            Console.WriteLine("F()");
        }
        static void F(object o)
        {
            Console.WriteLine("F(object)");
        }
        static void F(int value)
        {
            Console.WriteLine("F(int)");
        }
        static void F(int a, int b)
        {
            Console.WriteLine("F(int, int)");
        }
        static void F(int[] values)
        {
            Console.WriteLine("F(int[])");
        }
        static void Main()
        {
            F();
            F(1);
            F((object)1);
            F(1, 2);
            F(new int[] { 1, 2, 3 });
        }
    }
}
