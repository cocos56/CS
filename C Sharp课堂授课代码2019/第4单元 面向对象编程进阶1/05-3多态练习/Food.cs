using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_3多态练习
{
    public abstract class Food
    //public  class Food
    {
        public abstract void Eated();

        public Food()
        {

        }
        //该方法可以不必写，当方法不必写的时候（方法要不要实现的问题），可以将该方法定义为抽象方法 (关键是看方法能不能描述出来，若不能描述出来，则应该定义为抽象方法) 
        //如果一个类中含有抽象方法，那么这个类一定是抽象类  反之，一个抽象类中可以没有抽象方法，抽象类中不一定有抽象方法
        public void M()
        {

        }

        //public virtual void Eated()
        //{
        //    Console.WriteLine("食物被吃了");
        //}
    }
    public class HotDog : Food
    {
        public override void Eated()//override后面按空格 出现提示 选择方法 快速写代码
        {
            Console.WriteLine("热狗 很nice");
        }
        public HotDog()
            : base()
        {

        }
    }
    public class Chicken : Food
    {
        public override void Eated()
        {
            Console.WriteLine("我爱吃鸡肉");
        }
    }
    public class Potato : Food
    {
        public override void Eated()
        {
            Console.WriteLine("土豆哪里去玩");
        }
    }
    public class Fire : Food
    {
        public override void Eated()
        {
            Console.WriteLine("火锅不错！");
        }
    }
}
