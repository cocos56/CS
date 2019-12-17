using BookManagementSystem.FrameWork;
using BookManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagementSystem.Controller
{
	class AccountController:Singleton<AccountController>
	{
		public void Enter(IdentifyType identifyType)
		{
			DataManager.Instance.CurrentIdentifyType
		}
	}
}
