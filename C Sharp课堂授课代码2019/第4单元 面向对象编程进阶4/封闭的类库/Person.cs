using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 封闭的类库
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Person(string name,int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public void Haha()
        {
            Console.WriteLine("hahahaha");
        }
        private void Heihei()
        {
            Console.WriteLine("heiheihei");
        }
        public static void Hello()
        { }

    }
}
