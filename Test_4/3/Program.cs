using System;
using System.Collections;

//1. 创建一个集合，里面添加一些数字，求平均值与和，最大值，最小值，并在控制台显示输出结果。

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
			//创建一个集合
			ArrayList list = new ArrayList();
			//向集合添加一些数字
			list.AddRange(new int[] { 1, 8, 7, 4, 5, 6, 3, 2, 9 });
			//新建sum变量来存储和
			int sum = 0;
			//新建一个max来存储最大值
			int max = (int)list[0];
			//新建一个min来存储最小值
			int min = (int)list[1];

			//通过一个循环来赋值
			for (int i = 0; i < list.Count; i++)
			{
				//list[i]是object类型，通过里氏转换法强转成int类型
				if ((int)list[i] > max)
				{
					max = (int)list[i];
				}
				if ((int)list[i] < min)
				{
					min = (int)list[i];
				}
				sum += (int)list[i];
			}
			//分别输出max,min,sum和avg
			Console.WriteLine("max="+max);
			Console.WriteLine("min=" + min);
			Console.WriteLine("sum=" + sum);
			Console.WriteLine("avg=" + sum / list.Count);
			Console.ReadKey();
		}
    }
}