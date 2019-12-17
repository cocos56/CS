using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace 电子商务
{
  public  class GoodManager
    {
        public Goods FindGoodById(int id)
        {
            //......
            return null;
        }
        public Goods FindGoodByName(string name)
        {
            Goods g = null;
            string sql = "select * from goods where name ='"+name+"'";
            MySqlConnection conn = GetConnection.getConnection();
            MySqlCommand comd = new MySqlCommand(sql, conn);
            MySqlDataReader reader = comd.ExecuteReader();

            while (reader.Read())
            {
                g = new Goods();
                g.id = reader.GetInt32(0);
                g.name = reader.GetString(1);
                g.price = reader.GetDouble(2);
                
            }
            conn.Close();
            return g;
        }
        public void AddGood(Goods g,int s_id)
        {
            string sql =  string.Format("insert into goods(name,price,s_id) values('{0}',{1},{2})", g.name,g.price,s_id);
            MySqlConnection conn = GetConnection.getConnection();
            MySqlCommand comd = new MySqlCommand(sql, conn);
            if (comd.ExecuteNonQuery() > 0)
            {
                Console.WriteLine("插入成功");
            }
            else
            {
                Console.WriteLine("插入失败");
            }
            conn.Close();
        }
        public List<Goods> FindGoodsBySellerId(int id)
        {
            List<Goods> list = new List<Goods>();
            string sql = "select * from goods where s_id = "+id;
            MySqlConnection conn = GetConnection.getConnection();
            MySqlCommand comd = new MySqlCommand(sql, conn);
            MySqlDataReader reader = comd.ExecuteReader();

            while (reader.Read())
            {
                Goods g = new Goods();
                g = new Goods();
                g.id = reader.GetInt32(0);
                g.name = reader.GetString(1);
                g.price = reader.GetDouble(2);
                list.Add(g);
            }
            return list;
        }
        public List<Goods> FindAllGoods()
        {
            List<Goods> list = new List<Goods>();
            string sql = "select * from goods g,seller s where g.s_id = s.id ";
            MySqlConnection conn = GetConnection.getConnection();
            MySqlCommand comd = new MySqlCommand(sql, conn);
            MySqlDataReader reader = comd.ExecuteReader();

            while (reader.Read())
            {
                Goods g = new Goods();
                g = new Goods();
                g.id = reader.GetInt32(0);
                g.name = reader.GetString(1);
                g.price = reader.GetDouble(2);
               
                Seller s = new Seller();
                s.id = reader.GetInt32(4);
                s.name = reader.GetString(5);
                g.seller = s;

                list.Add(g);
            }
            return list;
        }
    }
}
