using BookManagementSystem.Frameworrk;
using BookManagementSystem.Model;
using System.Collections.Generic;
using System.Linq;

namespace BookManagementSystem.Cache
{
    public class BookCache:Singleton<BookCache>
    {
        /// <summary>
        /// 模拟数据库中Book表
        /// </summary>
        Dictionary<int, Book> bookDict = new Dictionary<int, Book>();

        private static int bookId = 0;

        public BookCache()
        {
            AddBook("001", "c", "cc", 10);
            AddBook("002", "cs", "cc", 10);
        }

        public static int BookId
        {
            get
            {
                return bookId++;
            }
        }

        public bool ExistBookByBookId(int bookId)
        {
            return bookDict.ContainsKey(bookId);
        }

        public Book GetBookByBookId(int bookId)
        {
            return bookDict[bookId];
        }

        /// <summary>
        /// 通过ISBN查询是否存在
        /// </summary>
        /// <param name="isbn">图书ISBN</param>
        /// <returns>true 存在 false 不存在</returns>
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
        /// 通过图书名字查询是否存在
        /// </summary>
        /// <param name="name">图书名字</param>
        /// <returns>true 存在 false 不存在</returns>
        public bool ExistByName(string name)
        {
            return bookDict.Values.ToList().Exists((item) =>
            {
                return item.BookName == name;
            });
        }
        public Book GetBookByName(string name)
        {
            return bookDict.Values.ToList().Find((item) =>
            {
                return item.BookName == name;
            });
        }
        /// <summary>
        /// 通过图书作者名字查询是否存在
        /// </summary>
        /// <param name="authorname">图书作者名字</param>
        /// <returns>true 存在 false 不存在</returns>
        public bool ExistByAuthorName(string authorname)
        {
            return bookDict.Values.ToList().Exists((item) =>
            {
            return item.Author == authorname;
        });
        }
        public Book GetBookByAuthorName(string authorname)
        {
            return bookDict.Values.ToList().Find((item) =>
            {
                return item.Author == authorname;
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
        public Book AddBook(string isbn,string bookname,string author,int addCount)
        {
            Book book = new Book()
            {
                BookId = BookId,
                ISBN = isbn,
                BookName = bookname,
                Author = author,
                Count = addCount
            };
            bookDict.Add(book.BookId, book);
            return book;
        }

        /// <summary>
        /// 图书数量增加
        /// </summary>
        /// <param name="book"></param>
        /// <param name="count"></param>
        public void UpdateBookCount_Add(Book book, int count)
        {
            book.Count += count;
        }
        /// <summary>
        /// 图书数量减少
        /// </summary>
        /// <param name="book"></param>
        /// <param name="count"></param>
        public void UpdateBookCount_Reduce(Book book, int count)
        {
            book.Count -= count;
        }

        /// <summary>
        /// 获取所有图书
        /// </summary>
        /// <returns></returns>
        public List<Book> GetAllBooks()
        {
            return bookDict.Values.ToList();
        }

        /// <summary>
        /// 删除图书
        /// </summary>
        /// <param name="bookId"></param>
        public void DeleteBook(int bookId)
        {
            bookDict.Remove(bookId);
        }

    }
}