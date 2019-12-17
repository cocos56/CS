using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14var推断类型
{
    class Program
    {
        static void Main(string[] args)
        {
            //var:根据值能够推断出来类型
            //C#是一门强类型语言：在代码当中，必须对每一个变量的类型有一个明确的定义
            var n = 15;
            var n2 = "张三";
            var n3 = 5000m;
            Console.WriteLine(n.GetType());
            Console.WriteLine(n2.GetType());
            Console.WriteLine(n3.GetType());
            Console.ReadKey();
        }
    }
}
