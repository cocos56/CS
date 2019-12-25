using System;

namespace _16EventHandler
{
	class Program
	{
		static void Main(string[] args)
		{
			Bridegroom bridegroom = new Bridegroom();
			Friend friend1 = new Friend("张三");
			Friend friend2 = new Friend("李四");
			Friend friend3 = new Friend("王五");
			bridegroom.MarryEvent += new EventHandler(friend1.SendMessage);
			bridegroom.MarryEvent += new EventHandler(friend2.SendMessage);
			bridegroom.onMarriageComing("朋友们，结婚了！");
			bridegroom.MarryEvent -= new EventHandler(friend1.SendMessage);
			bridegroom.onMarriageComing("朋友们，离了！");

		}
	}
}