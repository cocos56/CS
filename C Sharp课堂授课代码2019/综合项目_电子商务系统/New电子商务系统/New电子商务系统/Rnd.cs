using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New电子商务系统
{
    public class Rnd
    {
        public string Yzm()//验证码函数
        {
            //string s = "abcdefghijklmnopqrstuvwxyz0123456789";
            //Random rnd = new Random();
            //char[] ch = new char[4];
            //for (int i = 0; i < 4; i++)
            //{
            //    ch[i] = s[rnd.Next(s.IndexOf('9'))];
            //}
            //string str = string.Join("", ch);

            //string str = "abcdefghijklmnopqrstuvwxyz0123456789";
            string str = "";
            Random r = new Random();
            char c1 = str[r.Next(str.Length)];
            char c2 = str[r.Next(str.Length)];
            char c3 = str[r.Next(str.Length)];
            char c4 = str[r.Next(str.Length)];
            str = c1 + "" + c2 + "" + c3 + "" + c4;
            return str;
        }
    }
}
