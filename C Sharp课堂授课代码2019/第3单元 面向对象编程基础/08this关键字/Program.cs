using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08this关键字
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    class Person
    {
        string name;
        int age;

        Person(string n, int a)
        {
            name = n;
            age = a;
        }

        Person(string n)
        {
            name = n;
            age = -1;
        }
        //this：引用该类的父类中定义的字段和方法
        Person()
            : this("", 0)
        {
        }

        void sayHello()
        {
            Console.WriteLine("Hello!  My name is " + name);
        }

        void sayHello(Person another)
        {
            Console.WriteLine("Hello," + another.name + "! My name is " + name);
        }

        bool isOlderThan(int anAge)
        {
            bool flg;
            if (age > anAge) flg = true; else flg = false;
            return flg;
        }
    }

}
