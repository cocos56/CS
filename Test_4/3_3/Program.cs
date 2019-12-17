using System;

//3. 定义一个集合类（学生类），不仅可以通过下标查找学生，还可以通过姓名查找（设姓名没有重复)

namespace _3_3
{
	class Program
	{
		static void Main(string[] args)
		{
			Student stu = new Student("Coco", 99);

			Student stu2 = new Student("Jone", 90);

			MyList myList = new MyList();
			myList.Add(stu);
			myList.Add(stu2);
			Console.WriteLine("通过下标查找学生：");
			for (int i = 0; i < myList.Count; i++)
			{
				myList[i].hello();
			}

			Console.WriteLine("\n\n通过姓名查找学生：");
			myList["Jone"].hello();
			myList["Coco"].hello();

			Console.ReadKey();
		}
	}
}