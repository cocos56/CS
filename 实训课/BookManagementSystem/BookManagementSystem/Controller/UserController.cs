using System.Collections.Generic;
using BookManagementSystem.Frameworrk;
using BookManagementSystem.Cache;
using BookManagementSystem.View;
using BookManagementSystem.Model;
using System;

namespace BookManagementSystem.Controller
{
	public class UserController:Singleton<UserController>
	{

		/// <summary>
		/// 借书
		/// </summary>
		/// <param name="user">用户</param>
		/// <param name="count">数量</param>
		/// <param name="bookId">借的书的id</param>
		public void AddBook(User user, int count, int bookId)
		{
			//判断是不是在图书馆存在
			if (BookCache.Instance.ExistBookByBookId(bookId))
			{
				Book book = BookCache.Instance.GetBookByBookId(bookId);
				user.AddBook(book, count);
			}
			else
			{
				Utils.Error("图书不存在，借书失败！");
			}
		}

		public void AddBook(User user, int count, string bookName)
		{
			//判断是不是在图书馆存在
			if (BookCache.Instance.ExistBookByName(bookName))
			{
				Book book = BookCache.Instance.GetBookByName(bookName);
				user.AddBook(book, count);
			}
			else
			{
				Utils.Error("图书不存在，借书失败！");
			}
		}

		public void OpenSearchKeepBookView()
		{
			UIManager.Instance.Open<SearchKeepBookView>().SearchKeepBook();
		}

		public void OpenSearchBookMainView()
		{
			UIManager.Instance.Open<SearchBookMainView>().SearchBookMain();
		}

		public void OpenBorrowBookMainView()
		{
			UIManager.Instance.Open<BorrowBookMainView>().BorrowBookMain();
		}

		public void OpenReturnBookMainView()
		{
			UIManager.Instance.Open<ReturnBookMainView>().ReturnBookMain();
		}

		public void AddUser(string username,string password,string repeatPassword, int limit)
		{
			bool ret = AccountCache.Instance.ExistUserByUsername(username);
			if (ret)
			{
				Utils.Error("用户已存在");
			}
			else
			{
				//前台校验
				if (password.Length==0 || repeatPassword.Length==0)
				{
					Utils.Error("密码长度不能为0");
				}
				else if (password != repeatPassword)
				{
					Utils.Error("两次密码不一致");
				}
				else
				{
					AccountCache.Instance.AddUser(username, password, limit);
					UIManager.Instance.Open<ManageUserView>().ManagerUser();
					return;
				}
			}
			UIManager.Instance.Open<ManageUserView>().ManagerUser();
		}

		public void OpenAddUserView()
		{
			UIManager.Instance.Open<AddUserView>().AddUser();
		}

		public void SearchUsersInfo()
		{
			List<User> userList = AccountCache.Instance.GetAllUserInfo();
			UIManager.Instance.Open<ShowUsersInfoView>().ShowAllUserInfo(userList);
			UIManager.Instance.Open<ManageUserView>().ManagerUser();
		}

		public void BackToManageMainView()
		{
			UIManager.Instance.Open<ManagerMainView>().ManagerMain();
		}

		public void OpenDeleteUserView()
		{
			UIManager.Instance.Open<DeleteUserView>().DeleteUser();
		}

		public void OpenModifyUserView()
		{
			UIManager.Instance.Open<ModifyUserView>().ModifyUser();
		}

		public void DeleteUser(int id)
		{
			bool ret= AccountCache.Instance.ExistUserById(id);
			if (ret)
			{
				AccountCache.Instance.DeleteUserById(id);
			}
			else
			{
				UIManager.Instance.Open<DeleteUserView>().Error("用户不存在，删除失败");
			}
			UIManager.Instance.Open<ManageUserView>().ManagerUser();
		}
	}
}