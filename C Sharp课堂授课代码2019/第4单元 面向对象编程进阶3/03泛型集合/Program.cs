using System;
using System.Collections.Generic;

namespace _03泛型集合
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Teacher> list = new List<Teacher>();
            list.Add(new Teacher(1, "张三", 10000));
            list.Add(new Teacher(2, "李四", 5000));
            list.Add(new Teacher(3, "王五", 1000));
            foreach (Teacher t in list)
            {
                Console.WriteLine(t);
            }
            list.Sort();//IComparable
            //list.Sort(new Teacher(1, "宋江", 10000));
            //list.Sort(new T());
            foreach (Teacher t in list)
            {
                Console.WriteLine(t);
            }
        }
    }
    public class Teacher : IComparable<Teacher>//IComparer<Teacher>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public Teacher(int id, string name, decimal salary)
        {
            this.Name = name;
            this.Id = id;
            this.Salary = salary;
        }
        public override string ToString()
        {
            return "id:" + this.Id + "\tname:" + this.Name + "\tsalary" + this.Salary;
        }

        public int CompareTo(Teacher other)
        {
            return (int)(this.Salary - other.Salary);
        }
        //public int CompareTo(Teacher other)
        //{
        //    return this.Name.CompareTo(other.Name);
        //}
        
    }
    public class T: IComparer<Teacher>
    {
        public int Compare(Teacher x, Teacher y)
        {
            return x.Salary.CompareTo(y.Salary);
        }
    }
}