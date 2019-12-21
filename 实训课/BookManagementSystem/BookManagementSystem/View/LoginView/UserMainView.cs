using BookManagementSystem.Controller;
using BookManagementSystem.Frameworrk;
using System;

namespace BookManagementSystem.View
{
	public class UserMainView : BaseView
	{
		public void UserMain()
		{
			Console.WriteLine("********用户主页面********");
			Console.WriteLine("********1.查询持有图书信息********");
			Console.WriteLine("********2.查询图书********");
			Console.WriteLine("********3.借书********");
			Console.WriteLine("********4.还书********");
			Console.WriteLine("********5.退出系统********");

			string ret = Utils.Input("请选择您的操作");

			switch (ret)
			{
				case "1":
					//ManagerController.Instance.OpenManageBookView();
					break;
				case "2":
					//TODO 管理用户
					//ManagerController.Instance.OpenManageUserView();
					break;
				case "3":
					//ManagerController.Instance.BackToEnterView();
					break;
				case "4":
					//ManagerController.Instance.BackToEnterView();
					break;
				case "5":
					UIManager.Instance.Close();
					ManagerController.Instance.BackToEnterView();
					break;
				default:
					break;
			}
		}
	}
}