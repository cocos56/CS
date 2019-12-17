using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05构造函数和析构函数
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student("张三", '男', 18, 60.0);
            s.SayHello();
            Student s2 = new Student("李四", '男', 85, 95, 95);
            s2.ShowScore();
            Console.ReadKey();
        }
    }
}
