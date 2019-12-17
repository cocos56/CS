using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace 电子商务
{
   public class CustomerManager:ICustomerManager //Model
    {
        public Customer FindCustomerByName(string name)
        {
            Customer c = null;
            string sql = "select * from customer where name = '"+name+"'";
            MySqlConnection conn = GetConnection.getConnection();
            MySqlCommand comd = new MySqlCommand(sql, conn);
            MySqlDataReader reader = comd.ExecuteReader();
            while (reader.Read())
            {
                c = new Customer();
                c.id = reader.GetInt32(0);
                c.name = reader.GetString(1);
                c.psw = reader.GetString(2);
                c.telphone = reader.GetString(3);
                c.address = reader.GetString(4);
            }
            conn.Close();
            return c;
        }

        public Customer FindCustomerById(int id)
        {
            throw new NotImplementedException();
        }

        public void SaveCustomer(Customer c)
        {
            string sql = string.Format("insert into customer(name,psw,address,telphone) values('{0}','{1}','{2}','{3}')", c.name, c.psw, c.address, c.telphone);
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

        public void UpdateCustomer(Customer c)
        {
            throw new NotImplementedException();
        }

        public bool DeleteCustomerById(int id)
        {
            throw new NotImplementedException();
        }

        public bool DeleteCustomerByName(string name)
        {
            throw new NotImplementedException();
        }



        public Seller FindSellerByName(string name)
        {
            Seller seller = null;
            string sql = "select * from seller where name = '"+name+"'";
            MySqlConnection conn = GetConnection.getConnection();
            MySqlCommand comd = new MySqlCommand(sql, conn);
            MySqlDataReader reader = comd.ExecuteReader();
            while (reader.Read())
            {
                seller = new Seller();
                seller.id = reader.GetInt32(0);
                seller.name = reader.GetString(1);
                seller.psw = reader.GetString(2);
            }
            return seller;
        }

        public Seller FindSellerById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
