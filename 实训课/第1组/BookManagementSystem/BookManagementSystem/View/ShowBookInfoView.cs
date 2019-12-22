using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookManagementSystem.Model;

namespace BookManagementSystem.View
{
    public class ShowBookInfoView:BaseView
    {
        /// <summary>
        /// 显示一本图书信息
        /// </summary>
        /// <param name="book"></param>
        public void ShowBookInfo(Book book)
        {
            Console.WriteLine("************图书信息*************");
            Console.WriteLine(book);
        }
        /// <summary>
        /// 展示多本图书信息
        /// </summary>
        /// <param name="bookList"></param>
        public void ShowBooksInfo(List<Book> bookList)
        {
            Console.WriteLine("*************图书信息***************");
            foreach (var item in bookList)
            {
                Console.WriteLine(item);
            }
        }


        public void Error(string error)
        {
            Console.WriteLine("***********错误提示**********");
            Console.WriteLine(error);
        }

    }
}
