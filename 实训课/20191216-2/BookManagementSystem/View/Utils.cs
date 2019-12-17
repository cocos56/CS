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
    }
}