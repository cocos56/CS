using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookManagementSystem.Controller;

namespace BookManagementSystem.View
{
    public  class ReturnBookMainView:BaseView
    {
        public void returnbookView()
        {
            Console.WriteLine("*************还书主界面******************");
            Console.WriteLine("*************1.还书通过图书ID**********************");
            Console.WriteLine("**************2.还书通过书名**********************");
            Console.WriteLine("*************3返回******************");
            string res = Utils.Input("请输入你要做的操作：");
            switch (res)
            {
                case "1":
                    BorrowAndReturnBookController.Instance.OpenReturnView();
                    break;
                case "2":
                    BorrowAndReturnBookController.Instance.OpenReturnViewByName();
                    break;
                case "3":
                    BorrowAndReturnBookController.Instance.OpenUserMainView();
                    break;
                default:
                    break;
            }
        }
        
}
}
