using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagementSystem.View
{
	public class Utils
	{
		public static string Input(string msg)
		{
			Console.WriteLine(msg);
			return Console.ReadLine();
		}
	}
}
