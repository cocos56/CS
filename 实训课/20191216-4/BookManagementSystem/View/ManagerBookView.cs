using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookManagementSystem.Controller;

namespace BookManagementSystem.View
{
    public class ManagerBookView:BaseView
    {
        public void ManagerBook()
        {
            Console.WriteLine("*********图书管理界面*********");
            Console.WriteLine("*********1.添加图书************");
            Console.WriteLine("*********2.删除图书************");

            string ret = Utils.Input("请选择操作");
            switch (ret)
            {
                case "1":
                    ManagerController.Instance.OpenAddBookView();
                    break;
                case "2":
                    break;

                default:
                    break;
            }

        }
    }
}
