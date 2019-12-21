using BookManagementSystem.Frameworrk;
using BookManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagementSystem.View
{
	public class SearchKeepBookView : BaseView
	{
		public void SearchKeepBook()
		{
			Console.Clear();
			User user = DataManager.Instance.CurrentRole as User;
			user.ShowUserBook();
			Utils.Continue(delegate () { UIManager.Instance.Open<UserMainView>().UserMain(); });
		}
	}
}