using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace 电子商务系统
{
    public class Seller
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Pwd { get; set; }
        public double Balance { get; set; }
        public Seller(string name,string pwd,double balance)
        {
            this.Name = name;
            this.Pwd = pwd;
            this.Balance = balance;
        }
        public Seller()
        {

        }
        public static bool FindSellerByName(string name)
        {
            MysqlLink ml = new MysqlLink();
            ml.Connect();
            string sql = "select * from seller where name='" + name + "'";
            Console.WriteLine(sql);//打印输出sql语句
            MySqlCommand comd = new MySqlCommand(sql, ml.Conn);//发送sql语句给数据库服务器
            MySqlDataReader reader = comd.ExecuteReader();//执行sql语句  MySqlDataReader类似于迭代器
            return reader.Read();
        }
        public static bool FindSellerByPwd(string pwd)
        {
            MysqlLink ml = new MysqlLink();
            ml.Connect();
            string sql = "select * from seller where pwd='" + pwd + "'";
            Console.WriteLine(sql);//打印输出sql语句
            MySqlCommand comd = new MySqlCommand(sql, ml.Conn);//发送sql语句给数据库服务器
            MySqlDataReader reader = comd.ExecuteReader();//执行sql语句  MySqlDataReader类似于迭代器
            return reader.Read();
        }
        public void ShowInfo()
        {                        
            while(true)
            {
                Console.WriteLine("请输入要查看的选项：1-所有个人信息  2-所有商品信息  3-销售商品信息  其他键返回");
                string s = Console.ReadLine();
                if (s=="1")
                {
                    ShowInfoByPersonName(this.Name);
                }
                else if(s=="2")
                {
                       
                }
                else if(s=="3")
                {

                }
                else
                {
                    Console.Clear();//清屏
                    Program.Welcome();
                }
            }
        }
                       
        public static void ShowInfoByPersonName(string name)
        {
            MysqlLink ml = new MysqlLink();
            ml.Connect();
            string sql = "select * from seller where name='" + name + "'";
            Console.WriteLine(sql);//打印输出sql语句
            MySqlCommand comd = new MySqlCommand(sql, ml.Conn);//发送sql语句给数据库服务器
            MySqlDataReader reader = comd.ExecuteReader();//执行sql语句  MySqlDataReader类似于迭代器            
            while (reader.Read())//判断是否有下一个
            {
                Console.WriteLine("id:"+reader.GetInt32(0));//拿到ID
                Console.WriteLine("name:"+reader.GetString(1));//拿到名字
                Console.WriteLine("pwd:"+reader.GetString(2));//拿到密码
                Console.WriteLine("balance:"+reader.GetDouble(3));//拿到余额
            }

        }
    }
}
