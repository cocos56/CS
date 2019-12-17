using BookManagementSystem.FrameWork;
using BookManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagementSystem.Cache
{
	public class AccountCache:Singleton<AccountCache>
	{
		Dictionary<int, User> userDict = new Dictionary<int, User>();

		Dictionary<int, Manager> managerDict = new Dictionary<int, Manager>;


	}
}
