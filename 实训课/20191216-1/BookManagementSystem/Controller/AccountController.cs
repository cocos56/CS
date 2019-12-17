using BookManagementSystem.Frameworrk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookManagementSystem.Model;
using BookManagementSystem.View;

namespace BookManagementSystem.Controller
{
    public class AccountController:Singleton<AccountController>
    {

        public void Enter(IdentifyType identifyType )
        {
            DataManager.Instance.CurrentIdentifyType = identifyType;
            UIManager.Instance.Open<LoginView>().Login();
        }
    }
}
