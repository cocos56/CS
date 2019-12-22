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
        /// <summary>
        /// 将输入的字符串转化成Int类型的值
        /// </summary>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static int InputInt(string msg)
        {
            return int.Parse(Input(msg));
        }
    }
}
