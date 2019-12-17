using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03里氏转换
{
    class Program
    {
        static void Main(string[] args)
        {
            //里氏转换：1)子类可以赋值给父类：如果有一个地方需要父类作为参数，我们可以给一个子类来代替
            //string str = string.Join("|", '1', '2', '3', '4');
            //Console.WriteLine(str);
            Student s = new Student();
            Person p = new Student();
            //Student ss = (Student)p;  有风险

            //2)如果父类中装的是子类对象，那么可以将这个父类转换为子类对象

            //3)子类对象可以调用父类中的成员，但是父类对象永远只能调用自己的成员

            ////is用法：表示类型转换 转换成功返回True，否则False

            ////强制类型转换 由大类型转换为小类型 有风险
            //if (p is Student)
            //{
            //    Student ss = (Student)p;
            //    ss.StudentSayHello();
            //}
            //else
            //{
            //    Console.WriteLine("转换失败");
            //}

            //as用法 表示类型转化 转换成功返回对应的对象 否则返回一个null
            Student t = p as Student;
            t.StudentSayHello();
            Console.ReadKey();

        }
    }
    public class Person
    {
        public void PersonSayHello()
        {
            Console.WriteLine("我是人类");
        }
    }
    public class Student : Person
    {
        public void StudentSayHello()
        {
            Console.WriteLine("我是学生");
        }
    }
    public class Teacher : Person
    {
        public void TeacherSayHello()
        {
            Console.WriteLine("我是老师");
        }

    }
}
