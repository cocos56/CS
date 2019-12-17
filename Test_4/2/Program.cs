using System;
//定义一个动物类,在动物类中有一个叫的抽象方法.  写两个子类,一个猫一个狗,继承自动物类,并实现相应的抽象方法.（抽象类）

namespace _2
{
    abstract class Animal
    {
        public abstract void cry();
    }

    class Cat : Animal
    {
        public override void cry()
        {
            Console.WriteLine("喵喵！");
        }
    }

    class Dog : Animal
    {
        public override void cry()
        {
            Console.WriteLine("汪汪!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            Dog dog = new Dog();
            cat.cry();
            dog.cry();
            Console.ReadLine();
        }
    }
}