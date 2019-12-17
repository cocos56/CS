using System;

//将一个字符串数组中每个元素都转换成大写、小写，每个元素两边都加上双引号。
namespace _4
{
	class Program
	{
		static void Main(string[] args)
		{
			string str = "aBc";
			Console.WriteLine(str);

			Console.WriteLine("\n全转成大写的：");
			string u = str.ToUpper();
			Console.WriteLine(u);

			Console.WriteLine("\n全转成小写的：");
			string l = str.ToLower();
			Console.WriteLine(l);

			Console.WriteLine("\n添加引号：");
			string q = "\""+str +"\"";
			Console.WriteLine(q);

			Console.ReadKey();
		}
	}
}