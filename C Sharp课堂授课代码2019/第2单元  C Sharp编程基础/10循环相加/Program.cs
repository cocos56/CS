using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10循环相加
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum, n;

            Console.WriteLine("\n**** for statement ****");
            sum = 0;
            for (int i = 1; i <= 100; i++)
            { //初始化,循环条件,循环改变
                sum += i;		//循环体
            }
            Console.WriteLine("sum is " + sum);

            Console.WriteLine("\n**** while statement ****");
            sum = 0;
            n = 100;			//初始化
            while (n > 0)
            {	//循环条件
                sum += n;		//循环体
                n--;		//循环改变
            }
            Console.WriteLine("sum is " + sum);

            Console.WriteLine("\n**** do_while statement ****");
            sum = 0;
            n = 0;			//初始化
            do
            {
                sum += n;		//循环体
                n++;		//循环改变
            } while (n <= 100);//循环条件
            Console.WriteLine("sum is " + sum);

        }
    }
}
