using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 电子商务系统
{
    public class OrderForm
    {
        public int O_id { get; set; }
        public DateTime O_date { get; set; }
        public OrderForm()
        {

        }
        public OrderForm(int o_id, DateTime o_date)
        {
            this.O_date = o_date;
            this.O_id = o_id;
        }

    }
}
