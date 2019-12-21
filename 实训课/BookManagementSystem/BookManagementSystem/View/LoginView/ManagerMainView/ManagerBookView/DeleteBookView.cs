using BookManagementSystem.Controller;
using System;

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