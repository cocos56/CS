using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _14委托的几种调用方法
{
    public delegate void GreetingDelegate(string name);
    class Program
    {
        static void Main(string[] args)
        {
            //方法1---方法2
            GreetingManager gm = new GreetingManager();
            #region
            ////方法1
            //gm.GreetPeople("XuHong", EnglishGreeting);
            //gm.GreetPeople("许洪", ChineseGreeting);
            
            //方法2--委托连
            //GreetingDelegate delegate1;
            //delegate1 = EnglishGreeting;
            //delegate1 += ChineseGreeting;//发生了委托链
            //gm.GreetPeople("XuHong", delegate1);

            //方法3
            //gm.delegate1 = EnglishGreeting;
            //gm.delegate1 += ChineseGreeting;
            //gm.GreetPeople("XuHong", gm.delegate1);

            ////方法4            
            //gm.delegate1 = EnglishGreeting;
            //gm.delegate1 += ChineseGreeting;
            //gm.GreetPeople("XuHong");      //注意，这次不需要再传递 delegate1变量
            #endregion
            gm.MakeGreet += EnglishGreeting;
            gm.MakeGreet += ChineseGreeting;
            gm.GreetPeople("XuHong"); 
        }
        private static void EnglishGreeting(string name)
        {
            Console.WriteLine("Morning, " + name);
        }
        private static void ChineseGreeting(string name)
        {
            Console.WriteLine("早上好, " + name);
        }

    }
    public class GreetingManager
    {
        ////方法1---方法2
        //public void GreetPeople(string name, GreetingDelegate MakeGreeting)
        //{
        //    MakeGreeting(name);
        //}

        //方法3
        //在GreetingManager类的内部声明delegate1变量
        //public GreetingDelegate delegate1;
        //public void GreetPeople(string name, GreetingDelegate MakeGreeting)
        //{
        //    MakeGreeting(name);
        //}

        ////方法4
        ////在GreetingManager类的内部声明delegate1变量
        ////delegate1-->private:你把它(delegate1)声明为private了，客户端对它根本就不可见，那它还有什么用？
        ////delegate1-->public:在客户端可以对它进行随意的赋值等操作，严重破坏对象的封装性。
        //public GreetingDelegate delegate1;
        //public void GreetPeople(string name)
        //{
        //    if (delegate1 != null)
        //    {     //如果有方法注册委托变量
        //        delegate1(name);      //通过委托调用方法
        //    }
        //}

        //事件名--MakeGreet
        public event GreetingDelegate MakeGreet;
        public void GreetPeople(string name)
        {
            if (MakeGreet!=null)
            {
                MakeGreet(name);
            }
        }


    }
}
