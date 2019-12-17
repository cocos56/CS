using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookManagementSystem.View;
using BookManagementSystem.FrameWork;

namespace BookManagementSystem
{
	class Program
	{
		static void Main(string[] args)
		{
			UIManager ui = new UIManager();
			ui.Open<EnterView>();

			Console.ReadKey();
		}
	}
}
