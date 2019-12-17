using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 电子商务
{
   public class Goods
    {
        public int id { get; set; }
        public string name { get; set; }
        public double price { get; set; }
        public Seller seller { get; set; }
        public override string ToString()
        {
           
            return "编号：" + id + " 名称：" + name + "价格：" + price+ " 所属卖家："+seller.name;
        }

    }
}
