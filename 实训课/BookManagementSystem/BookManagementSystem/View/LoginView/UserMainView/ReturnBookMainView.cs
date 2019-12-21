using BookManagementSystem.Frameworrk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagementSystem.View
{
	public class ReturnBookMainView : BaseView
	{
		public void ReturnBookMain()
		{
			Console.WriteLine("********还书主页面********");
			Console.WriteLine("********1.还书********");
			Console.WriteLine("********2.返回********");

			string ret = Utils.Input("请选择您的操作");

			switch (ret)
			{
				case "1":
					//UserController.Instance.OpenSearchKeepBookView();
					break;
				case "2":
					Console.Clear();
					UIManager.Instance.Open<UserMainView>().UserMain();
					break;
				default:
					break;
			}
		}
	}
}