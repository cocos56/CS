using BookManagementSystem.Controller;
using System;

namespace BookManagementSystem.View
{
	public class LoginView:BaseView
	{
		public void Login()
		{
			Console.WriteLine("*******************登录界面******************");
			string username = Utils.Input("请输入账户");
			string password = Utils.Input("请输入密码");

			Console.Clear();
			AccountController.Instance.Login(username, password);
		}
	}
}