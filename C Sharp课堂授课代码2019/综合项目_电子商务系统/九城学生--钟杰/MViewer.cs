using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Text.RegularExpressions;

namespace mostone
{
    public class MViewer
    {
        public static string ReadPassword()
        {
            string pass = "";

            while (true)
            {
                char cur = Console.ReadKey().KeyChar;
                
                if (cur == 13)
                {
                    break;
                }

                if ('\b' == cur)
                {
                    Console.Write("\0");
                    Console.Write("\b");
                    pass = pass.Substring(0, pass.Length - 1);
                }
                else
                {
                    Console.Write("\b");
                    Console.Write("*");
                    pass += cur;
                }
            }
            Console.WriteLine();

            return pass;
        }

        public static Goods InputGoodsMess(Goods good)
        {
            string name;
            string price;
            string nums;
            string isSale;

            Console.Write("输入名称\n>>");
            name = Console.ReadLine();
            while (true)
            {
                Console.Write("输入单价\n>>");
                price = Console.ReadLine();
                if (!StringRegular.RegularChecker(price, StringRegular.ISFLOAT))
                {
                    Console.WriteLine("输入有误");
                    continue;
                }
                break;
            }
            while (true)
            {
                Console.Write("输入库存\n>>");
                nums = Console.ReadLine();
                if (!StringRegular.RegularChecker(nums, StringRegular.ALLNUM))
                {
                    Console.WriteLine("输入有误");
                    continue;
                }
                break;
            }
            while (true)
            {
                Console.Write("输入是否上架\n>>");
                isSale = Console.ReadLine();
                if (!StringRegular.RegularChecker(isSale, StringRegular.ISBOOL))
                {
                    Console.WriteLine("输入有误");
                    continue;
                }
                break;
            }

            good.Name = name;
            good.Price = double.Parse(price);
            good.Nums = int.Parse(nums);
            good.IsSale = isSale=="y" || isSale=="Y" ? true : false;

            return good;
        }

        public static int ChoiceGuide(string guider, int startEdge, int endEdge)
        {
            Console.WriteLine(guider);
            Console.Write(">>");

            int key = Console.ReadKey().KeyChar - 48;

            while (key < startEdge || key > endEdge)
            {
                Console.WriteLine("输入不合法");
                Console.Write(">>");
                key = Console.ReadKey().KeyChar - 48;
            }
            Console.WriteLine();
            Console.WriteLine();
            return key;
        }

        public static void DisplayTitle(string type)
        {
            Console.WriteLine("--------------------------------------------");
            switch (type)
            {
                case "Goods":
                    Console.WriteLine("|商品编号|商品名\t|单价\t|库存\n|所属卖家|上架与否");
                    break;
                case "NumGoods":
                    Console.WriteLine("|序号\t|商品编号|商品名\t|单价\t|库存\n|所属卖家|上架与否");
                    break;
                case "PurchaseMess":
                    Console.WriteLine("商品编号|商品名\t|单价\t|数量\n|买家编号|卖家编号|订单编号|是否发货");
                    break;
                case "NumPurcahseMess":
                    Console.WriteLine("序号\t|商品编号|商品名\t|单价\t|数量\n|买家编号|卖家编号|订单编号|是否发货");
                    break;
            }
        }

        public static void DisplayTrolley()
        {
            DisplayTitle("NumGoods");
            if (0 == Mostone.trolley.Count)
            {
            }
            else
            {
                foreach (KeyValuePair<int, Goods> kv in Mostone.trolley)
                {
                    Console.WriteLine("--------------------------------------------");
                    Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\n{5}\t{6}"
                                            , kv.Key, kv.Value.Id, kv.Value.Name
                                            , kv.Value.Price, kv.Value.Nums
                                            , kv.Value.S_id, kv.Value.IsSale);
                }
            }
            Console.WriteLine("--------------------------------------------");
        }

        public static void TrolleyHandleView()
        {
            int choice;
            string input;

            while (true)
            {
                choice = ChoiceGuide("1、查看购物车 2、删除商品 3、提交订单 4、返回", 1, 4);
                switch (choice)
                {
                    case 1:
                        DisplayTrolley();
                        break;
                    case 2:
                        while (true)
                        {
                            Console.Write("输入要删除的商品序号\n>>");
                            input = Console.ReadLine();
                            if (!StringRegular.RegularChecker(input, StringRegular.ALLNUM)
                                || !Mostone.trolley.ContainsKey(int.Parse(input)))
                            {
                                Console.WriteLine("输入有误");
                                continue;
                            }

                            Mostone.trolley.Remove(int.Parse(input));
                            break;
                        }
                        break;
                    case 3:
                        int oid;
                        bool flag = true;
                        OrderList order = new OrderList(DateTime.Now);
                        List<PurchaseMess> purMess = new List<PurchaseMess>();
                        
                        foreach (Goods good in Mostone.trolley.Values)
                        {
                            order.Summary += good.Price * good.Nums;
                            purMess.Add(MController.GeneratePurchase(good));

                            if (good.Nums > MySQLDemo.FindGoodsById(good.Id).Nums)
                            {
                                flag = false;
                                Console.WriteLine("{0}的商品{1}库存不足", good.S_id, good.Id);
                            }
                        }

                        if (Mostone.user.Saves < order.Summary)
                        {
                            Console.WriteLine("余额不足，请充值");
                            break;
                        }

                        if (!flag)
                        {
                            break;
                        }

                        Mostone.user.Saves -= order.Summary;

                        MySQLDemo.UpdateUser(Mostone.user);
                        MySQLDemo.InsertOrderList(order, out oid);

                        foreach (PurchaseMess pm in purMess)
                        {
                            pm.O_id = oid;
                            MySQLDemo.InsertPurchaseMess(pm);
                            Goods good = MySQLDemo.FindGoodsById(pm.G_id);
                            good.Nums -= pm.Nums;
                            MySQLDemo.UpdateGoods(good);
                        }
                        Mostone.trolley.Clear();
                        break;
                    case 4:
                        return;
                }
            }
        }

        public static void DisplayList(List<PurchaseMess> lps)
        {
            DisplayTitle("PurchaseMess");
            if (null == lps)
            {
            }
            else
            {
                foreach (PurchaseMess g in lps)
                {
                    Console.WriteLine("--------------------------------------------");
                    Console.WriteLine(g);
                }
            }
            Console.WriteLine("--------------------------------------------");
        }

        public static void DisplayList(List<Goods> lgs)
        {
            DisplayTitle("Goods");
            if (null == lgs)
            {
            }
            else
            {
                foreach (Goods g in lgs)
                {
                    Console.WriteLine("--------------------------------------------");
                    Console.WriteLine(g);
                }
            }
            Console.WriteLine("--------------------------------------------");
        }

        public static void DisplayNumList(List<PurchaseMess> lps)
        {
            int num = 0;
            DisplayTitle("NumPurchaseMess");
            if (null == lps)
            {
                
            }
            foreach (PurchaseMess g in lps)
            {
                num++;
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\n{5}\t{6}\t{7}"
                                        , num, g.G_id, g.G_name, g.Price, g.Nums
                                        , g.Bu_id, g.Su_id, g.O_id);
            }
        }


        public static void SignIn()
        {
            string username;
            string password;
            User curUser;
            bool isBuyer = (1 == ChoiceGuide("1、买家登录 2、卖家登录", 1, 2)?true:false);

            Console.Write("输入用户名\n>>");
            username = Console.ReadLine();
            Console.Write("输入密码\n>>");
            password = ReadPassword();

            curUser = MController.CheckUser(username, password, isBuyer);
            if (null == curUser) {
                Console.WriteLine("无此用户或密码错误");
                SignIn();
                return;
            }

            Mostone.user = curUser;
        }

        public static void SignUp()
        {
            string username;
            string password;
            string passAgain;
            int idenKey;
            bool isBuyer;
            int autoId;

            Console.Write("请输入用户名\n>>");
            username = Console.ReadLine();
            Console.Write("请输入密码\n>>");
            password = ReadPassword();
            Console.Write("再输入一次密码\n>>");
            passAgain = ReadPassword();
            idenKey = ChoiceGuide("1、买家 2、卖家", 1, 2);
            isBuyer = (1 == idenKey ? true : false);

            Console.WriteLine();

            if (!passAgain.Equals(password))
            {
                Console.WriteLine("两次密码不一致");
                SignUp();
                return;
            }
            if (!StringRegular.RegularChecker(password, StringRegular.PASSWORD))
            {
                Console.WriteLine("密码格式不正确");
                SignUp();
                return;
            }
            if (MController.UsernameVerify(username, isBuyer))
            {
                Console.WriteLine("用户名已存在");
                SignUp();
                return;
            }

            MySQLDemo.InsertUser(username, password, isBuyer, out autoId);
            Mostone.user = MySQLDemo.FindUserById(autoId, isBuyer);
        }

        public static void BuyerView()
        {
            int choice;
            int temp = 0;
            int key;
            string input;
            Goods good;

            Console.WriteLine("欢迎顾客{0}", Mostone.user.Name);
            while (true)
            {
                choice = ChoiceGuide("1、浏览商品 2、购买商品 3、管理购物车 4、充值 5、查看余额 6、购买记录 7、退出", 1, 7);
                switch (choice)
                {
                    case 1: 
                        DisplayList(MySQLDemo.FindAllGoods()); 
                        break;
                    case 2:
                        good = null;

                        while (true)
                        {
                            Console.Write("输入欲购买商品编号\n>>");
                            input = Console.ReadLine();
                            if (!StringRegular.RegularChecker(input, StringRegular.ALLNUM))
                            {
                                continue;
                            }
                            good = MySQLDemo.FindGoodsById(int.Parse(input));
                            if (null == good)
                            {
                                continue;
                            }
                            break;
                        }
                        while (true)
                        {
                            Console.Write("输入购买数量\n>>");
                            input = Console.ReadLine();
                            if (!StringRegular.RegularChecker(input, StringRegular.ALLNUM))
                            {
                                continue;
                            }
                            if (int.Parse(input) < 0 || int.Parse(input) > good.Nums)
                            {
                                continue;
                            }
                            break;
                        }
                        key = MController.IsContain(good);
                        if (key != -1)
                        {
                            temp = MController.GetTrolleyGoodsNums(good);
                            Mostone.trolley.Remove(key);
                        }
                        good.Nums = int.Parse(input) + temp;
                        Mostone.trolley.Add(Mostone.trolley.Count, good);
                        break;
                    case 3:
                        TrolleyHandleView();
                        break;
                    case 4:
                        Console.Write("输入要充值的金额\n>>");
                        while (true)
                        {
                            input = Console.ReadLine();
                            if (!StringRegular.RegularChecker(input, StringRegular.ALLNUM)
                                 || !StringRegular.RegularChecker(input, StringRegular.ISFLOAT))
                            {
                                Console.WriteLine("输入有误");
                                continue;
                            }

                            Mostone.user.Saves += double.Parse(input);
                            MySQLDemo.UpdateUser(Mostone.user);
                            break;
                        }
                        break;
                    case 5:
                        Console.WriteLine("余额为:{0}", Mostone.user.Saves);
                        break;
                    case 6:
                        DisplayList(MySQLDemo.FindPurMessByBuyer((Buyer)Mostone.user));
                        break;
                    case 7:
                        Mostone.user = null;
                        return;
                }
            }
        }

        public static void OrderHandleView(PurchaseMess pmess)
        {
            int choice;

            choice = ChoiceGuide("1、发货 2、返回", 1, 2);

            switch (choice)
            {
                case 1:
                    Seller seller = (Seller)Mostone.user;
                    seller.Saves += pmess.Nums * pmess.Price;
                    MySQLDemo.UpdateUser(seller);
                    pmess.PurState = "1";
                    MySQLDemo.UpdatePurMess(pmess);
                    break;
                case 2:
                    return;
            }
        }

        public static void OrderView()
        {
            int choice;
            int temp;
            string input;
            bool flag = false;
            PurchaseMess pmess = null;
            List<PurchaseMess> lp;

            lp = MySQLDemo.FindPurMessBySellerAndState((Seller)Mostone.user, "0");

            while (true)
            {
                choice = ChoiceGuide("1、显示购买信息 2、查找购买信息 3、返回", 1, 3);
                switch (choice)
                {
                    case 1:
                        DisplayList(lp);
                        break;
                    case 2:
                        while (true)
                        {
                            Console.Write("输入商品编号\n>>");
                            input = Console.ReadLine();
                            if (!StringRegular.RegularChecker(input, StringRegular.ALLNUM))
                            {
                                Console.WriteLine("输入有误");
                                continue;
                            }
                            foreach (PurchaseMess p in lp)
                            {
                                if (int.Parse(input) == p.G_id)
                                {
                                    flag = true;
                                }
                            }
                            if (!flag)
                            {
                                Console.WriteLine("无此在售商品编号");
                                continue;
                            }
                            temp = int.Parse(input);
                            break;
                        }
                        while (true)
                        {
                            Console.Write("输入指定信息的订单编号\n>>");
                            input = Console.ReadLine();
                            pmess = null;

                            if (!StringRegular.RegularChecker(input, StringRegular.ALLNUM))
                            {
                                Console.WriteLine("输入有误");
                                continue;
                            }
                            foreach (PurchaseMess p in lp)
                            {
                                if (temp == p.G_id && int.Parse(input) == p.O_id)
                                {
                                    pmess = p;
                                }
                            }

                            if (null == pmess)
                            {
                                Console.WriteLine("输入有误");
                                continue;
                            }
                            break;
                        }
                        OrderHandleView(pmess);
                        lp = MySQLDemo.FindPurMessBySellerAndState((Seller)Mostone.user, "0");
                        break;
                    case 3:
                        return;
                }
            }
        }

        public static void SellerView()
        {
            int choice;
            string input;
            Goods good;
            List<Goods> lgs = null;

            Console.WriteLine("欢迎店长{0}", Mostone.user.Name);
            while (true)
            {
                choice = ChoiceGuide("1、查看自属商品 2、查看所有商品 3、新增商品 4、修改商品信息 5、订单消息 6、查看账户 7、退出", 1, 7);

                switch (choice)
                {
                    case 1:
                        lgs = MySQLDemo.FindGoodsByOwner(Mostone.user);
                        if (null != lgs)
                        {
                            foreach (Goods gd in lgs)
                            {
                                if (0 == gd.Nums)
                                {
                                    gd.IsSale = false;
                                    MySQLDemo.UpdateGoods(gd);
                                }
                            }
                        }
                        DisplayList(lgs);
                        break;
                    case 2:
                        DisplayList(MySQLDemo.FindAllGoods());
                        break;
                    case 3:
                        good = InputGoodsMess(new Goods(Mostone.user.Id));
                        MySQLDemo.InserGoods(good);
                        break;
                    case 4:
                        while (true)
                        {
                            Console.Write("输入欲操作商品编号\n>>");
                            input = Console.ReadLine();
                            if (!StringRegular.RegularChecker(input, StringRegular.ALLNUM))
                            {
                                Console.WriteLine("输入有误");
                                continue;
                            }
                            good = MySQLDemo.FindGoodsById(int.Parse(input));
                            if (null == good)
                            {
                                Console.WriteLine("输入有误");
                                continue;
                            }
                            break;
                        }
                        good = InputGoodsMess(good);
                        MySQLDemo.UpdateGoods(good);
                        break;
                    case 5:
                        OrderView();
                        break;
                    case 6:
                        Console.WriteLine("余额为:{0}", Mostone.user.Saves);
                        break;
                    case 7:
                        Mostone.user = null;
                        return;
                }
            }
        }

        public static void MainView()
        {
            Console.WriteLine("欢迎");

            while(null == Mostone.user){
                int choice = ChoiceGuide("1、登录 2、注册", 1, 2);

                switch (choice)
                {
                    case 1: SignIn(); break;
                    case 2: SignUp(); break;
                }
                if (Mostone.user is Buyer)
                {
                    Mostone.trolley = new Dictionary<int, Goods>();
                    BuyerView();
                }
                else
                {
                    SellerView();
                }
            }
        }
    }
}
