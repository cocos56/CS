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