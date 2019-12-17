using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using _4位随机数;

namespace 电子商务系统
{        
    class Program
    {
        public static Customer cm = null;
        
        static void Main(string[] args)
        {
            Welcome();
        }
        public static void Welcome()
        {
            Console.WriteLine("\t\t\t欢迎来到购物商城");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("1-->商家(卖家)电子商务系统  2-->顾客(买家)电子商务系统");
            string num = Console.ReadLine();
            Login(num);
        }
        public static void Login(string num)
        {
            #region
            if (num == "1")//商家(卖家)电子商务系统
            {
                while (true)
                {
                    Console.WriteLine("1-->新用户注册  2-->已注册用户登录  其他键退出");
                    string n = Console.ReadLine();
                    if (n == "1")
                    {
                        Seller s = new Seller();
                        Console.WriteLine("请输入用户名，20个字符以内");
                        s.Name = Console.ReadLine();
                        bool b = Seller.FindSellerByName(s.Name);
                        if (b)
                        {
                            Console.WriteLine("用户名已存在，请重新输入！");
                            s.Name = Console.ReadLine();
                            b = Seller.FindSellerByName(s.Name);
                        }
                        else
                        {
                            Console.WriteLine("用户名合法！");
                        }
                        Console.WriteLine("请输入密码，20个字符以内");
                        string s1 = Console.ReadLine();
                        Console.WriteLine("请再输入一次密码！");
                        string s2 = Console.ReadLine();
                        if (s1 != s2)
                        {
                            Console.WriteLine("两次密码不一致，请重新输入！");
                            s2 = Console.ReadLine();
                        }
                        else
                        {
                            s.Pwd = s2;
                        }
                        Console.WriteLine("请输入初始账户金额！");
                        s.Balance = Convert.ToDouble(Console.ReadLine());
                        bool b1 = Save(s);
                    }                    
                    else if(n=="2")
                    {
                        int count = 1;
                        while (count < 4)
                        {
                            Console.WriteLine("请输入用户名！");
                            Seller s = new Seller();
                            s.Name = Console.ReadLine();
                            bool b1 = Seller.FindSellerByName(s.Name);
                            Console.WriteLine("请输入密码！");
                            s.Pwd = Console.ReadLine();
                            bool b2 = Seller.FindSellerByPwd(s.Pwd);
                            
                            //string str =  _4位随机数.Program.Yzm();
                            Rnd rn = new Rnd();//创建随机数类(Rnd)的对象 
                            string pp = rn.Yzm();
                            Console.WriteLine("4位随机数验证码是{0}", pp);//调用Yzm()方法产生4位随机数
                            Console.WriteLine("请输入验证码！");
                            string ss = Console.ReadLine();
                            bool b3 = (ss == pp);
                            if(b3)
                            {
                                if (b1 == false || b2 == false)
                                {
                                    count++;
                                    if (count > 3)
                                    {
                                        Console.WriteLine("你登录次数最多为3次！");
                                    }
                                }
                                else
                                {

                                    Console.WriteLine("登陆成功！");
                                    Console.Clear();
                                    s.ShowInfo();
                                    break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("验证码输入错误！");
                            }                                                     
                        }                        
                    }
                    else
                    {
                        Console.Clear();//清屏
                        Welcome();
                        //break;
                    }
                }
            }
            #endregion
            else if(num=="2")
            {
                while (true)
                {
                    Console.WriteLine("1-->新用户注册  2-->已注册用户登录  其他键退出");
                    string n = Console.ReadLine();
                    if (n == "1")
                    {
                        Customer cm = new Customer();                        
                        Console.WriteLine("请输入用户名，20个字符以内");
                        cm.Name = Console.ReadLine();
                        bool b = Customer.FindCustomerByName(cm.Name);
                        if (b)
                        {
                            Console.WriteLine("用户名已存在，请重新输入！");
                            cm.Name = Console.ReadLine();
                            b = Customer.FindCustomerByName(cm.Name);
                        }
                        else
                        {
                            Console.WriteLine("用户名合法！");
                        }
                        Console.WriteLine("请输入密码，20个字符以内");
                        string s1 = Console.ReadLine();
                        Console.WriteLine("请再输入一次密码！");
                        string s2 = Console.ReadLine();
                        if (s1 != s2)
                        {
                            Console.WriteLine("两次密码不一致，请重新输入！");
                            s2 = Console.ReadLine();
                        }
                        else
                        {
                            cm.Pwd = s2;
                        }
                        Console.WriteLine("请输入初始账户金额！");
                        cm.Balance = Convert.ToDouble(Console.ReadLine());
                        bool b1 = Save(cm);
                    }
                    else if (n == "2")
                    {
                        int count = 1;
                        while (count < 4)
                        {
                            Console.WriteLine("请输入用户名！");
                            Customer cm = new Customer();
                            cm.Name = Console.ReadLine();
                            bool b1 = Customer.FindCustomerByName(cm.Name);
                            Console.WriteLine("请输入密码！");
                            cm.Pwd = Console.ReadLine();
                            bool b2 = Customer.FindCustomerByPwd(cm.Pwd);

                            //string str =  _4位随机数.Program.Yzm();//using _4位随机数;要加
                            Rnd rn = new Rnd();//创建随机数类(Rnd)的对象 //不加“using _4位随机数;”
                            string pp = rn.Yzm();
                            Console.WriteLine("4位随机数验证码是{0}", pp);//调用Yzm()方法产生4位随机数
                            Console.WriteLine("请输入验证码！");
                            string ss = Console.ReadLine();
                            bool b3 = (ss == pp);
                            if (b3)
                            {
                                if (b1 == false || b2 == false)
                                {
                                    count++;
                                    if (count > 3)
                                    {
                                        Console.WriteLine("你登录次数最多为3次！");
                                    }
                                }
                                else
                                {

                                    Console.WriteLine("登陆成功！");
                                    cm = new Customer();
                                    Console.WriteLine("以下是商品信息");
                                    ShowGoods();
                                    MysqlLink ml = new MysqlLink();
                                    ml.Connect();
                                    string sql = "select * from customer where name='cm.Name'";
                                    MySqlCommand comd = new MySqlCommand(sql, ml.Conn);//发送sql语句给数据库服务器
                                    MySqlDataReader reader = comd.ExecuteReader();//执行sql语句  MySqlDataReader类似于迭代器            
                                    while (reader.Read())//判断是否有下一个
                                    {
                                        Console.Write("c_id:" + reader.GetInt32(0));//拿到客户ID
                                        Console.Write("\tname:" + reader.GetString(1));//拿到客户名字
                                        Console.Write("\tpwd:" + reader.GetString(2));//拿到客户密码
                                        Console.Write("\tbalance:" + reader.GetDouble(3));//拿到客户余额
                                        Console.WriteLine();
                                    }
                                    Customer.GwcManager(cm);                                   
                                    break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("验证码输入错误！");
                            }
                        }
                    }
                    else
                    {
                        Console.Clear();
                        Welcome();
                        break;
                    }
                }
            }
        }       
        public static bool Save(object o)
        {
            bool b = false;
            MysqlLink ml = new MysqlLink();
            ml.Connect();
            string sql = "insert into seller(name,pwd,balance) values('{0}','{1}',{2})";
            if(o is Seller)
            {
                Seller s = (Seller)o;
                sql = string.Format(sql, s.Name, s.Pwd, s.Balance);//F12转到定义，Format函数有params object[] args（可变参数）
            }
            else if (o is Customer)
            {
                Customer c = (Customer)o;
                sql = string.Format(sql, c.Name, c.Pwd, c.Balance);//F12转到定义，Format函数有params object[] args（可变参数）
            }            
            Console.WriteLine(sql);
            MySqlCommand comd = new MySqlCommand(sql, ml.Conn);// 发送sql语句给数据库服务器
            int a = comd.ExecuteNonQuery();//执行sql语句
            if (a == 1)
            {
                return b = true;
            }
            ml.Conn.Close();//关闭资源
            return b;
        }              
        public static void ShowGoods()
        {
            MysqlLink ml = new MysqlLink();
            ml.Connect();
            string sql = "select * from goods";
            //Console.WriteLine(sql);//打印输出sql语句
            MySqlCommand comd = new MySqlCommand(sql, ml.Conn);//发送sql语句给数据库服务器
            MySqlDataReader reader = comd.ExecuteReader();//执行sql语句  MySqlDataReader类似于迭代器            
            while (reader.Read())//判断是否有下一个
            {
                Console.Write("g_id:" + reader.GetInt32(0));//拿到商品ID
                Console.Write("\tg_name:" + reader.GetString(1));//拿到商品名字
                Console.Write("\tg_price:" + reader.GetString(2));//拿到商品价格
                Console.Write("\tg_amount:" + reader.GetDouble(3));//拿到剩余商品数量
                Console.Write("\tg_sid:" + reader.GetDouble(4));//拿到供货商（卖家）
                Console.WriteLine();
            }
        }



    }
}
