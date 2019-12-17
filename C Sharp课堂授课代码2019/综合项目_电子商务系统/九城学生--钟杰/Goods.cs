using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace mostone
{
    public class Goods
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Nums { get; set; }
        public int S_id { get; set; }
        public bool IsSale { get; set; }

        public Goods() { 
        }

        public Goods(int s_id)
        {
            S_id = s_id;
        }

        public Goods(int id, string name, double price, int nums, int s_id, bool isSale)
        {
            Id = id;
            Name = name;
            Price = price;
            Nums = nums;
            S_id = s_id;
            IsSale = isSale;
        }

        public override string ToString()
        {
            return string.Format("{0}\t{1}\t{2}\t{3}\n{4}\t{5}"
                                    , Id, Name, Price, Nums, S_id, IsSale);
        }
    }
}
