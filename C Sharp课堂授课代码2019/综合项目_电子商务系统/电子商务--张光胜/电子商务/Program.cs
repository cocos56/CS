using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 电子商务
{
    class Program //view 
    {
        public static Service service = new Service();
        Customer customer = null;
       static Seller seller = null;
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("欢迎来到xx购物系统");
                Console.WriteLine("卖家界面按1，买家界面按2");
                string s1 = Console.ReadLine();
                if (s1 == "1")
                {
                    SellerLogin();
                }
                else
                {
                    Console.WriteLine("老用户请按1进行登录，新用户请按2进行注册");
                    string s = Console.ReadLine();
                    if (s == "1")
                    {
                        login();
                    }
                    else if (s == "2")
                    {
                        register();
                    }
                }
                // Console.WriteLine("下面是商品的展示，请放心选购");

            }
        }
        public static void login()
        {
            Console.WriteLine("请输入用户名和密码，用逗号分隔");
            string str = Console.ReadLine();
            string name = str.Split(',')[0];
            string psw = str.Split(',')[1];
            bool b = service.Login(name, psw);
            if (b)
            {
                ShowShops();
            }
            else {
                login();
            }
        }
        public static void register()
        {
            Console.WriteLine("请输入您的用户名，密码，地址，电话进行注册");
            string str = Console.ReadLine();
            string name = str.Split(',')[0];
            string psw = str.Split(',')[1];
            string address = str.Split(',')[2];
            string telphone = str.Split(',')[3];
            Customer c = new Customer();
            c.name = name;
            c.address = address;
            c.telphone = telphone;
            c.psw = psw;
            bool b = service.register(c);
            if (b)
            {
                login();
            }
            else
            {
                return;
            }

        }
        public static void ShowShops()
        {
            Console.WriteLine("下面是上面的展示：");
            List<Goods> list = service.FindyAllGoods();
            foreach (Goods g in list)
            {
                Console.WriteLine(g);
            }
            Console.WriteLine("请输入你需要的商品编号以及数量添加到购物车");
            string ss = Console.ReadLine();
            //service.AddLineToCart();
            
        }

        public static void SellerLogin()
        {
            
           
                Console.WriteLine("请输入登录的用户名和密码");
                string str = Console.ReadLine();
                string name = str.Split(',')[0];
                string psw = str.Split(',')[1];
                seller = service.SellerLogin(name, psw);
                if (seller!=null)
                {
                    Console.WriteLine("登录成功");
                    while (true)
                    {
                        Console.WriteLine("请选择：1添加商品，2修改商品，3删除商品，4查看商品,其他键退出");
                        string s1 = Console.ReadLine();
                        if (s1 == "1") {
                            AddGood();
                        }else if(s1=="2"){
                        }
                        else if (s1 == "3")
                        {
                        }
                        else if (s1 == "4")
                        {
                            ShowOwnGoods();
                        }
                        else
                        {
                            return;
                        }
                    }
                }
            
        }
        public static void AddGood()
        {
            Console.WriteLine("请输入添加商品信息，名字，价格");
            string str = Console.ReadLine();
            string name = str.Split(',')[0];
            double price =Convert.ToDouble( str.Split(',')[1]);
            Goods g = new Goods();
            g.name = name;
            g.price = price;
   
            service.AddGood(g,seller.id);
        }
        public static void ShowOwnGoods()
        {
          List<Goods> list =  service.FindGoodsBySellerId(seller.id);
          foreach (Goods g in list)
          {
              Console.WriteLine(g+"所属卖家："+seller.name);
          }
        }

    }
}
