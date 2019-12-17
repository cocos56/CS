using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 学生
{
    class Program
    {
        public static int num = 1;//计数器 每添加一名学生Id增加1
        public static StudentManger manage = new StudentManger();
        static void Main(string[] args)
        {
            Console.WriteLine("welcome~");           
            while(true)
            {
                Console.WriteLine("请输入你需要的操作 1---增加  2---修改  3---显示  4---删除  5---排序");
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
                else if (s=="5")
                {
                    Sort();
                }
                else
                {
                    return;
                }
            }




        }
       public static void Sort()
        {
            manage.SortStudent();
            Console.WriteLine("排序成功");
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
            stu.Grade=Convert.ToInt32(ss[1]);
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
            manage.UpdateStudent(n, name);
            Console.WriteLine("修改成功");
        }
        public static void Delete()
        {
            Console.WriteLine("请输入你要删除的编号");
            string s = Console.ReadLine();
            int n = Convert.ToInt32(s);
            manage.DeleteStudentById(n);
            Console.WriteLine("删除成功！");
        }
        public static void Show()
        {
            Console.WriteLine("下面是所有学生信息");
            manage.Show();
        }   
     


    }
    //public class Student//选择器实现的排序
    public class Student : IComparable<Student>//IComparable接口实现排序
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Grade { get; set; }
        public double Score { get; set; }
        
        //此处发生了多态--在Student类中重写了ToString()
        public override string ToString()
        {
           // return "$$$$$$$$";
            return this.Id + "\tname:" + this.Name + "\tgrade:" + this.Grade + "\tscore:" + this.Score;
        }
        public Student()
        {

        }

        public int CompareTo(Student obj)//IComparable接口实现排序
        {

            return this.Name.CompareTo(obj.Name);
        }
    }

    //public class T:IComparer<Student>//选择器实现的排序
    //{
    //     public int Compare(Student x, Student y)
    //    {

    //        return x.Name.CompareTo(y.Name);
    //    }

    //}

    public class StudentManger
    {
        //public ArrayList list = new ArrayList();//情况1：普通集合实现
        public List<Student> list= new List<Student>();
        public Student FindStudentById(int id)
        {
            //遍历整个集合，取出每个student的id 然后进行比对
            Student s = null;
            for (int i = 0; i < list.Count; i++)
            {
                // Student s2 = (Student)list[i];//情况1：普通集合实现
                 Student s2 = list[i];
                if (s2.Id == id)
                {
                    s = s2;                   
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
                if (s2.Id == id)
                {
                    //list.RemoveAt(i);                  
                    list.Remove(s2);
                    b = true;
                }
            }
            return b;
        }
        public void UpdateStudent(int id, string name)
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
        public void AddStudent(Student s)
        {
            list.Add(s);
        }

       public void SortStudent()
        {
            //list.Sort(new T());//IComparer<Student> 使用了选择器进行的排序
            list.Sort();//IComparable接口实现排序
        }

        public void Show()
        {
            for (int i = 0; i < list.Count; i++)
            {
                //ToString  当我们需要打印一个对象的时候
                //Student s = (Student)list[i];
                Console.WriteLine(list[i]);//此处如果不重写ToString()方法，运行结果为“命名空间.类名(学生.Student)”  此处发生了多态--在Student类中重写了ToString()
                // Console.WriteLine(list[i].ToString());//运行结果表明 此处自动调用了ToString()方法
               // Console.WriteLine(s.Id + "\t,name:" + s.Name + "\t,grade:" + s.Grade + "\t,score:" + s.Score);
            }
        }
        //public void SortStudent()
        //{
        //    Student[] s = new Student[list.Count];
        //    for (int i = 0; i < list.Count; i++)
        //    {
        //        s[i] = (Student)list[i];
        //    }
        //    for (int i = 0; i < s.Length - 1; i++)
        //    {
        //        for (int j = 0; j < s.Length - i - 1; j++)
        //        {
        //            if (s[j].Grade > s[j + 1].Grade)
        //            {
        //                Student temp = s[j];
        //                s[j] = s[j + 1];
        //                s[j + 1] = temp;
        //            }
        //        }
        //    }
        //    for (int i = 0; i < s.Length; i++)
        //    {
        //        Console.WriteLine("学号：{0}\t姓名：{1}\t分数：{2}", s[i].Id, s[i].Name, s[i].Grade);
        //    }
        //}
        
    }
}
