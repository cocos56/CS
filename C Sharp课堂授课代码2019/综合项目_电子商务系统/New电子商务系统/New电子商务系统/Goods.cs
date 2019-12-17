using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New电子商务系统
{
    public class Goods
    {
        public int G_id { get; set; }
        public string G_name { get; set; }
        public double G_price { get; set; }
        public int G_amount { get; set; }
        public int G_sid { get; set; }
        public bool Status { get; set; }
        public Goods()
        {

        }
        public Goods(string g_name, double g_price, int g_amount, int g_sid, bool status)
        {
            this.G_amount = g_amount;
            this.G_price = g_price;
            this.G_name = g_name;
            this.G_sid = g_sid;
            this.Status = status;
        }
    }
}

