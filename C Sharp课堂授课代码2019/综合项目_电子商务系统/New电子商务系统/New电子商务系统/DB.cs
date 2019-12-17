using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace New电子商务系统
{
    public class DB
    {
        public static MySqlConnection conn;
        public static MySqlConnection Connect()
        {
            string url = "User ID=root;Password=;Host=localhost;Port=3306;Database=ecommerce;";
            conn = new MySqlConnection(url);//创建数据库连接
            conn.Open();//数据库连接打开
            return conn;
        }
    }
}
