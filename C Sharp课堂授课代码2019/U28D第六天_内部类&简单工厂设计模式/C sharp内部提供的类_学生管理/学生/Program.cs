using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 学生
{
    class Program
    {
        static void Main(string[] args)
        {         
            StudentManger sm = new StudentManger("admin", "123456");
            sm.AddStudent(new Student(1001, "zhang san", 85));
            sm.AddStudent(new Student(1002, "li si", 95));
            sm.AddStudent(new Student(1003, "lao si", 75));
            sm.AddStudent(new Student(1004, "zhao wu", 65));
            sm.AddStudent(new Student(1005, "lao wang", 93));
            Student s = sm.FindStudentById(1003);           
            Console.WriteLine("该生的学号是{0},姓名是{1},分数是{2}", s.Id, s.Name, s.Grade);
            sm.UpdateStudent(1003, "lao peng");
            Student s1 = sm.FindStudentById(1003);
            Console.WriteLine("该生的学号是{0},姓名是{1},分数是{2}", s1.Id, s1.Name, s1.Grade);
           bool b=sm.DeleteStudentById(1004);
           Console.WriteLine(b);

           
            Student[] ss = new Student[sm.list.Count];
           for (int i = 0; i < sm.list.Count; i++)
           {
               ss[i] = (Student)sm.list[i];
           }
           for (int i = 0; i < ss.Length; i++)
           {
               Console.WriteLine(ss[i].Id);               
           }

           sm.SortStudent();

           Console.ReadKey(); 
        }
    }
    public class Student//:IComparer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Grade { get; set; }
        public Student(int id,string name,double grade)
        {
            this.Id = id;
            this.Name = name;
            this.Grade = grade;
        }

        //public int Compare(object x,object y)
        //{
            
        //    return -1;
        //}
    }
    public class StudentManger
    {
        public string Name{get;set;}
        public string Pwd{get;set;}
        public StudentManger(string name,string pwd)
        {
            this.Name = name;
            this.Pwd = pwd;
        }
        public  ArrayList list = new ArrayList();//student
       
        public Student FindStudentById(int id)
        {
            //遍历整个集合，取出每个student的id 然后进行比对
            Student s = null;
            for (int i = 0; i < list.Count; i++)
            {
                //object o = list[i];
               Student s2=(Student)list[i];
                if(s2.Id==id)
                {
                    s = s2;
                    //Console.WriteLine("该生的学号是{0},姓名是{1},分数是{2}",s.Id,s.Name,s.Grade);
                }

            }
            return s;
        }
        public bool DeleteStudentById(int id)
        {
            bool b = false;
            for (int i = 0; i < list.Count; i++)
            {              
                Student s2 = (Student)list[i];
                if(s2.Id==id)
                {
                    //list.RemoveAt(i);                  
                    list.Remove(s2);
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
                    s2.Name = name;             
                }
            }

        }
        public  void AddStudent(Student s)
        {
            list.Add(s);
        }
        public void SortStudent()
        {
            Student[]s=new Student[list.Count];          
            for (int i = 0; i < list.Count; i++)
            {              
                s[i] = (Student)list[i];
            }
            for (int i = 0; i < s.Length - 1; i++)
            {
                for (int j = 0; j < s.Length - i - 1; j++)
                {
                    if(s[j].Grade>s[j+1].Grade)
                    {
                        Student temp = s[j];
                        s[j] = s[j + 1];
                        s[j + 1] = temp;
                    }
                }                
            }
            for (int i = 0; i < s.Length; i++)
            {
                Console.WriteLine("学号：{0}\t姓名：{1}\t分数：{2}", s[i].Id, s[i].Name, s[i].Grade);
            }           
        }
    }
}
