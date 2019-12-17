using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04接收用户输入
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入您的姓名");
            string name = Console.ReadLine();
            Console.WriteLine("您的姓名是{0}", name);
            Console.ReadKey();
        }
    }
}
