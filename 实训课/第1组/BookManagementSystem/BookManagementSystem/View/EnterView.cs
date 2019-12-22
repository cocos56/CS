using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookManagementSystem.Controller;

namespace BookManagementSystem.View
{
    public class EnterView:BaseView
    {
        public void Enter()
        {
            Console.WriteLine("***************图书管理系统****************");
            Console.WriteLine("***************1.用户登录 ****************");
            Console.WriteLine("***************2.管理员登录 ****************");
            Console.WriteLine("***************3.注册用户****************");
            Console.WriteLine("***************4.修改用户密码****************");
            Console.WriteLine("***************5.修改用户名****************");
            Console.WriteLine("请选择操作：");
            string ret = Console.ReadLine();
            switch (ret)
            {
                case "1":
                    AccountController.Instance.Enter(Model.IdentifyType.User);
                    break;
                case "2":
                    AccountController.Instance.Enter(Model.IdentifyType.Manager);
                    break;
                case "3":
                    ManagerController.Instance.OpenAddUserView();
                    break;
                case "4":
                    ManagerController.Instance.OpenUpdatePassWordView();
                    break;
                case "5":
                    ManagerController.Instance.OpenUpdateUserNameView();
                    break;
                default:
                    break;
            }
        }

        public void Error(string error)
        {
            Console.WriteLine(error);
        }
    }
}
