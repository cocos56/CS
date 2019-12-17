using System;
using System.Reflection;

//一个简单的类，包含一个有参数的构造器，一个GetValue的方法，一个Value属性，运用反射知识通过方法的名称来得到方法并且调用之。
namespace _5
{
	class Program
	{
		static void Main(string[] args)
		{
			Type t = typeof(SimpleClass);
			object o = Activator.CreateInstance(t, "test");
			MethodInfo mi = t.GetMethod("getValue");
			mi.Invoke(o, null);

			Console.ReadKey();
		}

		public class SimpleClass
		{
			public string Value;

			public SimpleClass(string v)
			{
				Value = v;
				Console.WriteLine("正在初始化对象，已为Value成功赋值。");
			}
			public void getValue()
			{
				Console.WriteLine("Value=" + Value);
			}
		}
	}
}