using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_2抽象类练习
{
    //作业：计算形状Shape(圆Circle，矩形Square?，正方形Rectangle)的面积、周长
    class Program
    {
        static void Main(string[] args)
        {
            Shape sh = new Circle(5);
            sh.Area();
            sh.Length();
            Shape sh1 = new Square(5, 10);
            sh1.Area();
            sh1.Length();
        }
    }

}
