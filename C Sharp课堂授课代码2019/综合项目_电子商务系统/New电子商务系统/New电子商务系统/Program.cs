using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New电子商务系统
{
    class Program
    {
        public static Seller s = null;
        public static Customer c = null;
        static void Main(string[] args)
        {
            Console.WriteLine("welcome~");
            while (true)
            {
                Console.WriteLine("请选择用户类型：1--商家  2--顾客  3--其他键退出");
                string choice = Console.ReadLine();
                if (choice=="1")
                {
                    Console.Clear();//清屏
                    Console.WriteLine("商家您好！欢迎使用本系统！");
                    while(true)
                    {
                        Console.WriteLine("请选择：1--注册  2--登录  3--其他键退出");
                        Seller s = new Seller();
                        string ch = Console.ReadLine();
                        if (ch=="1")//商家注册
                        {
                            AccountManagement.Open(s);
                        }
                        else if(ch=="2")//商家登录
                        {
                            bool b = Log.Login(s);
                            if (b)
                            {
                                Service.Ser(s);//去选择服务项目
                                break;
                            }
                            else
                            {
                               AccountManagement.Open(s);//注册新账号
                            }
                        }
                        else
                        {
                            break;
                        }
                    }                    
                }
                else if (choice == "2")
                {
                    Console.Clear();//清屏
                    Console.WriteLine("顾客您好！欢迎使用本系统！");
                    while (true)
                    {
                        Console.WriteLine("请选择：1--注册  2--登录  3--其他键退出");
                        Customer c = new Customer();
                        string ch = Console.ReadLine();
                        if (ch == "1")
                        {
                            AccountManagement.Open(c);
                        }
                        else if (ch == "2")
                        {                            
                            Console.WriteLine("请输入用户名！");
                            string name = Console.ReadLine();
                            c= AccountManagement.GetCustomer(name);
                            bool b = Log.Login(c);
                            if (b)//顾客登录成功
                            {
                                Service.Ser(c);//去选择服务项目
                                break;
                            }
                            else
                            {
                                AccountManagement.Open(c);//注册新账号
                            }
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                else
                {
                    break;
                }          
            }
        }
        
    }   
}
