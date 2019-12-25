using System;

namespace _04显示实现接口
{
    class Program
    {
        static void Main(string[] args)
        {
            IFlyable fly = new Bird();
            //fly.Fly();
            Bird bird = new Bird();
            bird.Fly();
        }
    }

    public interface IFlyable
    {
        void Fly();
    }
    public class Bird : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("鸟会飞");
        }
        /// <summary>
        /// 显示实现接口 只能在类中或结构体中定义
        /// </summary>
        void IFlyable.Fly()
        {
            Console.WriteLine("我是接口的飞");
        }
    }
}