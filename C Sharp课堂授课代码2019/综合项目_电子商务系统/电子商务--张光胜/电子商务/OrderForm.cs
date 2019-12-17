using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 电子商务
{
   public class OrderForm
    {
        public int id ;
       
        public Customer customer;
        public double s_money ;
        public string o_date;
        public List<OrderLine> lines = new List<OrderLine>();
    }
}
