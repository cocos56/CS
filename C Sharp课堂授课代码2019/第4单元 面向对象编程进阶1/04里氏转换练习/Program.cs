using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04里氏转换练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建10个对象 通过一个循环 去调用他们各自打招呼的方法
            //Student s = new Student();
            //s.StudentSayHello();

            Person[] pers = new Person[10];
            Random r = new Random();
            for (int i = 0; i < pers.Length; i++)
            {
                int rNumber = r.Next(1, 7);
                switch (rNumber)
                {
                    case 1: pers[i] = new Student();
                        break;
                    case 2: pers[i] = new Teacher();
                        break;
                    case 3: pers[i] = new Driver();
                        break;
                    case 4: pers[i] = new MeiNv();
                        break;
                    case 5: pers[i] = new YeShou();
                        break;
                    case 6: pers[i] = new Person();
                        break;
                    default: break;
                }
            }

            for (int i = 0; i < pers.Length; i++)
            {
                if (pers[i] is Student)
                {
                    ((Student)pers[i]).StudentSayHello();
                }
                else if (pers[i] is Teacher)
                {
                    ((Teacher)pers[i]).TeacherSayHello();
                }
                else if (pers[i] is MeiNv)
                {
                    ((MeiNv)pers[i]).MeiNvSayHello();
                }
                else if (pers[i] is YeShou)
                {
                    ((YeShou)pers[i]).YeShouSayHello();
                }
                else
                {
                    pers[i].PersonSayHello();
                }
            }
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
    public class Driver : Person
    {
        public void DriverSayHello()
        {
            Console.WriteLine("我是老司机");
        }
    }
    public class MeiNv : Person
    {
        public void MeiNvSayHello()
        {
            Console.WriteLine("我是美女");
        }
    }
    public class YeShou : Person
    {
        public void YeShouSayHello()
        {
            Console.WriteLine("我是野兽");
        }
    }
}
