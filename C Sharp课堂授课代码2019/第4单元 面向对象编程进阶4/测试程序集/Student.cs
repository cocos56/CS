using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 测试程序集
{
    public class Student
    {
        public int Count { get; set; }
        public string Name { get; set; }
        public void SayHello()
        {
            Console.WriteLine("你好啊！");
        }
    }
}
