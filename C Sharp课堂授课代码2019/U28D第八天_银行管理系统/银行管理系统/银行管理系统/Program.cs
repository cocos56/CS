using System;

namespace 银行管理系统
{
    //全部与用户打交道的地方放在一个类里面，又叫用户接口，本页中的代码可称为“用户接口”
   
    //本例中用到了后一天中学习的异常，service()方法中代码“ a.withdraw(Convert.ToDouble(ss[1]));”可能抛出异常
    //添加异常的快捷方法：try按2次tab键   或者选中可能出现异常的代码上鼠标右键-->插入代码段-->Visual C#-->try
    //本例需要自定义一个异常类，继承子Exception类，Exception类有两个重要属性：Message-----错误信息,StackTrace-----描述异常发生位置信息

    class Program
    {
        public static Bank bank = new Bank();
        public static Customer c = null;
        static void Main(string[] args)
        {
            Console.WriteLine("欢迎来到本地银行！");
            while (true)
            {
                 bool b = login();
                 if (b)
                {
                    service();//去选择服务项目
                 }
                else
                {
                    open();//创建新账号
                }
            }
        }
        public static bool login()//判断账户是否登录（存在）
        {
            Console.WriteLine("请输入用户名：");
            string name = Console.ReadLine();
            c = bank.GetCustomerByName(name);//当前办理服务的客户
            if(c!=null)
            {
                Console.WriteLine("登陆成功");
                return true;
            }
            else
            {
                Console.WriteLine("该用户不存在，请开户");
                c = new Customer(name);
                bank.AddCustomer(c);//将用户添加到银行里面
                return false;
            }
        }
        public static void open()
        {
            
            Console.WriteLine("请输入开户的类型，1 储蓄卡 2 信用卡");
            string s = Console.ReadLine();
            if (s=="1")
            {
                Account a = new SavingAccount(1000, 0.3);//余额1000  balance余额
                c.addAccount(a);
                service();
            }
            else if(s=="2")
            {               
                Account a = new CheckingAccount(1000);
                c.addAccount(a);
                service();
            }
        }
        public static void service()
        {
            while (true)
            {
                Console.WriteLine("请选择你的操作， 1取钱，2存钱，3转账，4查看用户信息,其他键退出");
            string s = Console.ReadLine();
            if (s=="1")
            {
                Console.WriteLine("请输入取钱的账号及金额，逗号分隔");
                string str = Console.ReadLine();
                string[] ss = str.Split(',');
                Account a = c.GetAccount(Convert.ToInt32(ss[0]));
                try
                {
                    a.withdraw(Convert.ToDouble(ss[1]));
                    Console.WriteLine("取钱成功！"); 
                }
                //catch (Exception e)//这样写捕获的异常范围更广  这样写程序运行也正确
                catch (BankException e)
                {
                    Console.WriteLine("取钱失败," + e.Message);
                }
                           
            }
            else if (s=="2")
            {
                Console.WriteLine("请输入存钱的账号及金额，逗号分隔");
                string str = Console.ReadLine();
                string[] ss = str.Split(',');
                Account a = c.GetAccount(Convert.ToInt32(ss[0]));
                a.deposit(Convert.ToDouble(ss[1]));//存钱:deposit
                Console.WriteLine("存钱成功!");               
            }
            else if (s=="3")
            {
                //转账--转账源账号 金额--->转账目的账号
                Console.WriteLine("请输入转账源账号及金额，逗号分隔");
                string str = Console.ReadLine();
                string[] ss = str.Split(',');
                Account a = c.GetAccount(Convert.ToInt32(ss[0]));
                a.withdraw(Convert.ToDouble(ss[1]));
                
                //转账后              
                Console.WriteLine("请输入转账目的账号");
                string str1 = Console.ReadLine();                
                //获得另一个人（转账目的）的客户
                Customer c2 = bank.GetCustomer(Convert.ToInt32(str1));
                Account b = c2.GetAccount(Convert.ToInt32(str1));//得到（转账目的人）客户账户
                b.deposit(Convert.ToDouble(ss[1]));
            }
            else if (s=="4")
            {
                Console.WriteLine("下面是您的所有账户的信息");
                foreach (Account a in c.list)
                {
                    //要自定义输出（打印）账户信息，需要在Account类中重写
                    //“public override string ToString()”方法
                    Console.WriteLine(a);
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
