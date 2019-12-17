using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace mostone
{
    public class OrderList
    {
        public int Id { get; set; }
        public DateTime DateStamp{ get; set; }
        public double Summary{ get; set; }

        public OrderList() { 
        }

        public OrderList(DateTime date)
        {
            DateStamp = date;
        }

        public OrderList(int id, DateTime date, double summary) {
            Id = id;
            DateStamp = date;
            Summary = summary;
        }

        public override string ToString()
        {
            return string.Format("{0}\t{1}\t{2}"
                                    , Id, DateStamp, Summary);
        }
    }
}
