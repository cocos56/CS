using System.Collections.Generic;
using BookManagementSystem.Frameworrk;
using BookManagementSystem.Cache;
using BookManagementSystem.View;
using BookManagementSystem.Model;

namespace BookManagementSystem.Controller
{
    public class UserController:Singleton<UserController>
    {

        /// <summary>
        /// /注册用户,包含管理员建用户和注册用户
        /// </summary>
        ///     
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

                    if (DataManager.Instance.CurrentIdentifyType == IdentifyType.User)
                    {
                        UIManager.Instance.Open<EnterView>().Enter();
                    }
                    else
                    {
                        UIManager.Instance.Open<ManageUserView>().ManagerUser();
                    }
                    return;
                }
            }
            if(DataManager.Instance.CurrentIdentifyType==IdentifyType.User)
            {
                UIManager.Instance.Open<EnterView>().Enter();
            }
            else
            {
                UIManager.Instance.Open<ManageUserView>().ManagerUser();
            }
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
