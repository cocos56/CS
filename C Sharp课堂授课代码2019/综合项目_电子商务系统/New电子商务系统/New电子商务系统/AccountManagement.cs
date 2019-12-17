using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace New电子商务系统
{
    public class AccountManagement
    {
        public static void Open(object o)//注册账户
        {
            if (o is Seller)
            {
                Seller s = (Seller)o;
                Console.WriteLine("请输入用户名，20个字符以内");
                s.Name = Console.ReadLine();
                bool b = AccountManagement.FindAccountByName(s, s.Name);
                if (b)
                {
                    Console.WriteLine("用户名已存在，请重新输入！");
                    s.Name = Console.ReadLine();
                    b = AccountManagement.FindAccountByName(s, s.Name);
                }
                else
                {
                    Console.WriteLine("用户名合法！");
                }
                Console.WriteLine("请输入密码，20个字符以内");
                string s1 = Console.ReadLine();
                Console.WriteLine("请再输入一次密码！");
                string s2 = Console.ReadLine();
                if (s1 != s2)
                {
                    Console.WriteLine("两次密码不一致，请重新输入！");
                    s2 = Console.ReadLine();
                }
                else
                {
                    s.Pwd = s2;
                }
                Console.WriteLine("请输入初始账户金额！");
                s.Balance = Convert.ToDouble(Console.ReadLine());
                bool b1 = AddAccount(s);
            }
            else if (o is Customer)
            {
                Customer c = (Customer)o;
                Console.WriteLine("请输入用户名，20个字符以内");
                c.Name = Console.ReadLine();
                bool b = AccountManagement.FindAccountByName(c, c.Name);
                if (b)
                {
                    Console.WriteLine("用户名已存在，请重新输入！");
                    c.Name = Console.ReadLine();
                    b = AccountManagement.FindAccountByName(c, c.Name);
                }
                else
                {
                    Console.WriteLine("用户名合法！");
                }
                Console.WriteLine("请输入密码，20个字符以内");
                string s1 = Console.ReadLine();
                Console.WriteLine("请再输入一次密码！");
                string s2 = Console.ReadLine();
                if (s1 != s2)
                {
                    Console.WriteLine("两次密码不一致，请重新输入！");
                    s2 = Console.ReadLine();
                }
                else
                {
                    c.Pwd = s2;
                }
                Console.WriteLine("请输入初始账户金额！");
                c.Balance = Convert.ToDouble(Console.ReadLine());
                bool b1 = AddAccount(c);           
            }                                    
        }
        public static bool AddAccount(object o)
        {
            bool b = false;
            MySqlConnection conn = DB.Connect();
            MySqlCommand comd = null;         
            if (o is Seller)
            {
                Seller s = (Seller)o;
                string sql = "insert into seller(name,pwd,balance) values('{0}','{1}',{2})";
                sql = string.Format(sql, s.Name, s.Pwd, s.Balance);//F12转到定义，Format函数有params object[] args（可变参数）
                comd = new MySqlCommand(sql, conn);// 发送sql语句给数据库服务器
            }
            else if (o is Customer)
            {
                Customer c = (Customer)o;
                string sql = "insert into customer(name,pwd,balance) values('{0}','{1}',{2})";
                sql = string.Format(sql, c.Name, c.Pwd, c.Balance);//F12转到定义，Format函数有params object[] args（可变参数）
                comd = new MySqlCommand(sql, conn);// 发送sql语句给数据库服务器
            }            
            int a = comd.ExecuteNonQuery();//执行sql语句
            if (a == 1)
            {
                return b = true;
            }
            conn.Close();//关闭资源
            return b;
        }
        public static Customer GetCustomer(string name)
        {
            MySqlConnection conn = DB.Connect();
            MySqlCommand comd = null;
            string sql = "select * from customer where name='" + name + "';";
            comd = new MySqlCommand(sql, conn);// 发送sql语句给数据库服务器
            MySqlDataReader reader = comd.ExecuteReader();//执行sql语句  reader类似于迭代器
            Customer c = new Customer();
            while(reader.Read())
            {
                c.Id = Convert.ToInt32(reader.GetString(0));
                c.Name = reader.GetString(1);
                c.Pwd = reader.GetString(2);
                c.Balance = Convert.ToDouble(reader.GetString(3));                     
            }        
            conn.Close();//关闭资源
            return c;
        }
        public static bool DeleteAccount(object o,string name)
        {
            bool b = false;
            MySqlConnection conn = DB.Connect();
            MySqlCommand comd = null;
            if (o is Seller)
            {
                Seller s = (Seller)o;
                string sql = "delete from seller where name='" + name + "';";
                comd = new MySqlCommand(sql, conn);// 发送sql语句给数据库服务器
            }
            else if (o is Customer)
            {
                Customer c = (Customer)o;
                string sql = "delete from customer where name='" + name + "';";
                comd = new MySqlCommand(sql, conn);// 发送sql语句给数据库服务器
            }
            int a = comd.ExecuteNonQuery();//执行sql语句
            if (a == 1)
            {
                return b = true;
            }
            conn.Close();//关闭资源
            return b;
        }
        public static bool UpdateAccountByName(object o, string name)
        {
            MySqlConnection conn = DB.Connect();
            MySqlCommand comd = null;
            if (o is Seller)
            {
                Seller s = (Seller)o;
                string sql = "update seller set name='" + name + "' where name='" + s.Name + "';";
                comd = new MySqlCommand(sql, conn);// 发送sql语句给数据库服务器
            }
            else if (o is Customer)
            {
                Customer c = (Customer)o;
                string sql = "update customer set name='" + name + "' where name='" + c.Name + "';";
                comd = new MySqlCommand(sql, conn);// 发送sql语句给数据库服务器
            }
            MySqlDataReader reader = comd.ExecuteReader();//执行sql语句  reader类似于迭代器
            return true; 
        }
        public static bool UpdateAccountByPwd(object o, string pwd)
        {
            MySqlConnection conn = DB.Connect();
            MySqlCommand comd = null;
            if (o is Seller)
            {
                Seller s = (Seller)o;
                string sql = "update seller set pwd='" + pwd + "' where name='" + s.Name + "';";
                comd = new MySqlCommand(sql, conn);// 发送sql语句给数据库服务器
            }
            else if (o is Customer)
            {
                Customer c = (Customer)o;
                string sql = "update customer set pwd='" + pwd + "' where name='" + c.Name + "';";
                comd = new MySqlCommand(sql, conn);// 发送sql语句给数据库服务器
            }
            MySqlDataReader reader = comd.ExecuteReader();//执行sql语句  reader类似于迭代器
            return true;            
        }        
        public static bool FindAccountByName(object o,string name)
        {
            MySqlConnection conn = DB.Connect();
            MySqlCommand comd = null;
            if (o is Seller)
            {
                Seller s = (Seller)o;
                string sql = "select * from seller where name='" + name + "';";
                comd = new MySqlCommand(sql, conn);// 发送sql语句给数据库服务器
            }
            else if (o is Customer)
            {
                Customer c = (Customer)o;
                string sql = "select * from customer where name='" + name + "';";
                comd = new MySqlCommand(sql, conn);// 发送sql语句给数据库服务器
            }
            MySqlDataReader reader = comd.ExecuteReader();//执行sql语句  reader类似于迭代器
            return reader.Read();
        }
        public static bool FindAccountById(object o, string pwd)
        {
            MySqlConnection conn = DB.Connect();
            MySqlCommand comd = null;
            if (o is Seller)
            {
                Seller s = (Seller)o;
                string sql = "select * from seller where pwd='" + pwd + "';";
                comd = new MySqlCommand(sql, conn);// 发送sql语句给数据库服务器
            }
            else if (o is Customer)
            {
                Customer c = (Customer)o;
                string sql = "select * from customer where pwd='" + pwd + "';";
                comd = new MySqlCommand(sql, conn);// 发送sql语句给数据库服务器
            }
            MySqlDataReader reader = comd.ExecuteReader();//执行sql语句  reader类似于迭代器
            return reader.Read();
        }

    }
}
