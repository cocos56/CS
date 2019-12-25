using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _15Event事件
{
	public class Friend
	{
		public string Name;
		public Friend(string name)
		{
			Name = name;
		}
		//事件处理函数
		//事件处理函数的定义需要与自定义委托的定义保持一致
		public void SendMessage(string mess)
		{
			Console.WriteLine(mess);
			//处理事件
			Console.WriteLine(this.Name + "收到了，到时候准时参加");
		}

	}
}
