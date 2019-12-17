using System;

namespace _02面向对象初步
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            //p._name = "张三";
            p.Name = "张三";
            p.Gender = (Gender)'春';
            p.Age = -23;
            p.Weight = 60.0;
            p.CHLSS();
            Console.ReadKey();
        }
    }
}