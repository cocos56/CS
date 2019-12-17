using System;

namespace _15DateTimeSpan
{
    class Program
    {
        static void Main(string[] args)
        {
            System.DateTime today = System.DateTime.Now;
            System.TimeSpan duration = TimeSpan.Parse("36.00:00:00");
            System.DateTime answer = today.Add(duration);
            System.Console.WriteLine("{0}  {0:dddd}", answer, answer);
        }
    }
}