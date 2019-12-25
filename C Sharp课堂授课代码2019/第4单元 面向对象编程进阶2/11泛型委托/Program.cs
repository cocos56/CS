using System;

namespace _11泛型委托
{
	public delegate int DelCompare<T>(T t1, T t2);
	class Program
	{
		static void Main(string[] args)
		{
			//int[] nums = new int[] { 2,8,1,16,24};
			//int result=GetMax<int>(nums, Compare);

			 string[] names = { "afdsadf", "sdfs", "rgtrjjrwqeewer", "sdjgkl", ",mdhgkfh" };
			 string result = GetMax<string>(names, (string s1, string s2)=>
			{
				return s1.Length - s2.Length;
			});
			Console.WriteLine(result);
		}
		public static T GetMax<T>(T[] names, DelCompare<T> del)
		{
			T max = names[0];
			for (int i = 0; i < names.Length; i++)
			{
				if (del(max, names[i]) < 0)
				{
					max = names[i];
				}

			}
			return max;
		}
		public static int Compare(int n1, int n2)
		{
			return n1 - n2;
		}
	}
}