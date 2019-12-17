using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01继承
{
    class Program
    {
        static void Main(string[] args)
        {
            //new关键字： 1.在内存当中开辟一块存储空间
            //2.在开辟的存储空间中创建对象
            //3.调用对象的构造函数进行初始化对象
            Student s = new Student("张三", 18, '男', 1001);
            s.StudentSayHello();
            Teacher t = new Teacher("老彭", 50, '男', 8000);
            t.Teach();
            Console.ReadKey();
        }
    }
    public class Person
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private int _age;

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }
        private char _gender;

        public char Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }

        private double _weight;
        //protected修饰的属性能被子类继承访问到，但其他类的对象访问不到
        protected double Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }
        public void SayHello()
        {
            Console.WriteLine("Helle,我是人类.");
        }
        public Person(string name, int age, char gender)
        {
            this.Name = name;
            this.Gender = gender;
            this.Age = age;
        }
        //如果定义了带参的构造函数，系统默认提供的无参构造函数就被干掉了，需要显示的（手动的）写出来
        //public Person()
        //{ }
    }
    public class Student : Person
    {
        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        /// <summary>
        /// 1.继承了父类中的属性，父类中的私有字段没有继承过来
        /// 2.父类中的构造函数不能继承到子类当中，但是之类可以调用父类的构造函数
        /// </summary>
        //隐式调用：自动调用了父类的无参构造函数  （方法1）
        public Student(string name, int age, char gender, int id)
            : base(name, age, gender)
        {
            //this.Name = name;name,age,gender
            //this.Age = age;
            //this.Gender = gender;
            this.Id = id;
            //this.Weight
        }
        public void StudentSayHello()
        {
            Console.WriteLine("我是学生,我的学号是{0}", this.Id);
        }


    }
    public class Teacher : Person
    {
        private double _salary;

        public double Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }
        public Teacher(string name, int age, char gender, double salary)
            : base(name, age, gender)
        {
            this.Salary = salary;
        }
        public void Teach()
        {
            Console.WriteLine("教师会上课");
        }
    }
    public class Driver : Person
    {
        private int _driverTime;

        public int DriverTime
        {
            get { return _driverTime; }
            set { _driverTime = value; }
        }
        public Driver(string name, int age, char gender, int driverTime)
            : base(name, age, gender)
        {
            this.DriverTime = driverTime;
        }
        public void Drive()
        {
            Console.WriteLine("驾驶员会开车");
        }

    }
}
