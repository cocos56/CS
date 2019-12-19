﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookManagementSystem.Controller;

namespace BookManagementSystem.View
{
    public class ManageUserView:BaseView
    {

        public void ManagerUser()
        {
            Console.WriteLine("***************用户管理界面*****************");
            Console.WriteLine("***************1.增加用户********************");
            Console.WriteLine("***************2.移除用户********************");
            Console.WriteLine("***************3.查询所有用户****************");
            Console.WriteLine("***************4.返回上一层********************");

            string ret = Utils.Input("请选择您的操作:");
            switch (ret)
            {
                case "1":
                    UserController.Instance.OpenAddUserView();
                    break;
                case "2":
                    break;
                case "3":
                    break;
                case "4":
                    UserController.Instance.BackToManageUserView();
                    break;

                default:
                    break;
            }
        }


        public void Error(string error)
        {
            Console.WriteLine("**************用户错误界面*************");
            Console.WriteLine(error);
        }
    }
}
