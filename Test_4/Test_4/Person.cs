using System;

namespace Test_4
{
    class Person
    {
        public string Name;
        public double Age;

        public Person(string name, double age)
        {
            this.Name = name;
            this.Age = age;
        }

        public Person()
        {
            this.Name = "Null";
            this.Age = 0;
        }
        public void hello()
        {
            Console.WriteLine("我是人类");
        }
    }
}
