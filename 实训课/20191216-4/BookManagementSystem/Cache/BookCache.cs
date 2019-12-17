using BookManagementSystem.Frameworrk;
using BookManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagementSystem.Cache
{
    public class BookCache:Singleton<BookCache>
    {
        /// <summary>
        /// 模拟数据库中Book表
        /// </summary>
        Dictionary<int, Book> bookDict = new Dictionary<int, Book>();

        private static int bookId = 0;

        public static int BookId
        {
            get
            {
                return bookId++;
            }
        }

        public bool ExistByISBN(string isbn)
        {
            return bookDict.Values.ToList().Exists((item) =>
            {
                return item.ISBN == isbn;
            });
        }

        public Book GetBookByISBN(string isbn)
        {
            return bookDict.Values.ToList().Find((item)=>
            {
                return item.ISBN == isbn;
            });
        }
        /// <summary>
        /// 新增图书 
        /// 新增种类
        /// </summary>
        /// <param name="book"></param>
        public void AddBook(Book book)
        {
            book.BookId = BookId;
            bookDict.Add(book.BookId, book);
        }
        public void AddBook(string isbn,string bookname,string author,int addCount)
        {
            Book book = new Book()
            {
                BookId = BookId,
                ISBN = isbn,
                BookName = bookname,
                Author = author,
                Count = addCount
            };
            Console.WriteLine(book);
            bookDict.Add(book.BookId, book);
        }

    }
}
