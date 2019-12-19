using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookManagementSystem.Frameworrk;
using BookManagementSystem.Cache;
using BookManagementSystem.View;
namespace BookManagementSystem.Controller
{
    public class UserController:Singleton<UserController>
    {
        public void AddUser(string username,string password,string repeatPassword)
        {
            bool ret = AccountCache.Instance.ExistUserByUsername(username);
            if (ret)
            {
                UIManager.Instance.Open<ManageUserView>().Error("用户已存在");
               
            }
            else
            {
                //前台校验
                if (password.Length==0 || repeatPassword.Length==0)
                {
                    UIManager.Instance.Open<ManageUserView>().Error("密码长度不能为0");
                }
                else if (password != repeatPassword)
                {
                    UIManager.Instance.Open<ManageUserView>().Error("两次密码不一致");
                }
                else
                {
                    AccountCache.Instance.AddUser(username, password);
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

        public void BackToManageUserView()
        {
            UIManager.Instance.Open<ManageUserView>().ManagerUser();
        }

    }
}
