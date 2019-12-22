using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookManagementSystem.Frameworrk;
using BookManagementSystem.Model;
using BookManagementSystem.Controller;

namespace BookManagementSystem.View
{
    public class ReturnBookView:BaseView
    {
       
        public void returnBook()
        {
            int bookId = Utils.InputInt("请输入还书ID：");
            int count = Utils.InputInt("请输入还书数量：");
            User user= DataManager.Instance.CurrentRole as User;
            BorrowAndReturnBookController.Instance.DeleteUserBook(bookId,count, user );
        }

        public void returnBookByBookName()
        {
            string  bookId = Utils.Input("请输入还书名字：");
            int count = Utils.InputInt("请输入还书数量：");
            User user = DataManager.Instance.CurrentRole as User;
            BorrowAndReturnBookController.Instance.DeleteUserBook(bookId, count, user);
        }

    }
}
