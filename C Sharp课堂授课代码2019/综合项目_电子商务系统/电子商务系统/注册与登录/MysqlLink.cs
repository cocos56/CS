using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace 电子商务系统
{
    public class MysqlLink
    {
        public MySqlConnection Conn { get; set; }
        public void Connect()
        {
            string url = "User ID=root;Password=;Host=localhost;Port=3306;Database=ecommerce;";
            this.Conn = new MySqlConnection(url);//创建数据库连接
            this.Conn.Open();//数据库连接打开
        }
    }
}
