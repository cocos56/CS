using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookManagementSystem.Controller;

namespace BookManagementSystem.View
{
    public class AddBookView:BaseView
    {
        public void AddBook()
        {
            Console.WriteLine("********** 添加图书界面 *********");
            string isbn = Utils.Input("请输入ISBN号");
            string bookname = Utils.Input("请输入图书名字");
            string author = Utils.Input("请输入图书作者");
            int addcount = int.Parse(Utils.Input("请输入图书数量"));
            BookController.Instance.AddBook(isbn,bookname,author, addcount);
        }
    }
}
