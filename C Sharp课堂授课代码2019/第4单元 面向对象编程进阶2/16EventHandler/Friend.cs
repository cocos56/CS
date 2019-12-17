using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _16EventHandler
{
    public class Friend
    {
        public string Name;
        public Friend(string name)
        {
            Name = name;
        }
        //事件处理函数
        //事件处理函数的定义需要与触发事件时所需参数保持一致
        public void SendMessage(object s, EventArgs e)
        {
            //不包含事件数据
            //处理事件
            Console.WriteLine(this.Name + "收到了，到时准时参加！");
        }

    }
}
