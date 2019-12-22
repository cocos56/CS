using BookManagementSystem.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagementSystem.View
{
    public class ManagerMainView:BaseView
    {
        public void ManagerMain()
        {
            Console.WriteLine("********管理员主页面********");
            Console.WriteLine("********1.管理图书  ********");
            Console.WriteLine("********2.管理用户  ********");
            Console.WriteLine("********3.退出系统  ********");

            string ret = Utils.Input("请选择您的操作");
            switch (ret)
            {
                case "1":
                    ManagerController.Instance.OpenManageBookView();
                    break;
                case "2":
                    ManagerController.Instance.OpenManageUserView();
                    break;
                case "3":
                    ManagerController.Instance.BackToEnterView();
                    break;
                default:
                    break;
            }



        }

    }
}
