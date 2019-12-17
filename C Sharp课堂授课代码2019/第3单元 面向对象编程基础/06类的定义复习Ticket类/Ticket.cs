using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06类的定义复习Ticket类
{
    //写一个Ticket类，有一个距离属性（只读，在构造函数中对距离赋值）
    //有一个价格属性，价格属性也是只读
    //根据Distance计算Price的
    //0-100公里  票价不打折
    //101-200公里  票价打9.5折
    //201-300公里  票价打9折
    //300公里以上  票价打8折
    public class Ticket
    {
        private double _distance;

        public double Distance
        {
            get { return _distance; }
        }
        public Ticket(double distance)
        {
            if (distance < 0)
            {
                distance = 0;
            }
            this._distance = distance;
        }
        private double _price;

        public double Price
        {
            get
            {
                if (_distance > 0 && _distance <= 100)
                {
                    return _distance * 1.0 * 0.5;
                }
                else if (_distance > 101 && _distance <= 200)
                {
                    return _distance * 0.95 * 0.5;
                }
                else if (_distance > 201 && _distance <= 300)
                {
                    return _distance * 0.9 * 0.5;
                }
                else
                {
                    return _distance * 0.8 * 0.5;
                }
            }
        }

        public void ShowTicket()
        {
            Console.WriteLine("{0}公里{1}元", this.Distance, Price);
        }



    }

}
