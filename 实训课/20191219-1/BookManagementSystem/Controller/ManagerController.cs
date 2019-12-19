using BookManagementSystem.Frameworrk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookManagementSystem.View;

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

        public void OpenAddBookView()
        {
            UIManager.Instance.Open<AddBookView>().AddBook();
        }

        public void OpenDeleteBookView()
        {
            UIManager.Instance.Open<DeleteBookView>().DeleteBook();
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
    }
}
