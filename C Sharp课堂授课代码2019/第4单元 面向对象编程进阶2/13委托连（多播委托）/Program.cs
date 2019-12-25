using System;

namespace _13委托连_多播委托_
{
	public delegate void DelTest();

	class Program
	{
		static void Main(string[] args)
		{
			DelTest del = Test1;
			del += Test2;
			del += Test3;
			del += Test4;
			//del = Test4;
			del -= Test2;
			del -= Test3;
			del();
		}
		public static void Test1()
		{
			Console.WriteLine("我是Test1");
		}
		public static void Test4()
		{
			Console.WriteLine("我是Test4");
		}
		public static void Test2()
		{
			Console.WriteLine("我是Test2");
		}
		public static void Test3()
		{
			Console.WriteLine("我是Test3");
		}
	}
}