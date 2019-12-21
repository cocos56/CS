using BookManagementSystem.Controller;
using BookManagementSystem.Frameworrk;
using System;

namespace BookManagementSystem.View
{
	public class UserMainView : BaseView
	{
		public void UserMain()
		{
			Console.WriteLine("***************用户主页面***************");
			Console.WriteLine("***************1.查询持有图书信息*******");
			Console.WriteLine("***************2.查询图书***************");
			Console.WriteLine("***************3.借书*******************");
			Console.WriteLine("***************4.还书*******************");
			Console.WriteLine("***************5.退出系统***************");

			string ret = Utils.Input("请选择您的操作");

			switch (ret)
			{
				case "1":
					UserController.Instance.OpenSearchKeepBookView();
					break;
				case "2":
					UserController.Instance.OpenSearchBookMainView();
					break;
				case "3":
					UserController.Instance.OpenBorrowBookMainView();
					break;
				case "4":
					UserController.Instance.OpenReturnBookMainView();
					break;
				case "5":
					Console.Clear();
					ManagerController.Instance.BackToEnterView();
					break;
				default:
					break;
			}
		}
	}
}