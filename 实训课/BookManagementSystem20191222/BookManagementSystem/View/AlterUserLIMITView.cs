using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookManagementSystem.Cache;
using BookManagementSystem.Model;
using BookManagementSystem.Frameworrk;
using BookManagementSystem.View;

namespace BookManagementSystem.View
{
    public  class AlterUserLimitView:BaseView
    {
        public void alteruserview()
        {
            string username=Utils.Input("输入修改权限的用户名");
            int uselimit = Utils.InputInt("输入修改的权限：");
            if (AccountCache.Instance.ExistUserByUsername(username))
            {
                User user= AccountCache.Instance.GetUserByUsername(username);
                user.Limit = uselimit;
                UIManager.Instance.Open<ShowUsersInfoView>().ShowOneUserInfo(user);
                Console.WriteLine();
            }
            else
            {
                Error("找不到用户!");
            }
            UIManager.Instance.Open<ManageUserView>().ManagerUser();
        }
        public void Error(string error)
        {
            Console.WriteLine("*************错误提示**************");
            Console.WriteLine(error);
            Console.WriteLine();
        }
    }
}
