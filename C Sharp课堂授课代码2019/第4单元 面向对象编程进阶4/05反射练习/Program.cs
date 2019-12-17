using System;
using System.Reflection;

namespace _05反射练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //NewClass nc = new NewClass();
            //Type t=nc.GetType();
            Type t = typeof(NewClass);
            object o1 = "张三";
            object o2 = 18;
            object o = Activator.CreateInstance(t, o1, o2);
            
            object o3 = Activator.CreateInstance(t);
            MethodInfo mi = t.GetMethod("show");
            mi.Invoke(o, null);

			//object o = Activator.CreateInstance(t,null);
			//PropertyInfo pi1 = t.GetProperty("Age");
			//pi1.SetValue(o, 18, null);
			//PropertyInfo pi2 = t.GetProperty("Name");
			//pi2.SetValue(o,"张三", null);
			//MethodInfo mi = t.GetMethod("show");
			//mi.Invoke(o, null);

			//ConstructorInfo []cis=t.GetConstructors();
			//foreach (ConstructorInfo ci in cis)
			//{

			//    ParameterInfo[] pis = ci.GetParameters();

			//    foreach (ParameterInfo pi in pis)
			//    {
			//        Console.Write(pi.ParameterType.ToString() + " " + pi.Name+" ");
			//    }
			//}

			Console.ReadKey();
        }
    }
    public class NewClass
    {
        public string a;
        public int b;
        public int Name { get; set; }
        public int Age { set; get; }
        public NewClass(string m, int n)
        {
            a = m;
            b = n;
        }
        public NewClass()
        {
            Console.WriteLine("调用无参构造函数");
        }
        public void show()
        {
            Console.WriteLine ("生成一个对象成功"+a+b+this.Name+this.Age);
        }
    }
}