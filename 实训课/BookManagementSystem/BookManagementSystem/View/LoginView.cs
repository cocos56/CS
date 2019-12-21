using BookManagementSystem.Controller;
using BookManagementSystem.Frameworrk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagementSystem.View
{
    public class LoginView:BaseView
    {
        public void Login()
        {
            Console.WriteLine("******************* 登录界面****************** ");
            string username = Utils.Input("请输入账户");
            string password = Utils.Input("请输入密码");

            AccountController.Instance.Login(username, password);
           

        }

       
    }
}
