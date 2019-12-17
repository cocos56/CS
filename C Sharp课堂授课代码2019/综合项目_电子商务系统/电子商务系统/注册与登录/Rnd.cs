using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 电子商务系统
{
    public class Rnd
    {

        public string Yzm()//验证码函数
        {
            string s = "abcdefghijklmnopqrstuvwxyz0123456789";
            Random rnd = new Random();
            char[] ch = new char[4];
            for (int i = 0; i < 4; i++)
            {
                ch[i] = s[rnd.Next(s.IndexOf('9'))];
            }
            string str = string.Join("", ch);
            return str;
        }
    }
}
