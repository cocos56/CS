using System;

namespace _3_3
{
	class MyList
	{
		private Student[] array;
		private int count;

		public MyList(int size)
		{
			if (size >= 0)
			{
				array = new Student[size];
			}
		}

		public MyList()
		{
			array = new Student[0];
		}

		//Capacity属性获取容量大小
		public int Capacity
		{
			get { return array.Length; }
		}

		//Count属性访问元素个数
		public int Count
		{
			get { return count; }
		}

		//Add（）方法添加元素
		public void Add(Student item)
		{
			if (Count == Capacity)
			{
				if (Capacity == 0)
				{
					array = new Student[4];
				}
				else
				{
					var newArray = new Student[Capacity * 2];
					Array.Copy(array, newArray, Count);
					array = newArray;
				}
			}
			array[Count] = item;
			count++;
		}

		//索引器（通过一个Index查找数组中的某个元素）
		public Student GetItem(int Index)
		{
			if (Index >= 0 && Index < Count)
			{
				return array[Index];
			}
			else
			{
				throw new Exception("索引超出范围");
			}
		}

		//[index] 访问元素
		public Student this[int index]
		{
			get
			{
				return GetItem(index);
			}
			set
			{
				if (index >= 0 && index < Count)
				{
					array[index] = value;
				}
				else
				{
					throw new Exception("索引超出范围");
				}
			}
		}

		public Student this[string name]
		{
			get
			{
				int index = IndexOf(name);
				return GetItem(index);
			}
			set
			{
				int index = IndexOf(name);
				if (index >= 0 && index < Count)
				{
					array[index] = value;
				}
				else
				{
					throw new Exception("索引超出范围");
				}
			}
		}

		//Insert（）插入元素
		public void Insert(int index, Student item)
		{
			if (Count == Capacity)
			{
				if (Capacity == 0)
				{
					array = new Student[4];
				}
				else
				{
					var newArray = new Student[Capacity * 2];
					Array.Copy(array, newArray, Count);
					array = newArray;
				}
			}
			for (int j = count - 1; j >= index; j--)
			{
				array[j + 1] = array[j];
			}
			array[index] = item;
			count++;
		}

		//IndexOf（）方法取得一个元素所在列表中的索引位置（从前往后搜索）
		public int IndexOf(Student item)
		{
			for (int i = 0; i < count; i++)
			{
				if(array[i].Equals(item))
				{
					return i;
				}
			}
			return -1;
		}

		public int IndexOf(string name)
		{
			for (int i = 0; i < count; i++)
			{
				if (array[i].Name == name)
				{
					return i;
				}
			}
			return -1;
		}

		//从后往前搜索，搜到满足条件就停止没有找到返回-1
		public int LastIndexOf(Student item)
		{
			for (int i = count - 1; i >= 0; i--)
			{
				if (array[i].Equals(item))
				{
					return i;
				}
			}
			return -1;
		}

		//对列表中的元素进行从小到大的排序
		public void Sort()
		{
			for (int j = 0; j < count - 1; j++)
			{
				for (int i = 0; i < count - 1 - j; i++)
				{
					if (array[i].CompareTo(array[i + 1]) > 0)
					{
						Student temp = array[i];
						array[i] = array[i + 1];
						array[i + 1] = temp;
					}
				}
			}
		}
	}
}