using System;

namespace _10求数组的最大值
{
	public delegate int DelCompare(object o1, object o2);
	class Program
	{
		static void Main(string[] args)
		{
			//object[] o = { 1, 2, 3, 4, 5, 6 };
			//object result = GetMax(o);

			//string[] names = { "afdsadf", "sdfs", "rgtrjjrwqeewer", "sdjgkl", ",mdhgkfh" };
			//string result = GetMax(names);
			object[] o = { "afdsadf", "sdfs", "rgtrjjrwqeewer", "sdjgkl", ",mdhgkfh" };
			//object result = GetMax(o, comare1);

			object result = GetMax(o, delegate(object o1, object o2)
			{
				string s1 = (string)o1;
				string s2 = (string)o2;
				return s1.Length - s2.Length;
			});
			Console.WriteLine(result);
		}

		public static object GetMax(object[] names,DelCompare del)
		{
			object max = names[0];
			for (int i = 0; i < names.Length; i++)
			{
				if (del(max,names[i])<0)
				{
					max = names[i];
				}
			}
			return max;
		}
		//public static int comare1(object o1,object o2)
		//{
		//	int n1=(int)o1;
		//	int n2 = (int)o2;
		//	return n1-n2;
		//}
		//public static int comare2(object o1, object o2)
		//{
		//	string s1 = (string)o1;
		//	string s2 = (string)o2;
		//	return s1.Length-s2.Length;
		//}

		//public static int GetMax(int[]nums)
		//{
		//	int max = nums[0];
		//	for (int i = 0; i < nums.Length; i++)
		//	{
		//		if (max<nums[i])
		//		{
		//			max = nums[i];
		//		}
		//	}
			
		//	return max;
		//}
		//public static string GetMax(string[] names)
		//{
		//	string max = names[0];
		//	for (int i = 0; i < names.Length; i++)
		//	{
		//		if (max.Length < names[i].Length)
		//		{
		//			max = names[i];
		//		}
		//	}

		//	return max;
		//}
	}
}