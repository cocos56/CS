using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace _07重写Equals方法
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            Stack s = new Stack();
            Queue q = new Queue();//上述三种都是有顺序的

            Hashtable ht = new Hashtable();
            ht.Add(1, new Cat("lili", 1));
            bool b=ht.ContainsValue(new Cat("lili", 1));
            Console.WriteLine(b);
            
            
        }
    }
    public class Cat
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public Cat(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public override bool Equals(object obj)
        {
            if (obj is Cat)
            {
                Cat c = (Cat)obj;
                if (c.Age==this.Age&&c.Name==this.Name)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public override int GetHashCode()
        {
            return this.Name.GetHashCode()^this.Age.GetHashCode();
        }
       
    }
}
