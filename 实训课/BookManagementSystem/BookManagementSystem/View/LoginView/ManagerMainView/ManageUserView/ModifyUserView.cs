using System;
using BookManagementSystem.Cache;
using BookManagementSystem.Frameworrk;
using BookManagementSystem.Model;

namespace BookManagementSystem.View
{
	public class ModifyUserView : BaseView
	{
	   public void ModifyUser()
		{
			string username;
			User user;
			while (true)
			{
				Console.WriteLine("***************修改用户界面*****************");
				username = Utils.Input("请输入用户名");
				bool ret = AccountCache.Instance.ExistUserByUsername(username);
				user = AccountCache.Instance.GetUserByUsername(username);
				if (!ret){
					Console.Clear();
					Utils.Error("用户不存在。");
				}
				else{
					Console.WriteLine("***************该用户的信息为：*********");
					Console.WriteLine(user);
					break;  }
			}
			int limit = Utils.InputInt("请输入该用户的最大借书数量");
			user.Limit = limit;
			Console.WriteLine("***************该用户的信息变更为：*********");
			Console.WriteLine(user);
			Utils.Continue(delegate () { UIManager.Instance.Open<ManageUserView>().ManagerUser(); });
		}
	}
}