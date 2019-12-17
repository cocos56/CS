using System;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Xml;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Threading;

namespace mostone
{
    class MController
    {
        public static void Init()
        {
            XMLDemo.ReadSqlInitXML();
        }

        public static void Stop()
        {

        }

        public static bool UsernameVerify(string username, bool isBuyer)
        {
            User user = MySQLDemo.FindUserByName(username, isBuyer);
            if (user == null)
            {
                return false;
            }
            return true;
        }

        public static User CheckUser(string name, string pass, bool isBuyer)
        {
            User user = MySQLDemo.FindUserByName(name, isBuyer);

            if (null == user) {
                return null;
            }

            if (pass.Equals(user.Pass))
            {
                return user;
            }
            return null;
        }

        public static PurchaseMess GeneratePurchase(Goods buyGood)
        {
            return new PurchaseMess(buyGood.Id, buyGood.Name, buyGood.Price, buyGood.Nums
                                        , Mostone.user.Id, buyGood.S_id, 1, "0"); 
        }

        public static int IsContain(Goods good)
        {
            foreach (KeyValuePair<int, Goods> kv in Mostone.trolley)
            {
                if (kv.Value.Id == good.Id
                    && kv.Value.S_id == good.S_id)
                {
                    return kv.Key;
                }
            }
            return -1;
        }

        public static int GetTrolleyGoodsNums(Goods good)
        {
            int result = -1;

            foreach (KeyValuePair<int, Goods> kv in Mostone.trolley)
            {
                if (kv.Value.Id == good.Id
                    && kv.Value.S_id == good.S_id)
                {
                    result = kv.Value.Nums;
                }
            }

            return result;
        }
    }
}
