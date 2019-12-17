using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05构造函数复习
{
    public class Time
    {
        public int Hour { set; get; }
        public int Minute { set; get; }
        public int Second { set; get; }
        public Time(int hour, int minute, int second)
        {
            this.Hour = hour;
            this.Minute = minute;
            this.Second = second;
        }
        public Time(int seconds)
        {
            this.Hour = seconds / 3600;
            this.Minute = seconds % 3600 / 60;
            this.Second = seconds % 60;
        }
    }
}
