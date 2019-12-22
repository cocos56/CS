using BookManagementSystem.Frameworrk;
using BookManagementSystem.Model;
using System.Collections.Generic;
using System.Linq;

namespace BookManagementSystem.Cache
{
	public class AccountCache:Singleton<AccountCache>
	{
		Dictionary<int, User> userDict = new Dictionary<int, User>();

		Dictionary<int, Manager> managerDict = new Dictionary<int, Manager>();

		private static int m_id = 0;
		private static int u_id = 0;

		public static int MId{	get{return m_id++;}	}

		public static int UId{	get { return u_id++; }	}

		public AccountCache()
		{
			AddManager("111", "111");
			AddUser("aaa","aaa");

			AddManager("a", "a");

			AddManager("m", "m");
			AddUser("u", "u");
		}

		public void AddManager(string username,string password)
		{
			Manager manager = new Manager()
			{
				ID = MId,
				Username = username,
				Passsword = password,
				IdentifyType = IdentifyType.Manager
			};
			managerDict.Add(manager.ID, manager);
		}

		public void AddUser(string username, string password, int limit=3)
		{
			User user = new User()
			{
				ID = MId,
				Username = username,
				Passsword = password,
				IdentifyType = IdentifyType.User,
				Limit = limit,
			};
			userDict.Add(user.ID,user);
		}

		/// <summary>
		/// 根据用户名来查找是否存在此账户
		/// </summary>
		/// <param name="username"></param>
		/// <returns></returns>
		public bool ExistUserByUsername(string username)
		{
			return userDict.Values.ToList().Exists((item) =>
			{
				return item.Username == username;
			});
		}

		/// <summary>
		/// 通过Id判断用户是否存在
		/// </summary>
		/// <param name="id">用户的Id</param>
		/// <returns>true 存在  false  不存在 </returns>
		public bool ExistUserById(int id){ return userDict.ContainsKey(id); }

		public bool ExistManagerByUsername(string username)
		{

			//foreach (var item in managerDict.Values.ToList())
			//{
			//	if (item.Username == username)
			//	{
			//		return true;
			//	}
			//}
			//return false;

			return managerDict.Values.ToList().Exists((item) =>{ return item.Username == username; });
		}

		public Manager GetManagerByUsername(string username)
		{
			return managerDict.Values.ToList().Find((item) =>
			{
				return item.Username == username;
			});
		}

		public User GetUserByUsername(string username)
		{
			return userDict.Values.ToList().Find((item) =>
			{
				return item.Username == username;
			});
		}

		/// <summary>
		/// 获取所有用户的信息
		/// </summary>
		/// <returns>用户列表</returns>
		public List<User> GetAllUserInfo()
		{
			return userDict.Values.ToList();
		}

		public void DeleteUserById(int id)
		{
			userDict.Remove(id);
		}
	}
}