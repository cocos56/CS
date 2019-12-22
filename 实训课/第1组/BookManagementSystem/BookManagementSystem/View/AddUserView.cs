using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookManagementSystem.Controller;
using BookManagementSystem.Frameworrk;
using BookManagementSystem.Model;

namespace BookManagementSystem.View
{
    public class AddUserView:BaseView
    {
       public void AddUser()
        {
            Console.WriteLine("***************添加用户界面*****************");
            string username = Utils.Input("请输入用户名");
            string password = Utils.Input("请输入密码");
            string repeatPassword = Utils.Input("请再次输入密码");
            UserController.Instance.AddUser(username, password, repeatPassword);
        }

    }
}
