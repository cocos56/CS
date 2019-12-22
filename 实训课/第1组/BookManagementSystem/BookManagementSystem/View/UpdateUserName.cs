using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookManagementSystem.Cache;

namespace BookManagementSystem.View
{
    public  class UpdateUserName:BaseView
    {
        public void  updateusername()
        {
            Console.WriteLine("***************修改用户名字界面*****************");
            string oldusername = Utils.Input("请输入原用户名");
            string newusername = Utils.Input("请输入新用户名");
            string Password = Utils.Input("请输入用户密码");
            AccountCache.Instance.UpdateUserName(oldusername, newusername, Password);
        }
    }
}
