using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using 封闭的类库;
using System.Reflection;
namespace _04调用封闭的类库
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("zhangsan",18);
            p.Haha();
            Type t=p.GetType();
            //NonPublic--private
            //Instance--实例
            MethodInfo mi=t.GetMethod("Heihei",BindingFlags.NonPublic|BindingFlags.Instance);
            mi.Invoke(p, null);

        }
    }
}
