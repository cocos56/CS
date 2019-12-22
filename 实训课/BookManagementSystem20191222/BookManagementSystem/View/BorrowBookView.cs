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
    public class BorrowBookView:BaseView
    {
        public void borrowbook()
        {
            int bookId = Utils.InputInt("请输入借书ID：");
            int count = Utils.InputInt("请输入借书数量：");
            User user = DataManager.Instance.CurrentRole as User;
            BorrowAndReturnBookController.Instance.AddUserBook(user, count, bookId);
        }
        public void borrowbookByName()
        {
            string  bookId = Utils.Input("请输入借书名字：");
            int count = Utils.InputInt("请输入借书数量：");
            User user = DataManager.Instance.CurrentRole as User;
            BorrowAndReturnBookController.Instance.AddUserBookByName(user, count, bookId);
        }
    }
}
