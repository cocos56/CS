using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_2抽象类练习
{
    public class Circle : Shape
    {
        public double Radius { set; get; }
        public Circle(double radius)
        {
            this.Radius = radius;
        }
        public override void Area()
        {
            double s = Math.PI * this.Radius * this.Radius;
            Console.WriteLine("半径是{0}的圆的面积是{1}", this.Radius, s);
        }
        public override void Length()
        {
            double l = 2 * Math.PI * this.Radius;
            Console.WriteLine("半径是{0}的圆的周长是{1}", this.Radius, l);
        }
    }
}
