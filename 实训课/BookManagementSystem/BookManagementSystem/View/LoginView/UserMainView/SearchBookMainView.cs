using BookManagementSystem.Frameworrk;
using System;

namespace BookManagementSystem.View
{
	public class SearchBookMainView : BaseView
	{
		public void SearchBookMain()
		{
			Console.WriteLine("********查询图书主页面********");
			Console.WriteLine("********1.按图书名字查找********");
			Console.WriteLine("********2.按图书ISBN查找********");
			Console.WriteLine("********3.按图书作者查找********");
			Console.WriteLine("********4.列出所有图书********");
			Console.WriteLine("********5.返回********");

			string ret = Utils.Input("请选择您的操作");

			switch (ret)
			{
				case "1":
					//UserController.Instance.OpenSearchKeepBookView();
					break;
				case "2":
					//UserController.Instance.OpenSearchKeepBookView();
					break;
				case "3":
					//UserController.Instance.OpenSearchKeepBookView();
					break;
				case "4":
					//UserController.Instance.OpenSearchKeepBookView();
					break;
				case "5":
					//UserController.Instance.OpenSearchBookMainView();
					Console.Clear();
					UIManager.Instance.Open<UserMainView>().UserMain();
					break;
				default:
					break;
			}
		}
	}
}