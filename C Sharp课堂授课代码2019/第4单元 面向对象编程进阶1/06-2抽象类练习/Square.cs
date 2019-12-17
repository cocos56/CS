using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_2抽象类练习
{
    public class Square : Shape
    {
        public double Width { get; set; }
        public double Len { get; set; }
        public Square(double width, double len)
        {
            this.Width = width;
            this.Len = len;
        }
        public override void Area()
        {
            double s = this.Len * this.Width;
            Console.WriteLine("长度是{0}宽度是{1}的长方形的面积是{2}", this.Len, this.Width, s);
        }
        public override void Length()
        {
            double l = 2 * (this.Width + this.Len);
            Console.WriteLine("长度是{0}宽度是{1}的长方形的周长是{2}", this.Len, this.Width, l);
        }
    }
}
