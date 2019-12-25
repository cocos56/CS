using System;
using _06访问修饰符;

namespace _05接口练习
{
    class Program
    {
        //橡皮Rubber鸭子唧唧叫 真鸭子嘎嘎叫 木头鸭子不会叫
        //三种鸭子都会游泳
        static void Main(string[] args)
        {
            RealDuck rd = new RealDuck();
            //rd.Bark();
            //rd.Swim();
            RubberDuck rk = new RubberDuck();
            //rk.Bark();
            //rk.Swim();
            WoodDuck wd = new WoodDuck();
            wd.Swim();
            Student s1 = new Student();
            //s1.Age
        }
    }
    public interface Barkable
    {
        void Bark();
    }
    public interface Swimable
    {
        void Swim();
    }
    public class RealDuck : Barkable, Swimable
    {
        public void Bark()
        {
            Console.WriteLine("真鸭子嘎嘎叫");
        }

        public void Swim()
        {
            Console.WriteLine("真鸭子会游泳");
        }
    }
    public class RubberDuck : Barkable, Swimable
    {
        public void Bark()
        {
            Console.WriteLine("橡皮鸭子唧唧叫");
        }

        public void Swim()
        {
            Console.WriteLine("橡皮鸭子会游泳");
        }
    }
    public class WoodDuck : Swimable
    {
        public void Swim()
        {
            Console.WriteLine("木头鸭子仅会飘在水上");
        }
    }
}