using System;
using BookManagementSystem.Controller;

namespace BookManagementSystem.View
{
	public class ManageUserView:BaseView
	{
		public void ManagerUser()
		{
			Console.WriteLine("***************用户管理界面*****************");
			Console.WriteLine("***************1.增加用户********************");
			Console.WriteLine("***************2.移除用户********************");
			Console.WriteLine("***************3.修改用户********************");
			Console.WriteLine("***************4.查询所有用户****************");
			Console.WriteLine("***************5.返回上一层******************");

			string ret = Utils.Input("请选择您的操作:");
			switch (ret)
			{
				case "1":
					Console.Clear();
					UserController.Instance.OpenAddUserView();
					break;
				case "2":
					Console.Clear();
					UserController.Instance.OpenDeleteUserView();
					break;
				case "3":
					Console.Clear();
					UserController.Instance.OpenModifyUserView();
					break;
				case "4":
					Console.Clear();
					UserController.Instance.SearchUsersInfo();
					break;
				case "5":
					Console.Clear();
					UserController.Instance.BackToManageMainView();
					break;
				default:
					break;
			}
		}
	}
}