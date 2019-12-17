using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05构造函数复习
{
    class Program
    {
        static void Main(string[] args)
        {
            Time t = new Time(11, 51, 00);
            Console.WriteLine(t.Hour + ":" + t.Minute + ":" + t.Second);
            Time t2 = new Time(5436);
            Console.WriteLine(t2.Hour + ":" + t2.Minute + ":" + t2.Second);

        }
    }
}
