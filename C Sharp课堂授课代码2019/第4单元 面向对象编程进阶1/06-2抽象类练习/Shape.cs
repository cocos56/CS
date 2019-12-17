using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_2抽象类练习
{
    //作业：计算形状Shape(圆Circle，矩形Square?，正方形Rectangle)的面积、周长
    public abstract class Shape
    {
        public abstract void Area();
        public abstract void Length();
        //void GetPerimeter();周长
    }
}
