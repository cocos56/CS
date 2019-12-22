using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookManagementSystem.Model;

namespace BookManagementSystem.Frameworrk
{
    public class DataManager:Singleton<DataManager>
    {
        public IdentifyType CurrentIdentifyType;
        public Role CurrentRole;
    }
}
