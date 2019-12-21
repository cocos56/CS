﻿using BookManagementSystem.Frameworrk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookManagementSystem.View;
using BookManagementSystem.Model;
using BookManagementSystem.Cache;

namespace BookManagementSystem.Controller
{
    public class ManagerController:Singleton<ManagerController>
    {
        /// <summary>
        /// 打开图书管理界面
        /// </summary>
        public void OpenManageBookView()
        {
            UIManager.Instance.Open<ManagerBookView>().ManagerBook();
        }

        public void OpenManageUserView()
        {
            UIManager.Instance.Open<ManageUserView>().ManagerUser();
        }

        public void OpenAddBookView()
        {
            UIManager.Instance.Open<AddBookView>().AddBook();
        }

        public void OpenDeleteBookView()
        {
            UIManager.Instance.Open<DeleteBookView>().DeleteBook();
        }
        /// <summary>
        /// 查询所有图书
        /// </summary>
        public void OpenSearchBookView()
        {
            List<Book> bookList = BookCache.Instance.GetAllBooks();
            UIManager.Instance.Open<ShowBookInfoView>().ShowBooksInfo(bookList);
            UIManager.Instance.Open<ManagerBookView>().ManagerBook();
        }


        /// <summary>
        /// 返回上一层
        /// </summary>
        public void BackToManagerMainView()
        {
            UIManager.Instance.Open<ManagerMainView>().ManagerMain();
        }

        public void BackToEnterView()
        {
            UIManager.Instance.Open<EnterView>().Enter();
        }

        public void OpenSearchMainBookView()
        {
            UIManager.Instance.Open<SearchBookMainView>().SearchBookView();
        }

        public void OpenUserMainView()
        {
            UIManager.Instance.Open<UserMainView>().userMain();
        }
    }
}
