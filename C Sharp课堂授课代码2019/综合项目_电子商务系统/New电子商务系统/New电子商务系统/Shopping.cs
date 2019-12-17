using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace New电子商务系统
{ 
    public class Shopping
    {
        public static Goods g = null;
        public static Orderline ol = null;
        public static void ShowAllGoods()
        {            
            MySqlConnection conn = DB.Connect();
            string sql = "select * from goods";
            MySqlCommand comd = new MySqlCommand(sql, conn);//发送sql语句给数据库服务器
            MySqlDataReader reader = comd.ExecuteReader();//执行sql语句  MySqlDataReader类似于迭代器            
            while (reader.Read())//判断是否有下一个
            {
                g = new Goods();
                Console.Write("g_id:" + reader.GetInt32(0));//拿到商品ID
                Console.Write("\tg_name:" + reader.GetString(1));//拿到商品名字
                Console.Write("\tg_price:" + reader.GetString(2));//拿到商品价格
                Console.Write("\tg_amount:" + reader.GetDouble(3));//拿到剩余商品数量
                Console.Write("\tg_sid:" + reader.GetDouble(4));//拿到供货商（卖家）
                Console.WriteLine();
            }
            conn.Close();//关闭资源
        }
        
        public static Goods GetGoods(string name)
        {
            MySqlConnection conn = DB.Connect();
            string sql = "select * from goods where g_name='" + name + "'";
            MySqlCommand comd = new MySqlCommand(sql, conn);//发送sql语句给数据库服务器
            MySqlDataReader reader = comd.ExecuteReader();//执行sql语句  MySqlDataReader类似于迭代器            
            while (reader.Read())//判断是否有下一个
            {
                g = new Goods();
                g.G_id = Convert.ToInt32(reader.GetString(0));
                g.G_name = reader.GetString(1);
                g.G_price = Convert.ToDouble(reader.GetString(2));//拿到商品价格
                g.G_amount = Convert.ToInt32(reader.GetString(3));//拿到商品数量
                g.G_sid = Convert.ToInt32(reader.GetString(4));
            }
            conn.Close();//关闭资源
            return g; 
        }
        public static bool AddShoppingByName(object o, string shoppingName,int nums)//o-->用户类别 nums-->商品数量 name-->商品名
        {                       
            bool b = false;
            g = GetGoods(shoppingName);
            if (g.G_amount > nums)
            {
                if (o is Customer)
                {                    
                    Customer c = (Customer)o;
                    MySqlConnection conn = DB.Connect();
                    string sql = "insert into orderline(ol_name,ol_price,ol_amount,ol_sid,ol_cid,ol_gid) values ('" + shoppingName + "'," + g.G_price + "," + nums + "," + g.G_sid + "," + c.Id + "," + g.G_id + ");";
                    Console.WriteLine(sql);
                    MySqlCommand comd = new MySqlCommand(sql, conn);//发送sql语句给数据库服务器
                    MySqlDataReader reader = comd.ExecuteReader();//执行sql语句  MySqlDataReader类似于迭代器            
                    conn.Close();//关闭资源
                    b = true;                                      
                }
            }
            else
            {
                b = false;
            }                                  
            return b;
        }
        public static bool DelShoppingByName(object o, string shoppingName)
        {
            bool b = false;
            if (o is Customer)
            {
                Customer c = (Customer)o;
                MySqlConnection conn = DB.Connect();
                g = GetGoods(shoppingName);                
                string sql = "delete from orderline where ol_price='" + g.G_price + "';";
                MySqlCommand comd = new MySqlCommand(sql, conn);//发送sql语句给数据库服务器
                MySqlDataReader reader = comd.ExecuteReader();//执行sql语句  MySqlDataReader类似于迭代器                           
                conn.Close();//关闭资源 
                b = true;                                   
            }
            return b;
        }
        public static bool UpdateShoppingByName(object o, string name, int nums)//nums可为正负数
        {
            bool b = false;
            if (o is Customer)
            {
                Customer c = (Customer)o;
                MySqlConnection conn = DB.Connect();
                string sql = "update orderline set ol_amount=" + nums + " where ol_name='" + name + "';";
                MySqlCommand comd = new MySqlCommand(sql, conn);//发送sql语句给数据库服务器
                MySqlDataReader reader = comd.ExecuteReader();//执行sql语句  MySqlDataReader类似于迭代器                                                               
                conn.Close();//关闭资源
                b = true;                     
            }
            else
            {
                b = false;
            }
            return b;
        }
        public static bool SelecteShoppingByName(object o, string name)
        {
            bool b = false;              
            if (o is Customer)
            {
                Customer c = (Customer)o;
                MySqlConnection conn = DB.Connect();
                string sql = "select * from orderline where ol_name='" + name + "';";
                MySqlCommand comd = new MySqlCommand(sql, conn);//发送sql语句给数据库服务器
                MySqlDataReader reader = comd.ExecuteReader();//执行sql语句  MySqlDataReader类似于迭代器                           
                while (reader.Read())//判断是否有下一个
                {
                    ol = new Orderline();
                    Console.Write("ol_id:" + reader.GetInt32(0));//拿到商品ID
                    Console.Write("\tol_name:" + reader.GetString(1));//拿到商品名字
                    Console.Write("\tol_price:" + reader.GetString(2));//拿到商品价格
                    Console.Write("\tol_amount:" + reader.GetDouble(3));//拿到剩余商品数量
                    Console.WriteLine();
                }                
                conn.Close();//关闭资源
                b = true;                
            }
            else
            {
                b = false;
            }
            return b;
        }
    }
}
