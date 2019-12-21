using System;
using BookManagementSystem.Controller;

namespace BookManagementSystem.View
{
	public class ManagerBookView:BaseView
	{
		public void ManagerBook()
		{
			Console.WriteLine("*********图书管理界面*********");
			Console.WriteLine("*********1.添加图书************");
			Console.WriteLine("*********2.删除图书************");
			Console.WriteLine("*********3.查询所有图书********");
			Console.WriteLine("*********4.返回上一层界面*******");
			string ret = Utils.Input("请选择操作");
			switch (ret)
			{
				case "1":
					Console.Clear();
					ManagerController.Instance.OpenAddBookView();
					break;
				case "2":
					Console.Clear();
					ManagerController.Instance.OpenDeleteBookView();
					break;

				case "3":
					Console.Clear();
					ManagerController.Instance.OpenSearchBookView();
					break;

				case "4":
					Console.Clear();
					ManagerController.Instance.BackToManagerMainView();
					break;
				default:
					break;
			}
		}
	}
}