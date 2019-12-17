using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 简单工厂模式
{
    class Program
    {
        static void Main(string[] args)
        {//高内聚 低耦合
           Beauty li = BeautyFactory.GetBeauty("luoli");
            li.Smile();
        }
    }
    public class Beauty
    {
        public virtual void Smile()
        {
            Console.WriteLine("笑了");
        }
    }
    public class Luoli:Beauty
    {
        public override void Smile()
        {
            Console.WriteLine("嘻嘻~");
        }
    }
    public class YueJie:Beauty
    {
        public override void Smile()
        {
            Console.WriteLine("哼哼");
        }
    }
    public class Nvwang : Beauty
    {
        public override void Smile()
        {
            Console.WriteLine("吼吼");
        }
    }
    public class Nvhanzi : Beauty
    {
        public override void Smile()
        {
            Console.WriteLine("哈哈~");
        }
    }

    public class BeautyFactory
    {
        public static Beauty GetBeauty(string s)
        {
            Beauty b = null;
            //s --->luoli yuejie nvwang nvhanzi  用if...else好，上边判断好下边就不需要判断了 而if...if...反而不好
            if (s=="luoli")
            {
                b = new Luoli();
            }
            else if (s=="yuejie")
            {
                b = new YueJie();
            }
            else if (s=="nvwang")
            {
                b = new Nvwang();
            }
            else
            {
                b = new Nvhanzi();
            }

            return b;
        }
    }
}
