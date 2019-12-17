using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New电子商务系统
{
    public class Service
    {
        public static void Ser(object o)
        {                    
                if (o is Seller)
                {
                    
                    Console.WriteLine("卖家，您好！很高兴为您服务！"); 
                    while(true)
                    {
                        Seller s = (Seller)o;
                        //卖家服务选项
                        Console.WriteLine("请选择服务的内容：1--个人信息管理  2--商品信息管理  3--订单管理  4--退出");
                        string choice = Console.ReadLine();
                        if (choice == "4")
                        {
                            break;
                        }
                        SerSeller(s,choice);
                    }
                }
                else if(o is Customer)
                {
                    Console.WriteLine("顾客，您好！很高兴为您服务！");  
                    while(true)
                    {
                        Customer c = (Customer)o;
                        Console.WriteLine("请选择服务的内容：1--个人信息管理  2--购物车管理  3--订单结算 4--退出");
                        string choice = Console.ReadLine();
                        if (choice=="4")
                        {
                            break;
                        }
                        SerCustomer(c, choice);
                    }                   
                }                                                  
        }
        public static void SerCustomer(Customer c,string choice)
        {            
            while(true)
            {
                if (choice == "1")//个人信息管理
                {
                    while (true)
                    {
                        Console.WriteLine("请选择：1--修改用户名  2--修改密码 3--退出");
                        string ss = Console.ReadLine();
                        if (ss == "1")
                        {
                            Console.WriteLine("请输入修改后的用户名");
                            string name = Console.ReadLine();
                            if (AccountManagement.UpdateAccountByName(c, name))
                            {
                                Console.WriteLine("用户名修改成功！");
                            }
                            else
                            {
                                Console.WriteLine("用户名修改失败！");
                            }

                        }
                        else if (ss == "2")
                        {
                            Console.WriteLine("请输入修改后的密码");
                            string pwd = Console.ReadLine();
                            if (AccountManagement.UpdateAccountByPwd(c, pwd))
                            {
                                Console.WriteLine("密码修改成功！");
                            }
                            else
                            {
                                Console.WriteLine("密码修改失败！");
                            }
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                else if (choice == "2")//购物车管理
                {
                    Shopping.ShowAllGoods();
                    while (true)
                    {
                        Console.WriteLine("请选择：1--添加购物信息  2--删除购物信息 3--更改购物信息 4--查看购物信息 5--退出");
                        string ss = Console.ReadLine();
                        if (ss == "1")
                        {
                            Console.WriteLine("请输入购买商品的名字和数量，以分号隔开");
                            string s1 = Console.ReadLine();
                            string[] p = s1.Split(',');
                            string shoppingName = p[0];//得到商品的名字
                            int nums = Convert.ToInt32(p[1]);//得到商品的数量                         
                            if (Shopping.AddShoppingByName(c, shoppingName,nums))
                            {
                                Console.WriteLine("商品添加成功！");
                            }
                            else
                            {
                                Console.WriteLine("商品添加失败！");
                            }

                        }
                        else if (ss == "2")
                        {
                            Console.WriteLine("请输入删除的商品");
                            string name = Console.ReadLine();
                            if (Shopping.DelShoppingByName(c, name))
                            {
                                Console.WriteLine("商品删除成功！");
                            }
                            else
                            {
                                Console.WriteLine("商品删除失败！");
                            }
                        }
                        else if (ss == "3")
                        {
                            Console.WriteLine("请输入更改的商品的名字和数量，以分号隔开");
                            string s1 = Console.ReadLine();
                            string[] p = s1.Split(',');
                            string name = p[0];//得到商品的名字
                            int nums = Convert.ToInt32(p[1]);//得到商品的数量
                            if (Shopping.UpdateShoppingByName(c, name, nums))
                            {
                                Console.WriteLine("商品信息更新成功！");
                            }
                            else
                            {
                                Console.WriteLine("商品信息更新失败！");
                            }
                        }
                        else if (ss == "4")
                        {
                            Console.WriteLine("请输入查询的商品名称");
                            string name = Console.ReadLine();
                            if (Shopping.SelecteShoppingByName(c, name))
                            {
                                Console.WriteLine("商品查询成功！");
                            }
                            else
                            {
                                Console.WriteLine("商品查询失败！");
                            }
                        }
                        else if (ss == "5")
                        {
                            break;
                        }
                    }
                }
                else if (choice == "3")
                {
                    //订单计算
                }
                //else
                //{
                //    break;
                //}
            }
        }
        public static void SerSeller(Seller s,string choice)
        {

        }
    }
}