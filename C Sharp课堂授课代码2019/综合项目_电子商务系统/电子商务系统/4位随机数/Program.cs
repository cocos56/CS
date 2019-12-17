using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4位随机数
{
    public class Program
    {
        static void Main(string[] args)
        {            
            //Yzm();
            Console.ReadKey();
        }
        public static string Yzm()
        {
            string s = "abcdefghijklmnopqrstuvwxyz0123456789";
            Random rnd = new Random();
            char[] ch = new char[4];
            for (int i = 0; i < 4; i++)
            {
                ch[i] = s[rnd.Next(s.IndexOf('9'))];
            }
            string str = string.Join("", ch);                     
            Console.WriteLine(str);
            return str;
        }
    }
}
