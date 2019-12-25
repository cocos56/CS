using System;

namespace _07为什么使用委托
{
	public delegate string DelProStr(string name);

	class Program
	{
		static void Main(string[] args)
		{
			//三个需求：
			//1。将一个字符串数组中的每个元素都转换成大写
			//2。将一个字符串数组中的每个元素都转换成小写
			//3.将一个字符串数组中的每个元素都加上双引号
			string[] names = { "ABCdef", "hiJKl", "MnOpQ", "rsT", "UvwXYz" };
			//ProStrToUpper(names);
			//ProStrToLower(names);
			//ProStrToSYH(names);

			//ProStr(names);
			ProStr(names, ProStrToLower);
			//ProStr(names, delegate(string name)
			//{ //有返回值类型，要有return语句
			//	return "\"" + name + "\"";//return name.ToLower(); //return name.ToUpper();
			//});
			for (int i = 0; i < names.Length; i++)
			{
				Console.WriteLine(names[i]);
			}
		}

		public static void ProStr(string[] names,DelProStr del)
		{
			for (int i = 0; i < names.Length; i++)
			{
				names[i] = del(names[i]);
				//names[i] = ProStrToLower(names[i]);
			}
		}
		public static string ProStrToUpper(string name)
		{
			return name.ToUpper();
		}
		public static string ProStrToLower(string name)
		{
			return name.ToLower();
		}
		public static string ProStrToSYH(string name)
		{
			return "\"" + name + "\"";
		}

		//public static void ProStrToUpper(string[] names)
		//{
		//	for (int i = 0; i < names.Length; i++)
		//	{
		//		names[i] = names[i].ToUpper();
		//	}
		//}
		//public static void ProStrToLower(string[] names)
		//{
		//	for (int i = 0; i < names.Length; i++)
		//	{
		//		names[i] = names[i].ToLower();
		//	}
		//}
		//public static void ProStrToSYH(string[] names)
		//{
		//	for (int i = 0; i < names.Length; i++)
		//	{
		//		names[i] = "\"" + names[i] + "\"";
		//	}
		//}
	}
}