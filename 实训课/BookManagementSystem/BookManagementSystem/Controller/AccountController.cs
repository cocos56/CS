using System;
using BookManagementSystem.Frameworrk;
using BookManagementSystem.Model;
using BookManagementSystem.View;
using BookManagementSystem.Cache;

namespace BookManagementSystem.Controller
{
	public class AccountController:Singleton<AccountController>
	{

		public void Enter(IdentifyType identifyType )
		{
			DataManager.Instance.CurrentIdentifyType = identifyType;
		   Console.Clear();
			UIManager.Instance.Open<LoginView>().Login();
		}

		public void Login(string username,string password)
		{
			switch (DataManager.Instance.CurrentIdentifyType)
			{
				case Model.IdentifyType.User:
					UserLoginResponse(username, password);
					break;
				case Model.IdentifyType.Manager:
					ManagerLoginResponse(username, password);
					break;
				default:
					break;
			}
		}

		public void UserLoginResponse(string username, string password)
		{
			User user = AccountCache.Instance.GetUserByUsername(username);

			if (user == null)
			{
				Console.Clear();
				Utils.Error("用户不存在");
				UIManager.Instance.Open<EnterView>().Enter();
			}
			else
			{
				if (user.Username == username && user.Passsword == password)
				{
					DataManager.Instance.CurrentRole = user;
					Console.Clear();
					Console.WriteLine("恭喜，登录成功，您的信息为：\n"+user);
					Utils.Continue(delegate() { UIManager.Instance.Open<UserMainView>().UserMain(); });
				}
				else
				{
				   Console.Clear();
					Console.WriteLine("用户名或密码错误");
					UIManager.Instance.Open<EnterView>().Enter();
				}
			}
		}

		public void ManagerLoginResponse(string username, string password)
		{
			Manager manager = AccountCache.Instance.GetManagerByUsername(username);
			if (manager == null)
			{
			   Console.Clear();
				Console.WriteLine("用户不存在");
				UIManager.Instance.Open<EnterView>().Enter();
			}
			else
			{
				if (manager.Username == username && manager.Passsword == password)
				{
					DataManager.Instance.CurrentRole = manager;
					Console.Clear();
					Console.WriteLine("恭喜，登录成功，您的信息为：\n" + manager);
					Utils.Continue(delegate (){	UIManager.Instance.Open<ManagerMainView>().ManagerMain();	});

				}
				else
				{
					Console.Clear();
					Console.WriteLine("用户名或密码错误");
					UIManager.Instance.Open<EnterView>().Enter();
				}
			}
		}
	}
}