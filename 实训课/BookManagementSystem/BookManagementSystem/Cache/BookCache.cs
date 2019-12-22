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

		public BookCache()
		{
			AddBook("001", "c", "cc", 10);
			AddBook("002", "cs", "cc", 10);
		}

		private static int bookId = 0;

		public static int ID{ get{ return bookId++; }}

		public bool ExistBookByBookId(int bookId){ return bookDict.ContainsKey(bookId); }

		public bool ExistByISBN(string isbn){
			return bookDict.Values.ToList().Exists((item) =>{ return item.ISBN == isbn; });
		}

		public bool ExistBookByName(string name){
			return bookDict.Values.ToList().Exists((item) => { return item.Name == name; });
		}

		public Book GetBookByBookId(int bookId){ return bookDict[bookId]; }

		public Book GetBookByISBN(string isbn){ 
			return bookDict.Values.ToList().Find((item)=>{ return item.ISBN == isbn; });
		}

		public Book GetBookByName(string name){
			return bookDict.Values.ToList().Find((item) => { return item.Name == name; });
		}

		/// <summary>
		/// 新增图书 
		/// 新增种类
		/// </summary>
		/// <param name="book"></param>
		public void AddBook(Book book){
			book.ID = ID;
			bookDict.Add(book.ID, book);
		}

		public Book AddBook(string isbn,string bookname,string author,int count)
		{
			Book book = new Book()
			{
				ID = ID,
				ISBN = isbn,
				Name = bookname,
				Author = author,
				Count = count
			};
			bookDict.Add(book.ID, book);
			return book;
		}

		/// <summary>
		/// 图书数量增加
		/// </summary>
		/// <param name="book"></param>
		/// <param name="count"></param>
		public void UpdateBookCount_Add(Book book, int count){ book.Count += count; }

		/// <summary>
		/// 图书数量减少
		/// </summary>
		/// <param name="book"></param>
		/// <param name="count"></param>
		public void UpdateBookCount_Reduce(Book book, int count){ book.Count -= count; }

		/// <summary>
		/// 获取所有图书
		/// </summary>
		/// <returns></returns>
		public List<Book> GetAllBooks(){ return bookDict.Values.ToList(); }

		/// <summary>
		/// 删除图书
		/// </summary>
		/// <param name="bookId"></param>
		public void DeleteBook(int bookId){ bookDict.Remove(bookId); }
	}
}