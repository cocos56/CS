using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace 电子商务系统
{
    public class Customer
    {
        public static int num = 1;
        public int Id { get; set; }
        public string Name { get; set; }
        public string Pwd { get; set; }
        public double Balance { get; set; }
         public Customer(string name,string pwd,double balance)
        {
            this.Name = name;
            this.Pwd = pwd;
            this.Balance = balance;
        }
         public Customer()
        {

        }
         public static bool FindCustomerByName(string name)
         {
             MysqlLink ml = new MysqlLink();
             ml.Connect();
             string sql = "select * from customer where name='" + name + "'";
             Console.WriteLine(sql);//打印输出sql语句
             MySqlCommand comd = new MySqlCommand(sql, ml.Conn);//发送sql语句给数据库服务器
             MySqlDataReader reader = comd.ExecuteReader();//执行sql语句  MySqlDataReader类似于迭代器
             return reader.Read();
         }
         public static bool FindCustomerByPwd(string pwd)
         {
             MysqlLink ml = new MysqlLink();
             ml.Connect();
             string sql = "select * from customer where pwd='" + pwd + "'";
             Console.WriteLine(sql);//打印输出sql语句
             MySqlCommand comd = new MySqlCommand(sql, ml.Conn);//发送sql语句给数据库服务器
             MySqlDataReader reader = comd.ExecuteReader();//执行sql语句  MySqlDataReader类似于迭代器
             return reader.Read();
         }

         public static void GwcManager(Customer cm)//购物车管理
         {
             Console.WriteLine("欢迎使用购物车");
             while (true)
             {
                 Console.WriteLine("请输入你需要的操作 1---增加  2---修改  3---显示  4---删除  其他键退出");
                 string s = Console.ReadLine();
                 if (s == "1")
                 {
                     Add(cm);
                 }
                 else if (s == "2")
                 {
                     Update(cm);
                 }
                 else if (s == "3")
                 {
                     Show(cm);

                 }
                 else if (s == "4")
                 {
                     Delete(cm);
                 }
                 else
                 {
                     return;
                 }
             }
         }
         public static void Add(Customer cm)
         {
             Console.WriteLine("请输入购买商品名字、数量，以逗号分隔");
             string s = Console.ReadLine();
             string[] ss = s.Split(',');
             Orderline ol = new Orderline();//增加一条商品信息
             ol.Ol_id = num;
             ol.Ol_name = ss[0];
             ol.Ol_amount = Convert.ToInt32(ss[1]);
             //数据库连接 查询
             MysqlLink ml = new MysqlLink();
             ml.Connect();
             
             string[]sq=new string[3];
             sq[0]="select * from goods where g_name='"+ss[0]+"'";
             sq[1]="select * from customer where name='"+cm.Name+"'";
             //sq[2] = "select * from orderform where o_data='" + DateTime.Now.ToString() + "'";             
             string sql=null;
             for (int i = 0; i < sq.Length; i++)
			{
                
			    sql=sq[i];                
			}
            if (sql == sq[0])
            {
                MySqlCommand comd = new MySqlCommand(sql, ml.Conn);
                MySqlDataReader reader = comd.ExecuteReader();
                while (reader.Read())
                {
                    ol.Ol_gid = reader.GetInt32(0);
                    ol.Ol_price = reader.GetDouble(2);
                    ol.Ol_sid = reader.GetInt32(4);
                }
            }
            else if (sql == sq[1])
            {
                MySqlCommand comd = new MySqlCommand(sql, ml.Conn);
                MySqlDataReader reader = comd.ExecuteReader();
                while (reader.Read())
                {
                    ol.Ol_cid = reader.GetInt32(0);
                }
            }
            //else if (sql == sq[2])
            //{
            //    MySqlCommand comd = new MySqlCommand(sql, ml.Conn);
            //    MySqlDataReader reader = comd.ExecuteReader();
            //    while (reader.Read())
            //    {
            //        Console.WriteLine("OK!");
            //    }
            //}                                                       
             num++;
         }
         public static void Update(Customer cm)
         {
             Console.WriteLine("请输入需要修改商品的信息编号、修改的商品名和商品数量");
             string s = Console.ReadLine();
             string[] ss = s.Split(',');
             int n = Convert.ToInt32(ss[0]);
             string name = ss[1];
             int amount = Convert.ToInt32(ss[2]);
             cm.UpdateOrderline(n, name, amount);
             Console.WriteLine("修改成功");
         }
         public static void Delete(Customer cm)
         {
             Console.WriteLine("请输入你要删除的商品信息编号");
             string s = Console.ReadLine();
             int n = Convert.ToInt32(s);
             cm.DeleteOrderlineById(n);
             Console.WriteLine("删除成功！");
         }
         public static void Show(Customer cm)
         {
             Console.WriteLine("下面是所有学生信息");
             cm.GwcShow();
         }

         Dictionary<int, Orderline> dic = new Dictionary<int, Orderline>();
         public Orderline FindOrderlineById(int id)
         {
             Orderline ol = null;
             foreach (var item in dic.Values)
             {
                 Orderline ol2 = item;
                 if (ol2.Ol_id == id)
                 {
                     ol = ol2;
                 }
             }
             return ol;
         }
         public bool DeleteOrderlineById(int id)
         {
             bool b = false;
             foreach (var item in dic.Values)
             {
                 Orderline ol2 = item;
                 if (ol2.Ol_id == id)
                 {
                     dic.Remove(id);
                     b = true;
                 }
             }
             return b;
         }
         public void UpdateOrderline(int id, string name, int amount)
         {
             foreach (var item in dic.Values)
             {
                 Orderline ol2 = item;
                 if (ol2.Ol_id == id)
                 {
                     ol2.Ol_name = name;
                     ol2.Ol_amount = amount;
                 }
             }
         }
         //public bool AddOrderline(Orderline ol)
         //{
         //    bool b = false;
         //    MysqlLink ml = new MysqlLink();
         //    ml.Connect();
         //    string sql = "insert into orderline(ol_name,ol_price,ol_amount,ol_sid,ol_cid,ol_gid) values('" + ol.Ol_name + "'," + ol.Ol_price + ",ol.Ol_amount,ol.Ol_sid,ol.Ol_cid,ol.Ol_gid);";
         //    MySqlCommand comd = new MySqlCommand(sql, ml.Conn);// 发送sql语句给数据库服务器
         //    int a = comd.ExecuteNonQuery();//执行sql语句
         //    Console.WriteLine(sql);
         //    if (a == 1)
         //    {
         //        return b = true;
         //    }
         //    return b;
         //}
         public void GwcShow()
         {
             foreach (var item in dic.Values)
             {
                 Console.WriteLine(item);
                 //Console.WriteLine(item.Ol_id + "\tname:" + item.Ol_name + "\tprice:" + item.Ol_price + "\tamount:" + item.Ol_amount + "\tol_sid:" + item.Ol_sid + "\tol_cid:" + item.Ol_cid + "\tol_oid:" + item.Ol_oid + "\tol_gid:" + item.Ol_gid);
             }
         }
    }
}
