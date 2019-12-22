using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookManagementSystem.Controller;
using BookManagementSystem.Frameworrk;
using BookManagementSystem.Cache;

namespace BookManagementSystem.View
{
    public  class UserMainView:BaseView
    {
        public void userMain()
        {
            Console.WriteLine("*************用户主界面******************");
            Console.WriteLine("*************1.查询持有图书信息**********");
            Console.WriteLine("*************2.查询图书******************");
            Console.WriteLine("*************3.借书**********************");
            Console.WriteLine("*************4.还书**********************");
            Console.WriteLine("*************5.退出系统******************");
            string res = Utils.Input("请输入你要做的操作：");
            switch (res)
            {
                case "1":
                    BorrowAndReturnBookController.Instance.OpenShowUserBookList();
                    break;
                case "2":
                    ManagerController.Instance.OpenSearchMainBookView();
                    break;
                case "3":
                    //BorrowAndReturnBookController.Instance.OpenBorrowView();
                    //UIManager.Instance.Open<BorrowBookView>().borrowbookByName();
                    //BorrowAndReturnBookController.Instance.OpenUserMainView();
                    BorrowAndReturnBookController.Instance.OpenBorrowBookMainView();
                    break;
                case "4":
                    //BorrowAndReturnBookController.Instance.OpenReturnView();
                    //UIManager.Instance.Open<ReturnBookView>().returnBookByBookName();
                    //BorrowAndReturnBookController.Instance.OpenUserMainView();
                    BorrowAndReturnBookController.Instance.OpenRetrunBookMainView();
                    break;
                case "5":
                    ManagerController.Instance.BackToEnterView();
                    break;
                default:
                    break;
            }
        }
 
    }
}
