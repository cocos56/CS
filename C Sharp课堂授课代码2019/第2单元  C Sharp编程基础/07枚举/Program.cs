using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07枚举
{
    //[public] enum 枚举名
    //{
    //   值1,
    //    值2,
    //    值3,
    //    ....
    //}
    public enum Gender
    {
        男,
        女
    }

    public enum QQState
    {
        OnLine = 5,
        OffLine,
        Leave,
        Busy
    }
    class Program
    {
        static void Main(string[] args)
        {
            Gender gender = Gender.男;
            //QQState state = QQState.OffLine;
            //int num=(int)state;
            //Console.WriteLine(num);

            //Console.WriteLine((int)QQState.OffLine);

            //枚举到字符串的转换
            //QQState state = QQState.OffLine;
            //string s = state.ToString();

            //字符串到枚举的转换
            string s = "Leave123";
            QQState state = (QQState)Enum.Parse(typeof(QQState), s);

            Console.WriteLine(state);
            Console.ReadKey();

        }
    }

}
