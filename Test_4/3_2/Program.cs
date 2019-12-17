using System;
using System.Collections;

//2. 写一个长度为10的集合，要求在里面随机地存放10个数字，并在控制台上显示输出这10个数字。（提示：用到Random随机数类中的Next方法，首先创建随机数对象，然后调用Next方法）。 

namespace _3_2
{
	class Program
	{
		static void Main(string[] args)
		{
			Random r = new Random();
			int cnt = 0;
			ArrayList al = new ArrayList();
			while (cnt<10)
			{
				cnt += 1;
				al.Add(r.Next());
			}
			foreach (var i in al)
			{
				Console.WriteLine(i);
			}
			Console.ReadKey();
		}
	}
}