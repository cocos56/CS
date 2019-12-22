using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookManagementSystem.Cache;

namespace BookManagementSystem.View
{
    public class UpdatePassWordView:BaseView
    {
        public void updatepass()
        {
            Console.WriteLine("***************修改用户密码界面*****************");
            string username = Utils.Input("请输入用户名");
            string oldpassword = Utils.Input("请输入原密码");
            string newPassword = Utils.Input("请输入新的密码");
            AccountCache.Instance.UpdateUserPassWord(username, oldpassword, newPassword);
        }
    }
}
