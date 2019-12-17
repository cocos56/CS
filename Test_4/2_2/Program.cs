using System;
using System.Collections.Generic;
//在一个程序中，既想实现按年龄排序，又想实现按姓名排序，还要实现按人气值排序，怎么办？


namespace _2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Teacher> list = new List<Teacher>();
            list.Add(new Teacher(1, "张三", 10000, 100));
            list.Add(new Teacher(2, "张三", 10000, 101));
            list.Add(new Teacher(3, "宋江", 10000, 101));
            list.Add(new Teacher(4, "李四", 5000, 102));
            list.Add(new Teacher(5, "王五", 1000, 103));
            foreach (Teacher t in list)
                Console.WriteLine(t);

            Console.WriteLine("排序后：");
            list.Sort();//IComparable
            foreach (Teacher t in list)
                Console.WriteLine(t);

            Console.ReadKey();
        }
    }
    public class Teacher : IComparable<Teacher>
    {
        public int Id;
        public string Name;
        public decimal Salary;
        public int PopularityValues;

        public Teacher(int id, string name, decimal salary, int popularityValues)
        {
            this.Name = name;
            this.Id = id;
            this.Salary = salary;
            this.PopularityValues = popularityValues;
        }
        public override string ToString()
        {
            return "id:" + this.Id + "\tname:" + this.Name + "\tsalary:" + this.Salary + "\tpopularityValues:" + this.PopularityValues;
        }
        public int CompareTo(Teacher other)
        {
            if (this.Salary == other.Salary)
            {
                if (this.Name == other.Name)
                    return (int)(this.PopularityValues - other.PopularityValues);
                return this.Name.CompareTo(other.Name);
            }
            return (int)(this.Salary - other.Salary);
        }
    }
}