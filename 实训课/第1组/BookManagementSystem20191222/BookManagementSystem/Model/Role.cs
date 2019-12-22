using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagementSystem.Model
{
    public class Role
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string Passsword { get; set; }

        public IdentifyType IdentifyType { get; set; }
    }
}
