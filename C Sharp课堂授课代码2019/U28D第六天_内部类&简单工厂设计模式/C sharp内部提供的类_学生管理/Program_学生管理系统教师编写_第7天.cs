using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace 学生管理系统
{
    class Program
    {
        public static int num=1;
        public static StudentManage manage = new StudentManage();
        static void Main(string[] args)
        {
            Console.WriteLine("welcome~");
            while (true)
            {
                Console.WriteLine("请输入您需要的操作，1添加，2修改，3查看，4删除");
                string s = Console.ReadLine();
                if (s == "1")
                {
                    Add();
                }
                else if (s == "2")
                {
                    Update();
                }
                else if (s == "3")
                {
                    Show();
                }
                else if (s == "4")
                {
                    Delete();
                }
                else
                {
                    return;
                }
            }
            
            
        }
        public static void Add()
        {
            // zhangsan,1,90
            Console.WriteLine("请输入学生的名字,班级,分数");
            string s = Console.ReadLine();
            string[] ss = s.Split(',');
            Student stu = new Student();
            stu.Id = num;
            stu.Name = ss[0];
            stu.Grade = Convert.ToInt32(ss[1]);
            stu.Score = Convert.ToDouble(ss[2]);
            num++;
            manage.AddStudent(stu);
        }
        public static void Update()
        {
            Console.WriteLine("请输入需要修改学生的编号及修改内容");
            string s = Console.ReadLine();
            string[] ss = s.Split(',');
            int n = Convert.ToInt32(ss[0]);
            string name = ss[1];
            manage.UpdateStudent(n,name);
            Console.WriteLine("修改成功");
        }
        public static void Delete()
        {
            Console.WriteLine("请输入您需要删除的编号");
            string s = Console.ReadLine();
            int n = Convert.ToInt32(s);
            manage.DeleteStudnetById(n);
            Console.WriteLine("删除成功！");
        }
        public static void Show()
        {
            Console.WriteLine("下面是所有学生信息");
            manage.Show();
        }
    }
    public class Student:IComparer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Grade { get; set; }
        public double Score { get; set; }
        // 
        public int Compare(object x, object y)
        {
            // 
            return 1;
       }
    }
    public class StudentManage
    {
        public ArrayList list = new ArrayList();// student
        public Student FindStudentById(int id)
        {//遍历整个集合，取出每个student的id 然后进行比对
            Student s = null;
            for (int i = 0; i < list.Count; i++)
            {
                Student s2 =(Student) list[i];
                if (s2.Id ==id)
                {
                    s = s2;
                }
            }
            return s;
        }
        public bool DeleteStudnetById(int id)
        {
            bool b = false;
            for (int i = 0; i < list.Count; i++)
            {
                Student s2 = (Student)list[i];
                if (s2.Id == id)
                {
                   
                    //list.Remove(s2);
                    list.RemoveAt(i);
                     b = true;
                }
            }
            return b;
        }

        public void UpdateStudent(int id,string name)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Student s2 = (Student)list[i];
                if (s2.Id == id)
                {

                    //list.Remove(s2);
                    s2.Name = name;
                }
            }
        }

        public void AddStudent(Student s)
        {
            list.Add(s);
        }

        public void Show()
        {
            for (int i = 0; i < list.Count; i++)
            {
                Student s =(Student) list[i];
                Console.WriteLine(s.Id+"\t,name:"+s.Name+"\t,grade:"+s.Grade+"\t,score:"+s.Score);
            }
        }
    }
}
