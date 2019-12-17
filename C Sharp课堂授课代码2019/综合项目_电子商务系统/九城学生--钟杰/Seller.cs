using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace mostone
{
    public class Seller : User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Pass { get; set; }
        public double Saves { get; set; }

        public Seller() { 
        }

        public Seller(int id, string name, string pass, double saves) {
            Id = id;
            Name = name;
            Pass = pass;
            Saves = saves;
        }

        public override string ToString()
        {
            return string.Format("{0}\t{1}\t{2}\t{3}"
                                    , Id, Name, Pass, Saves);
        }
    }
}
