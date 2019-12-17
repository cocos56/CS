using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace mostone
{
    public interface User
    {
        int Id { get; set; }
        string Name { get; set; }
        string Pass { get; set; }
        double Saves { get; set; }
    }
}
