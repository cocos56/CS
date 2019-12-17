using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 期末作业
{
    public class Goods
    {
        private int code;
        private string name;
        private int price;

        public string getname
        {
            get { return name; }
        }
        public int getcode
        {
            get { return code; }
        }
        public int getprice
        {
            get { return price; }
        }
        public Goods(int code, string name, int price)
        {
            this.code = code;
            this.name = name;
            this.price = price;
        }

    }
}
