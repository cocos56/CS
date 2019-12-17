using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace 电子商务
{
   public class GetConnection
    {
       static  MySqlConnection conn;
        public static MySqlConnection getConnection()
        {
            // 2000  8888 8989 
            string url = "User ID=root;Password=;Host=localhost;Port=3306;Database=zhang";
            conn = new MySqlConnection(url);
            conn.Open();
            return conn;
        }
        public static void ColoseConnection()
        {
            conn.Close();
        }

    }
}
