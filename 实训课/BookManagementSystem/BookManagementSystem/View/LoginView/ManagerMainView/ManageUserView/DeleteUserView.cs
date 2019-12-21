using BookManagementSystem.Controller;
using System;

namespace BookManagementSystem.View
{
	public class DeleteUserView:BaseView
	{
		public void DeleteUser()
		{
			Console.WriteLine("***********删除用户界面**********");
			int userId = Utils.InputInt("请输入用户的Id");

			UserController.Instance.DeleteUser(userId);

		}

		public void Error(string error)
		{
			Console.WriteLine("**********用户删除警告*********");
			Console.WriteLine(error);
		}
	}
}