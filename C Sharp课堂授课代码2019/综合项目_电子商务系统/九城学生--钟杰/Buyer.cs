using System;

namespace mostone
{
    public class Buyer : User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Pass { get; set; }
        public double Saves { get; set; }

        public Buyer() { 
        }

        public Buyer(int id)
        {
            Id = id;
        }

        public Buyer(int id, string name, string pass, double saves) {
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
