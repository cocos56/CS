using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookManagementSystem.Frameworrk;
using BookManagementSystem.Model;
using BookManagementSystem.Cache;

namespace BookManagementSystem.Controller
{
    public class BookController:Singleton<BookController>
    {
        public void AddBook(string isbn,string bookname,string author,int addCount)
        {
            Book book = BookCache.Instance.GetBookByISBN(isbn);
            if (book == null)
            {
                BookCache.Instance.AddBook(isbn, bookname, author, addCount);
                
            }
            else
            {

            }
        }


    }
}
