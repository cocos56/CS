using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace mostone
{
    public class PurchaseMess
    {
        public int G_id { get; set; }
        public string G_name { get; set; }
        public double Price { get; set; }
        public int Nums { get; set; }
        public int Bu_id { get; set; }
        public int Su_id { get; set; }
        public int O_id { get; set; }
        public string PurState { get; set; }

        public PurchaseMess() { 
        }

        public PurchaseMess(int g_id, string g_name, double price, int nums
                                , int bu_id, int su_id, int o_id, string purState) {
            G_id = g_id;
            G_name = g_name;
            Price = price;
            Nums = nums;
            Bu_id = bu_id;
            Su_id = su_id;
            O_id = o_id;
            PurState = purState;
        }

        public override string ToString()
        {
            return string.Format("{0}\t{1}\t{2}\t{3}\n{4}\t{5}\t{6}\t{7}"
                                    , G_id, G_name, Price, Nums, Bu_id
                                    , Su_id, O_id, PurState);
        }
    }
}
