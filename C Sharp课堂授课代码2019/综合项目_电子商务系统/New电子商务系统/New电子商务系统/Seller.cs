using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace New电子商务系统
{
    public class Seller
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Pwd { get; set; }
        public double Balance { get; set; }
        public Seller(string name, string pwd, double balance)
        {
            this.Name = name;
            this.Pwd = pwd;
            this.Balance = balance;
        }
        public Seller()
        {

        }       
    }
}

