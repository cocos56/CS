using System;

namespace _04飞行棋游戏
{
	class View
	{
		/// <summary>
		/// 本类采用单例模式设计，获取单例请调用getInstance接口
		/// </summary>
		private View	(){}

		static private View ins = new View();

		static public View getInstance(){ return ins; }

        /// <summary>
        /// 启动游戏后显示游戏信息
        /// </summary>
        public void GameShow()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("**************************");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("**************************");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("**********飞行棋**********");
            Console.ForegroundColor = ConsoleColor.Blue;
            //Console.WriteLine("**********飞行棋**********");
            Console.WriteLine("**************************");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("**************************");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("*****171530427 王玮娟*****\n\n");
        }

        public void Win()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("                                          ◆                      ");
            Console.WriteLine("                    ■                  ◆               ■        ■");
            Console.WriteLine("      ■■■■  ■  ■                ◆■         ■    ■        ■");
            Console.WriteLine("      ■    ■  ■  ■              ◆  ■         ■    ■        ■");
            Console.WriteLine("      ■    ■ ■■■■■■       ■■■■■■■   ■    ■        ■");
            Console.WriteLine("      ■■■■ ■   ■                ●■●       ■    ■        ■");
            Console.WriteLine("      ■    ■      ■               ● ■ ●      ■    ■        ■");
            Console.WriteLine("      ■    ■ ■■■■■■         ●  ■  ●     ■    ■        ■");
            Console.WriteLine("      ■■■■      ■             ●   ■   ■    ■    ■        ■");
            Console.WriteLine("      ■    ■      ■            ■    ■         ■    ■        ■");
            Console.WriteLine("      ■    ■      ■                  ■               ■        ■ ");
            Console.WriteLine("     ■     ■      ■                  ■           ●  ■          ");
            Console.WriteLine("    ■    ■■ ■■■■■■             ■              ●         ●");
            Console.ResetColor();
        }


    }
}
