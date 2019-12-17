using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 测试程序集
{
    public class Person
    {
        public Person()
        {
            Console.WriteLine("哐当一声，一个人诞生了");
        }
        public int Age { get; set; }
        public string Name { get; set; }
        public void SayHello()
        {
            Console.WriteLine("你好啊！");
        }
    }
}
