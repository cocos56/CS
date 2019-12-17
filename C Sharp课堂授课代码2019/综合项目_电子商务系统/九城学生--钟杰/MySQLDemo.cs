using System;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Collections;

namespace mostone
{
    public class MySQLDemo
    {
        public static MySqlConnection GetConnection(string host, string port, string user, string password, string database)
        {
            string str = string.Format("User Id={0};Password={1};Host={2};Port={3};Database={4}"
                                            , user, password, host, port, database);
            MySqlConnection conn = new MySqlConnection(str);
            return conn;
        }

        public static void ExecuteSQL(string sql)
        {
            MySqlConnection conn = GetConnection(XMLDemo.Host, XMLDemo.Port
                                        , XMLDemo.Username, XMLDemo.Password
                                        , XMLDemo.Database);
            
            conn.Open();
            try{
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }catch(Exception e){
                Console.WriteLine("操作失败：{0}", e.Message);
                conn.Close();
                return;
            }
            conn.Close();
            return;
        }

        public static void ExecuteSQL(string sql, out int autoId)
        {
            int temp = -1;
            MySqlConnection conn = GetConnection(XMLDemo.Host, XMLDemo.Port
                                        , XMLDemo.Username, XMLDemo.Password
                                        , XMLDemo.Database);

            conn.Open();
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                cmd = new MySqlCommand("select LAST_INSERT_ID()", conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    temp = reader.GetInt32(0);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("操作失败：{0}", e.Message);
                conn.Close();
                autoId = -1;
                return;
            }
            conn.Close();
            autoId = temp;
            return;
        }

        public static List<object[]> ExecuteSQLResult(string sql)
        {
            List<Object[]> lo;
            MySqlConnection conn = GetConnection(XMLDemo.Host, XMLDemo.Port
                                        , XMLDemo.Username, XMLDemo.Password
                                        , XMLDemo.Database);
            conn.Open();

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                try
                {
                    lo = new List<object[]>();
                    while (reader.Read())
                    {
                        int i = reader.FieldCount;
                        Object[] temps = new Object[i];
                        while (i > 0) {
                            temps[i-1] = reader.GetValue(i-1);
                            i--;
                        }
                        lo.Add(temps);
                    }
                }
                catch (Exception e) {
                    Console.WriteLine("操作失败：{0}", e.Message);
                    conn.Close();
                    return null;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("操作失败：{0}", e.Message);
                conn.Close();
                return null;

            }
            conn.Close();
            return lo;

        }

        public static User FindUserById(int id, bool isBuyer)
        {
            User user = null;
            string sql;
            List<Object[]> resultList;

            if (true == isBuyer)
            {
                sql = string.Format("select * from buyer where id = '{0}'"
                                            , id);
                resultList = ExecuteSQLResult(sql);

                if (0 != resultList.Count)
                {
                    user = new Buyer((int)resultList[0][0]
                                    , resultList[0][1].ToString()
                                    , resultList[0][2].ToString()
                                    , (double)resultList[0][3]);
                }
            }
            else
            {
                sql = string.Format("select * from Seller where id = '{0}'"
                                            , id);
                resultList = ExecuteSQLResult(sql);
                
                if (0 != resultList.Count)
                {
                    user = new Seller((int)resultList[0][0]
                                    , resultList[0][1].ToString()
                                    , resultList[0][2].ToString()
                                    , (double)resultList[0][3]);
                }
            }

            return user;
        }

        public static User FindUserByName(string name, bool isBuyer)
        {
            User user = null;
            string sql;
            List<Object[]> resultList;

            if (true == isBuyer)
            {
                sql = string.Format("select * from buyer where name = '{0}'"
                                            , name);
                resultList = ExecuteSQLResult(sql);

                if (0 != resultList.Count)
                {
                    foreach (Object[] os in resultList)
                    {
                        user = new Buyer((int)os[0]
                                            , os[1].ToString()
                                            , os[2].ToString()
                                            , (double)os[3]);
                    }
                }
            }
            else{
                sql = string.Format("select * from Seller where name = '{0}'"
                                            , name);
                resultList = ExecuteSQLResult(sql);

                if (0 != resultList.Count)
                {
                    foreach (Object[] os in resultList)
                    {
                        user = new Seller((int)os[0]
                                            , os[1].ToString()
                                            , os[2].ToString()
                                            , (double)os[3]);
                    }
                }
            }
       
            return user;
        }

        public static List<Goods> FindGoodsByOwner(User user)
        {
            string sql;
            List<Object[]> lo;
            List<Goods> lg = null;

            sql = "select * from goods where s_id = " + user.Id;
            lo = ExecuteSQLResult(sql);

            if (0 != lo.Count)
            {
                lg = new List<Goods>();
                foreach (Object[] o in lo)
                {
                    lg.Add(new Goods((int)o[0], o[1].ToString(), (double)o[2], (int)o[3], (int)o[4], (1 == (SByte)o[5]) ? true : false));
                }

                if (0 == lg.Count)
                {
                    return null;
                }
            }
            return lg;
        }

        public static Goods FindGoodsById(int id)
        {
            string sql;
            List<object[]> lo;

            sql = "select * from goods where id = " + id;
            lo = ExecuteSQLResult(sql);

            if (0 != lo.Count)
            {
                return new Goods((int)lo[0][0], lo[0][1].ToString()
                                , (double)lo[0][2], (int)lo[0][3], (int)lo[0][4]
                                , (1 == (SByte)lo[0][5]) ? true : false);
            }
            return null;
        }

        public static List<Goods> FindAllGoods()
        {
            List<Goods> lgs = null;
            List<object[]> lo;
            
            string sql = "select * from goods where isSale = 1";
            lo = ExecuteSQLResult(sql);

            if (0 != lo.Count)
            {
                lgs = new List<Goods>();
                foreach (object[] os in lo)
                {
                    lgs.Add(new Goods((int)os[0], os[1].ToString()
                                        , (double)os[2], (int)os[3]
                                        , (int)os[4]
                                        , (1 == (SByte)os[5]) ? true : false));
                }
            }

            return lgs;
        }

        public static List<PurchaseMess> FindPurMessByBuyer(Buyer buyer)
        {
            string sql;
            List<Object[]> lo;
            List<PurchaseMess> lg = null;

            sql = "select * from purchasemess where bu_id = " 
                    + buyer.Id
                    + " order by o_id";
            lo = ExecuteSQLResult(sql);

            if (0 != lo.Count)
            {
                lg = new List<PurchaseMess>();
                foreach (Object[] o in lo)
                {
                    lg.Add(new PurchaseMess((int)o[0], o[1].ToString()
                                                , (double)o[2], (int)o[3]
                                                , (int)o[4], (int)o[5]
                                                , (int)o[6], o[7].ToString()));
                }

                if (0 == lg.Count)
                {
                    return null;
                }
            }
            return lg;
        }

        public static PurchaseMess FindPurMessByOIdAndSellerAndBuyer(int oid, Seller seller, Buyer buyer)
        {
            string sql;
            List<Object[]> lo;

            sql = string.Format("select * from purchasemess "
                                    +"where o_id = {0} and su_id = {1} and bu_id = {2}"
                                    , oid, seller.Id, buyer.Id);
            lo = ExecuteSQLResult(sql);

            if (0 != lo.Count)
            {
                return new PurchaseMess((int)lo[0][0], lo[0][1].ToString()
                                        , (double)lo[0][2], (int)lo[0][3]
                                        , (int)lo[0][4], (int)lo[0][5]
                                        , (int)lo[0][6], lo[0][7].ToString());
            }
            return null;
        }

        public static List<PurchaseMess> FindPurMessBySeller(Seller seller)
        {
            string sql;
            List<Object[]> lo;
            List<PurchaseMess> lp = null;

            sql = "select * from purchasemess where su_id = " + seller.Id;
            lo = ExecuteSQLResult(sql);

            if (0 != lo.Count)
            {
                lp = new List<PurchaseMess>();
                foreach (Object[] o in lo)
                {
                    lp.Add(new PurchaseMess((int)o[0], o[1].ToString(), (double)o[2], (int)o[3], (int)o[4], (int)o[5], (int)o[6], o[7].ToString()));
                }
            }

            return lp;
        }

        public static List<PurchaseMess> FindPurMessBySellerAndState(Seller seller, string state)
        {
            string sql;
            List<Object[]> lo;
            List<PurchaseMess> lp = null;

            sql = string.Format("select * from purchasemess where su_id = {0} and purstate = '{1}'"
                                , seller.Id, state);
            lo = ExecuteSQLResult(sql);

            if (0 != lo.Count)
            {
                lp = new List<PurchaseMess>();
                foreach (Object[] o in lo)
                {
                    lp.Add(new PurchaseMess((int)o[0], o[1].ToString(), (double)o[2], (int)o[3], (int)o[4], (int)o[5], (int)o[6], o[7].ToString()));
                }
            }

            return lp;
        }

        public static void InserGoods(Goods good)
        {
            string sql;

            sql = string.Format("insert into goods(name, price, nums, s_id, isSale) "
                                + "values('{0}', {1}, {2}, {3}, {4})"
                                , good.Name, good.Price, good.Nums, good.S_id, good.IsSale?1:0);
            ExecuteSQL(sql);
        }

        public static void InsertUser(string username, string password, bool isBuyer)
        {
            string sql;

            sql = string.Format("insert into {0}(name, pass, saves) "
                                    + "values('{1}', '{2}', {3})"
                                    , isBuyer?"buyer":"seller"
                                    , username, password, 1000.0);
            ExecuteSQL(sql);
        }

        public static void InsertUser(string username, string password, bool isBuyer, out int autoId)
        {
            string sql;

            sql = string.Format("insert into {0}(name, pass, saves) "
                                    + "values('{1}', '{2}', {3})"
                                    , isBuyer ? "buyer" : "seller"
                                    , username, password, 1000.0);
            ExecuteSQL(sql, out autoId);

        }

        public static void InsertOrderList(OrderList olist)
        {
            string sql;

            sql = string.Format("insert into OrderList(datestamp, summary) " 
                                    +"values({0}, {1})"
                                    , olist.DateStamp, olist.Summary);

            ExecuteSQL(sql);
        }

        public static void InsertOrderList(OrderList olist, out int autoId)
        {
            string sql;

            sql = string.Format("insert into OrderList(datestamp, summary) "
                                    + "values('{0}', {1})"
                                    , olist.DateStamp, olist.Summary);
            ExecuteSQL(sql, out autoId);
        }

        public static void InsertPurchaseMess(PurchaseMess purMess)
        {
            string sql;

            sql = string.Format("insert into PurchaseMess "
                                    + "values({0}, '{1}', {2}, {3}, {4}, {5}, {6}, '{7}')"
                                    , purMess.G_id, purMess.G_name, purMess.Price
                                    , purMess.Nums, purMess.Bu_id, purMess.Su_id
                                    , purMess.O_id, purMess.PurState);
            ExecuteSQL(sql);
        }

        public static void UpdateGoods(Goods good)
        {
            string sql;

            sql = string.Format("update goods "
                                    + "set name='{0}', price={1}, nums={2}, isSale={3} "
                                    + "where id = {4}"
                                    , good.Name, good.Price, good.Nums
                                    , (true == good.IsSale)?1:0, good.Id);
            ExecuteSQL(sql);
        }

        public static void UpdateUser(User user)
        {
            string sql;

            sql = string.Format("update {0} set saves = {1} where id = {2}"
                                    , (user is Buyer)?"buyer":"seller"
                                    , user.Saves, user.Id);
            ExecuteSQL(sql);
        }

        public static void UpdatePurMess(PurchaseMess pmess)
        {
            string sql;

            sql = string.Format("update purchasemess set purstate = '{0}' where o_id = {1} and g_id = {2}"
                                    , pmess.PurState, pmess.O_id, pmess.G_id);
            ExecuteSQL(sql);
        }
    }
}
