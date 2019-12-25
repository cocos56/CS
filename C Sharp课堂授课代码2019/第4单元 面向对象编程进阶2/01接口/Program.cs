using System;

namespace _01接口
{
    class Program
    {
        static void Main(string[] args)
        {
            //接口：其实就是一种能力、规范


            Console.ReadKey();
        }
    }
    public class Person
    {
        public void CHLSH()
        {
            Console.WriteLine("我是人类，我可以吃喝拉撒睡");
        }
    }
    public class NBAPlayer
    {
        public void KouLan()
        {
            Console.WriteLine("我可以扣篮");
        }
    }
    public class Student : Person, IKouLanable//顺序不能互换
    {
        public void KouLan()
        {
            Console.WriteLine("我也可以扣篮");
        }
        
    }
    /// <summary>
    /// 接口中的方法没有访问修饰符，默认是Public,方法没有定义(不带花括号)
    /// </summary>
    public interface IKouLanable
    {
        void KouLan();        
    }
}