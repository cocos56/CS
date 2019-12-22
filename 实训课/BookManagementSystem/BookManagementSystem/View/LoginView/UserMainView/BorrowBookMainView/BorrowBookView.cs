using BookManagementSystem.Controller;
using BookManagementSystem.Frameworrk;
using BookManagementSystem.Model;
using System;

namespace BookManagementSystem.View
{
	public class BorrowBookView : BaseView
	{
		public void BorrowBookByID()
		{
			Console.Clear();
			int bookId = Utils.InputInt("请输入所借图书的ID：");
			int count = Utils.InputInt("请输入借书数量：");
			Console.Clear();
			User user = DataManager.Instance.CurrentRole as User;
			UserController.Instance.AddBook(user, count, bookId);
			Utils.Continue(delegate () { UserController.Instance.OpenBorrowBookMainView(); });
		}

		public void BorrowBookByName()
		{
			Console.Clear();
			string bookName = Utils.Input("请输入所借图书的名字：");
			int count = Utils.InputInt("请输入借书数量：");
			Console.Clear();
			User user = DataManager.Instance.CurrentRole as User;
			UserController.Instance.AddBook(user, count, bookName);
			Utils.Continue(delegate () { UserController.Instance.OpenBorrowBookMainView(); });
		}
	}
}