using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace 电子商务
{
   public class OrderManager:IOrderManager
    {
        public void Save(OrderForm form)
        {
            //先插入大订单的，得到id 然后在对小订单表进行插入操作
           //1.
            int c_id = form.customer.id;
            double s_money = form.s_money;
            string o_date = form.o_date;
            MySqlConnection conn = GetConnection.getConnection();
            string sql = string.Format("insert into orderform(c_id,s_money,o_date) values({0},{1},{2}) ;select @@identity;",c_id,s_money,o_date);
            MySqlCommand cmd = new MySqlCommand(sql,conn);            
            object o = cmd.ExecuteScalar();//拿到当前插入的id           
            Console.WriteLine(o+"--------");
            List<OrderLine> list = form.lines;

        }

        public OrderForm FindOrderByCustomerName(string name)
        {
            throw new NotImplementedException();
        }

        public List<OrderLine> FindOrderline(OrderForm form)
        {
            throw new NotImplementedException();
        }


        public List<Goods> FindAllGoods()
        {
            throw new NotImplementedException();
        }
    }
}
