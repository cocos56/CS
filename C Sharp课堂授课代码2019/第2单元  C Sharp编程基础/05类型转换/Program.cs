using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05类型转换
{
    class Program
    {
        static void Main(string[] args)
        {
            //int n1 = 10;
            //int n2 = 3;
            //double d = n1 *1.0/ n2;
            //Console.WriteLine("{0:0.0000}", d);
            //Console.ReadKey();

            //转换成功就成了，转换失败，就抛出异常
            //int numberOne = Convert.ToInt32("123abc");
            //int numberOne=int.Parse("123abc");
            //Console.WriteLine(numberOne);

            int num = 100;
            bool b = int.TryParse("123", out num);
            Console.WriteLine(b);
            Console.WriteLine(num);
            Console.ReadKey();
        }
    }
}
