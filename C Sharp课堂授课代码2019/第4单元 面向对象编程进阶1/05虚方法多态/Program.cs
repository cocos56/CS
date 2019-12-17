using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_0虚方法多态
{
    class Program
    {
        static void Main(string[] args)
        {
            //概念：让一个对象能够表现出多种状态（类型）
            //条件：1.父类的引用指向子类的对象2。存在重写 3。存在继承关系 
            Chinese cn1 = new Chinese("西门大官人");
            Chinese cn2 = new Chinese("申公豹");
            Japanese j1 = new Japanese("树下君");
            Japanese j2 = new Japanese("井边子");
            Korea k1 = new Korea("送钟吉");
            Korea k2 = new Korea("飘进会");
            American a1 = new American("奥巴马");
            American a2 = new American("麦当娜");
            Person[] pers = { cn1, cn2, j1, j2, k1, k2, a1, a2 };
            for (int i = 0; i < pers.Length; i++)
            {
                //if (pers[i] is Chinese)
                //{
                //    ((Chinese)pers[i]).SayHello();
                //}
                //else if (pers[i] is Japanese)
                //{
                //    ((Japanese)pers[i]).SayHello();
                //}
                //else if (pers[i] is Korea)
                //{
                //    ((Korea)pers[i]).SayHello();
                //}
                //else if (pers[i] is American)
                //{
                //    ((American)pers[i]).SayHello();
                //}
                //else
                //{
                //    pers[i].SayHello();
                //}

                pers[i].SayHello();
            }
            Console.ReadKey();
        }
    }
    public class Person
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public Person(string name)
        {
            this.Name = name;
        }
        public virtual void SayHello()
        {
            Console.WriteLine("我是人类");
        }
    }
    public class Chinese : Person
    {
        public Chinese(string name) : base(name) { }
        public override void SayHello()
        {
            Console.WriteLine("我叫{0},我是中国人", this.Name);
        }
    }
    public class Japanese : Person
    {
        public Japanese(string name) : base(name) { }
        public override void SayHello()
        {
            Console.WriteLine("我叫{0},我是脚盆国（倭国）人", this.Name);
        }
    }
    public class Korea : Person
    {
        public Korea(string name) : base(name) { }
        public override void SayHello()
        {
            Console.WriteLine("我叫{0},我是韩国棒子", this.Name);
        }
    }
    public class American : Person
    {
        public American(string name) : base(name) { }
        public override void SayHello()
        {
            Console.WriteLine("我叫{0},我是星国人", this.Name);
        }
    }
}
