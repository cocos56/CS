using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 电子商务
{
    public class OrderLine
    {
        public Goods good{get;set;}
        public OrderForm form { get; set; }
        public int num { get; set; }//数量
    }
}
