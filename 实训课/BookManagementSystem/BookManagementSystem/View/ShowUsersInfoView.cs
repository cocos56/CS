using BookManagementSystem.Model;
using System;
using System.Collections.Generic;

namespace BookManagementSystem.View
{
	public class ShowUsersInfoView:BaseView
	{
		public void ShowAllUserInfo(List<User> userList)
		{
			Console.WriteLine("************用户信息***************");
			foreach (var item in userList)
			{
				Console.WriteLine(item);
			}
		}
	}
}