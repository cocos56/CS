using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_3多态练习
{
    public class People
    {
        //public void ToEat(Fire f)//永远写不完
        //{

        //}
        //public void ToEat(Potato p)
        //{

        //}

        //f=new HotDog();
        public void ToEat(Food f)
        {
            f.Eated();
        }

    }
}
