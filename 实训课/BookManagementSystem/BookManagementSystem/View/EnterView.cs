using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookManagementSystem.Controller;

namespace BookManagementSystem.View
{
	public class EnterView: BaseView
	{
		public void Enter()
		{
			Console.WriteLine("**********图书管理系统**********");
			Console.WriteLine("**********1.用户登录**********");
			Console.WriteLine("**********2.管理员登录**********");

			Console.WriteLine("请选择操作：");
			string ret = Console.ReadLine();
			switch (ret)
			{
				case "1":
					AccountController.Instance.Enter(Model.IdentifyType user);
				default:
					break;
			}
		}
	}
}
