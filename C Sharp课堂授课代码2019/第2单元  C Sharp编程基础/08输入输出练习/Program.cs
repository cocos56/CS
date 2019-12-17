using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08输入输出练习
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入用户的姓名");
            string name = Console.ReadLine();
            Console.WriteLine("请输入用户的语文成绩");
            double chinese = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("请输入用户的数学成绩");
            double math = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("请输入用户的英语成绩");
            double english = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("{0}您好，您的总成绩为{1}，您的平均成绩为{2:0.00}", name, chinese + math + english, (chinese + math + english) / 3);
            Console.ReadKey();
        }
    }
}
