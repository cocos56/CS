using BookManagementSystem.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagementSystem.View
{
    public class DeleteBookView:BaseView
    {
        public void DeleteBook()
        {
            Console.WriteLine("***********删除图书界面**************");
            int bookId = int.Parse( Utils.Input("请输入图书Id"));
            BookController.Instance.DeleteBook(bookId);
        }

    }
}
