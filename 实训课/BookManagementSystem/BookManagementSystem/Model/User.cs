using BookManagementSystem.Cache;
using BookManagementSystem.Frameworrk;
using BookManagementSystem.View;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BookManagementSystem.Model
{
	public class User:Role
	{
		Dictionary<int, Book> bookList = new Dictionary<int, Book>();

		/// <summary>
		/// 用户借书的数量
		/// </summary>
		public int Limit { get; set; }

		public override string ToString(){
			return string.Format("ID:{0} Username:{1} IdentifyType:{2} Limit:{3}",ID,Username,IdentifyType.ToString(),Limit);
		}

		public void ShowUserBook()
		{
			Console.WriteLine("**************展示用户手中所有图书**");
			if (bookList.Count == 0){ Utils.Error("**************用户手中无书*********"); }
			else
			{
				List<Book> booklist = bookList.Values.ToList();
				UIManager.Instance.Open<ShowBookInfoView>().ShowBooksInfo(booklist);
			}
		}

		/// <summary>
		/// 增加书到字典
		/// </summary>
		/// <param name="book">将要增加的书</param>
		/// <param name="count">增加书的数</param>
		public void AddBook(Book book, int count)
		{
			if (Limit-count<0){
				Utils.Error("**************用户借书数量超出权限，借书失败!***************");
				return;
			}
			else{
				if (!ExistByBookId(book.ID)){ AddBookToDic(book, count);	}
				else{ bookList[book.ID].Count += count;}
				BookCache.Instance.UpdateBookCount_Reduce(book, count);
				Limit -= count;

				Console.WriteLine("恭喜您成功借到书。");
				Console.WriteLine("图书信息为：\n" + book);
				Console.WriteLine("您的信息为：\n" + this);
			}
		}

		public void AddBookToDic(Book oldbook, int count)
		{
			//增加书
			Book book = new Book(){
				ID = oldbook.ID,
				ISBN = oldbook.ISBN,
				Name = oldbook.Name,
				Author = oldbook.Author,
				Count = count
			};
			bookList.Add(book.ID, book);
		}

		public bool ExistByBookId(int bookid){
				return bookList.Values.ToList().Exists((item) =>{return item.ID == bookid;});
		}
	}
}