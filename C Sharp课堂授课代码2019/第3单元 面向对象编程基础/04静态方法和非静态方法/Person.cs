using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04静态方法和非静态方法
{
    public class Person
    {
        public void M1()
        {
            Console.WriteLine("我是非静态方法");
        }
        public static void M2()
        {
            Console.WriteLine("我是一个静态方法");
        }
    }
}
