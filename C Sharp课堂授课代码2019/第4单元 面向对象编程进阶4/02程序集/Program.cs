using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace _02程序集
{
    class Program
    {
        static void Main(string[] args)
        {
            //没有对象通过类来获得Type描述
            Type t1 = typeof(Dog);         
            Dog d1 = new Dog();
            Type t2 = d1.GetType();//d1指向的对象的Type描述
            //Console.WriteLine(t2);

            Type t3 = Type.GetType(("_02程序集.Dog"));
            PropertyInfo pi=t3.GetProperty("Age");
            Console.WriteLine(pi.PropertyType.ToString());

        }
    }
    class Dog
    {
        public int Age { get; set; }
        public void Bark()
        { }
    }
}
