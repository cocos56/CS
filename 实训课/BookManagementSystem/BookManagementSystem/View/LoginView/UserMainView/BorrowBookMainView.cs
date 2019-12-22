using BookManagementSystem.Frameworrk;
using System;

namespace BookManagementSystem.View
{
	public class BorrowBookMainView : BaseView
	{
		public void BorrowBookMain()
		{
			Console.WriteLine("********借书主页面********");
			Console.WriteLine("********1.根据图书ID借书********");
			Console.WriteLine("********2.根据图书名借书********");
			Console.WriteLine("********3.返回********");

			string ret = Utils.Input("请选择您的操作");

			switch (ret)
			{
				case "1":
					Console.Clear();
					UIManager.Instance.Open<BorrowBookView>().BorrowBookByID();
					break;
				case "2":
					Console.Clear();
					//UIManager.Instance.Open<UserMainView>().UserMain();
					break;
				case "3":
					Console.Clear();
					UIManager.Instance.Open<UserMainView>().UserMain();
					break;
				default:
					break;
			}
		}
	}
}