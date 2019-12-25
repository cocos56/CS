using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _15Event事件
{
	class Program
	{
		static void Main(string[] args)
		{
			Bridegroom bridegroom = new Bridegroom();
			Friend friend1 = new Friend("张三");
			Friend friend2 = new Friend("李四");
			Friend friend3 = new Friend("王五");
			//订阅事件
			bridegroom.MarryEvent +=
				new Bridegroom.MarryHandler(friend1.SendMessage);
			bridegroom.MarryEvent += 
				new Bridegroom.MarryHandler(friend2.SendMessage);
			//触发事件 事件的调用只能在定义事件的内部调用
			bridegroom.onMarriageComing("朋友们，结婚了");

		}
	}
}
