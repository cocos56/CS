using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 电子商务
{
   public interface IOrderManager
    {
        void Save(OrderForm form);
        OrderForm FindOrderByCustomerName(string name);
        List<OrderLine> FindOrderline(OrderForm form);
        // ... ... 
        List<Goods> FindAllGoods();
    }
}
