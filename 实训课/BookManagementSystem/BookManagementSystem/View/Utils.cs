using System;

namespace BookManagementSystem.View
{
	public class Utils
	{
		public static string Input(string msg)
		{
			Console.WriteLine(msg);
			return Console.ReadLine();
		}

		public static void Error(string error)
		{
			Console.WriteLine("**************错误提示**************");
			Console.WriteLine(error);
		}

		public static void Continue(System.Action action)
		{
			Console.WriteLine("\n**************按任意键以继续******");
			Console.ReadKey();
			Console.Clear();

			action.Invoke();
		}

		/// <summary>
		/// 将输入的字符串转化成Int类型的值
		/// </summary>
		/// <param name="msg"></param>
		/// <returns></returns>
		public static int InputInt(string msg){ return int.Parse(Input(msg)); }
	}
}