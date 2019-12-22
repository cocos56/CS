using BookManagementSystem.Frameworrk;
using BookManagementSystem.Model;
using BookManagementSystem.View;
using BookManagementSystem.Cache;

namespace BookManagementSystem.Controller
{
    public class AccountController:Singleton<AccountController>
    {

        public void Enter(IdentifyType identifyType )
        {
            DataManager.Instance.CurrentIdentifyType = identifyType;
            UIManager.Instance.Close();
            UIManager.Instance.Open<LoginView>().Login();
        }

        public void Login(string username,string password)
        {
            switch (DataManager.Instance.CurrentIdentifyType)
            {
                case Model.IdentifyType.User:
                    UserLoginResponse(username, password);
                    break;
                case Model.IdentifyType.Manager:
                    ManagerLoginResponse(username, password);
                    break;

                default:
                    break;
            }
        }

        public void UserLoginResponse(string username, string password)
        {
            User user = AccountCache.Instance.GetUserByUsername(username);
            if (user == null)
            {
                UIManager.Instance.Close();
                UIManager.Instance.Open<EnterView>().Error("用户不存在");
                UIManager.Instance.Open<EnterView>().Enter();
            }
            else
            {
                if (user.Username == username && user.Passsword == password)
                {
                    DataManager.Instance.CurrentRole =user;
                    UIManager.Instance.Open<UserMainView>().userMain();
                }
                else
                {
                    UIManager.Instance.Close();
                    UIManager.Instance.Open<EnterView>().Error("用户名或密码错误");
                    UIManager.Instance.Open<EnterView>().Enter();
                }

            }
        }

        public void ManagerLoginResponse(string username, string password)
        {
            Manager manager = AccountCache.Instance.GetManagerByUsername(username);
            if (manager == null)
            {
                UIManager.Instance.Close();
                UIManager.Instance.Open<EnterView>().Error("用户不存在");
                UIManager.Instance.Open<EnterView>().Enter();
            }
            else
            {
                if (manager.Username == username && manager.Passsword == password)
                {
                    UIManager.Instance.Open<ManagerMainView>().ManagerMain();
                }
                else
                {
                    UIManager.Instance.Close();
                    UIManager.Instance.Open<EnterView>().Error("用户名或密码错误");
                    UIManager.Instance.Open<EnterView>().Enter();
                }
            }
        }
    }
}