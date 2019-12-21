using System;
using BookManagementSystem.Controller;

namespace BookManagementSystem.View
{
	public class AddUserView:BaseView
	{
	   public void AddUser()
		{
			Console.WriteLine("***************添加用户界面*****************");
			string username = Utils.Input("请输入用户名");
			string password = Utils.Input("请输入密码");
			string repeatPassword = Utils.Input("请再次输入密码");
			int limit = Utils.InputInt("请输入该用户的最大借书数量");
			UserController.Instance.AddUser(username, password, repeatPassword, limit);
		}
	}
}