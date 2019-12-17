using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04静态方法和非静态方法
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.M1();//实例方法
            Person.M2();//静态方法
        }
    }
}
