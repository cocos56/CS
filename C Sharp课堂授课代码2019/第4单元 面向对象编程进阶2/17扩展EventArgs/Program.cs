using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _17扩展EventArgs
{
    class Program
    {
        static void Main(string[] args)
        {
            Bridegroom bridegroom = new Bridegroom();
            Friend friend1 = new Friend("张三");
            Friend friend2 = new Friend("李四");
            Friend friend3 = new Friend("王五");
            bridegroom.MarryEvent += new Bridegroom.MarryHandler(friend1.SendMessage);
            bridegroom.MarryEvent += new Bridegroom.MarryHandler(friend2.SendMessage);
            bridegroom.onMarriageComing("朋友们，结婚了！");
            bridegroom.MarryEvent -= new Bridegroom.MarryHandler(friend1.SendMessage);
            bridegroom.onMarriageComing("朋友们，离了！");
        }
    }

    public class MarryEventArgs : EventArgs
    {
        public string Message;
        public MarryEventArgs(string msg)
        {
            Message = msg;
        }
    }
    public class Bridegroom
    {
        public delegate void MarryHandler(object
        sender, MarryEventArgs e);
        //使用EventHandler定义事件，事件名为MarryEvent
        public event MarryHandler MarryEvent;
        public void onMarriageComing(string msg)
        {
            if (MarryEvent != null)
            {
                //触发事件
                MarryEvent(this, new MarryEventArgs(msg));
            }
        }
    }

    public class Friend
    {
        public string Name;
        public Friend(string name)
        {
            Name = name;
        }
        //事件处理函数
        public void SendMessage(object s, MarryEventArgs e)
        {
            Console.WriteLine(e.Message);
            //处理事件
            Console.WriteLine(this.Name + "收到了，到时候准时参加");
        }
    }

}
