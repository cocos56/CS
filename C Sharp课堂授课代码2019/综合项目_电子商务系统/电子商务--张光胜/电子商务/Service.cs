using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 电子商务
{
  public  class Service  //control
    {
        CustomerManager manager = new CustomerManager();
        GoodManager gm = new GoodManager();
        ShoppingCart cart = new ShoppingCart();
        OrderManager om = new OrderManager();
        public bool Login(string name,string psw)
        {
            Customer c = manager.FindCustomerByName(name);
            if (c != null)
            {
                if (psw == c.psw)
                {
                    return true;
                }
                else
                {
                    Console.WriteLine("密码错误");
                    return false;
                }
            }
            else
            {
                return false;
            }
            
        }
        public bool register(Customer c)
        {
            Customer c2 = manager.FindCustomerByName(c.name);
            if (c2 != null)
            {
                Console.WriteLine("用户名已存在，请重新输入");
                return false;
            }
            else
            {
                manager.SaveCustomer(c);
                return true;
            }
        }

        public void AddLineToCart(int id,int num)//商品的id，商品的数量
        {
            OrderLine line = new OrderLine();
            line.good = gm.FindGoodById(id);
            line.num = num;
            cart.AddCart(line);
        }
        public void ConfirmForm(Customer c)
        {
            OrderForm form = new OrderForm();
            form.o_date = new DateTime().ToLongDateString();
            form.customer = c;
            double d = 0;
            foreach (OrderLine line in cart.GetAllOrderLine())
            {
               d+= line.num*(line.good.price);
            }
            form.s_money = d;
            form.lines = cart.GetAllOrderLine();
            om.Save(form);
        }
        public Seller SellerLogin(string name,string psw)
        {
            Seller seller = manager.FindSellerByName(name);
            if (seller != null)
            {
                if (psw == seller.psw)
                {
                    return seller;
                }
                else
                {
                    Console.WriteLine("密码错误");
                    return null;
                }
            }
            else
            {
                return null;
            }

        }

        public void AddGood(Goods g,int s_id)
        {
            Goods g2 = gm.FindGoodByName(g.name);
            if (g2 != null)
            {
                Console.WriteLine("商品已经存在");
            }
            else
            {
                gm.AddGood(g, s_id);
            }
            
        }
        public List<Goods> FindGoodsBySellerId(int id)//通过用户id，查找自己的所有商品
        {
           return  gm.FindGoodsBySellerId(id);
        }
        public List<Goods> FindyAllGoods()
        {
            return gm.FindAllGoods();
        }
    }
}
