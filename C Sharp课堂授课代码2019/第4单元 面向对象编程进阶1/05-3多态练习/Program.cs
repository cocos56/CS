using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_3多态练习
{
    class Program
    {
        static void Main(string[] args)
        {
            HotDog h = new HotDog();
            People p = new People();
            // Food f = new Food(); 
            p.ToEat(h);//多态  多态发生条件：1. 父类的引用(People类中:f)指向子类的对象(Program类中:h)  2.存在重写(Food:Eated()) 3.存在继承(HotDog:Food)
            //接口：(规定具体的功能，而自己不写实现，提供一种标准) 
        }
    }
}
