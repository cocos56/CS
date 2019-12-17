using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New电子商务系统
{
    public class Log
    {
        public static bool Login(object o)
        {
            bool b = false;
            bool b1 = false;
            bool b2 = false;
            Rnd rn = new Rnd();//创建随机数类(Rnd)的对象 
            string pp = rn.Yzm();
            Console.WriteLine("4位随机数验证码是{0}", pp);//调用Yzm()方法产生4位随机数
            Console.WriteLine("请输入验证码！");
            string ss = Console.ReadLine();
            bool b3 = (ss == pp);
            int count = 0;
            while (count < 4)
            {
                if (!b3)
                {
                    Console.WriteLine("你输入的验证码有误，请重新输入！");
                    ss = Console.ReadLine();
                    b3 = (ss == pp);
                }
                else
                {
                    Console.WriteLine("验证码输入正确！");
                    if (o is Seller)
                    {
                        Seller s = (Seller)o;
                        InputSellerInfo(s, out b1, out b2);
                    }
                    else if (o is Customer)
                    {
                        Customer c = (Customer)o;
                        InputCustomerInfo(c, out b1, out b2);
                    }
                    while (b1 == false || b2 == false)
                    {
                        count++;
                        if (count > 3)
                        {
                            Console.WriteLine("你登录次数最多为3次！");
                            return b = false;
                        }
                        Console.WriteLine("你输入的用户名和密码有误，请重新输入！");
                        if (o is Seller)
                        {
                            Seller s = (Seller)o;
                            InputSellerInfo(s, out b1, out b2);
                        }
                        else if (o is Customer)
                        {
                            Customer c = (Customer)o;
                            InputCustomerInfo(c, out b1, out b2);
                        }
                    }
                    Console.WriteLine("登陆成功！");
                    Console.Clear();
                    return b = true;
                }
            }
            return b;
        }
        public static void InputSellerInfo(Seller s, out bool b1, out bool b2)
        {
            Console.WriteLine("请再次输入用户名！");
            s.Name = Console.ReadLine();
            b1 = AccountManagement.FindAccountByName(s, s.Name);
            Console.WriteLine("请输入密码！");
            s.Pwd = Console.ReadLine();
            b2 = AccountManagement.FindAccountById(s, s.Pwd);
        }
        public static void InputCustomerInfo(Customer c, out bool b1, out bool b2)
        {
            Console.WriteLine("请再次输入用户名！");
            c.Name = Console.ReadLine();
            b1 = AccountManagement.FindAccountByName(c, c.Name);
            Console.WriteLine("请输入密码！");
            c.Pwd = Console.ReadLine();
            b2 = AccountManagement.FindAccountById(c, c.Pwd);
        }

    }
}
                                   