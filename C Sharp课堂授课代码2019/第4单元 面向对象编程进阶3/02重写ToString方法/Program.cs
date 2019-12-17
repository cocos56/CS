using System;

namespace _02重写ToString方法
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("张三",18);
            Console.WriteLine(p.ToString());
            //object o = new object();
            //o.ToString();
        }
    }
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public override string ToString()
        {
            return this.Name + "今年" + this.Age + "岁了";
        }
    }
}