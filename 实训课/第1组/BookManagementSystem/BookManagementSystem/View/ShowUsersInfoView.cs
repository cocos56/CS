using BookManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagementSystem.View
{
    public class ShowUsersInfoView:BaseView
    {
        public void ShowAllUserInfo(List<User> userList)
        {
            Console.WriteLine("************用户信息***************");
            foreach (var item in userList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
        public void ShowOneUserInfo(User user)
        {
            Console.WriteLine("************用户信息***************");
            Console.WriteLine("{0} 权限：{1}",user,user.Limit);
            Console.WriteLine();
        }
    }
}
