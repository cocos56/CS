using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace _06反射调用成员
{
    class Program
    {
        static void Main(string[] args)
        {
            Type typePerson= typeof(Person);
            //实例化对象
            object o=Activator.CreateInstance(typePerson);
            //给属性赋值
            PropertyInfo propName=typePerson.GetProperty("Name");
            propName.SetValue(o, "二狗子", null);
//获得Person类的Age属性的描述
            PropertyInfo propAge = typePerson.GetProperty("Age");
//第一个参数为要为哪个对象的Age属性赋值
            propAge.SetValue(o, 15, null);

            MethodInfo mi=typePerson.GetMethod("SayHello");
            mi.Invoke(o, null);
        }
    }
    class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public void SayHello()
        {
            Console.WriteLine("我叫{0},我今年{1}岁了", this.Name, this.Age);
        }
    }
}
