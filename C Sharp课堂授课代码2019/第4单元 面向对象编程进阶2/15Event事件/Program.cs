using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _15Event�¼�
{
	class Program
	{
		static void Main(string[] args)
		{
			Bridegroom bridegroom = new Bridegroom();
			Friend friend1 = new Friend("����");
			Friend friend2 = new Friend("����");
			Friend friend3 = new Friend("����");
			//�����¼�
			bridegroom.MarryEvent +=
				new Bridegroom.MarryHandler(friend1.SendMessage);
			bridegroom.MarryEvent += 
				new Bridegroom.MarryHandler(friend2.SendMessage);
			//�����¼� �¼��ĵ���ֻ���ڶ����¼����ڲ�����
			bridegroom.onMarriageComing("�����ǣ������");

		}
	}
}
