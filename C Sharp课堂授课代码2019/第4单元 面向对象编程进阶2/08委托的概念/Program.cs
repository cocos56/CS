using System;

namespace _08委托的概念
{
	//委托：将一个方法作为参数传递给另一个方法
	//声明委托类型：委托所指向的函数必须跟委托具有相同的签名（函数的返回值和参数）
	public delegate void DelSayHi(string name);
	class Program
	{
		static void Main(string[] args)
		{
			//SayHiChinese("张三");
			//SayHiEnglish("Jack");
			//DelSayHi del = SayHiEnglish;//new DelSayHi(SayHiEnglish);
			//del("张三");
			Test("张三", SayHiEnglish);

		}
		public static void Test(string name,DelSayHi del)
		{
			del(name);
		}
		public static void SayHiChinese(string name)
		{
			Console.WriteLine("吃了么" + name);
		}
		public static void SayHiEnglish(string name)
		{
			Console.WriteLine("Nice to meet you!" + name);
		}
	}
}