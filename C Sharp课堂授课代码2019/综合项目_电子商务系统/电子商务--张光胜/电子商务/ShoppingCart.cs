using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 电子商务
{
   public class ShoppingCart
    {
       
        public Dictionary<int, OrderLine> cart = new Dictionary<int, OrderLine>();
        //以商品编号作为键 以小订单作为值
        public void AddCart(OrderLine line)
        {
            if (cart.ContainsKey(line.good.id))//判断是否已经购买过
            {
                cart[line.good.id].num += line.num;
            }
            else
            {
                cart.Add(line.good.id, line);
            }           
        }
        public void ClearCart()
        {
            cart.Clear();
        }
        public void RemoveLine(int id)
        {
            cart.Remove(id);
        }
        public void Modify(int id ,int num)
        {
            OrderLine line = cart[id];
            line.num = num;
        }
        public List<OrderLine> GetAllOrderLine() {
            List<OrderLine> list = new List<OrderLine>();

            foreach (OrderLine line in cart.Values)
            {
                list.Add(line);
            }
            return list;
        }
    }
}
