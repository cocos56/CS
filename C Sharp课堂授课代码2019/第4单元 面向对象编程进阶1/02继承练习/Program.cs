using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02继承练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //记者：我叫记者，我的爱好是偷拍 我的年龄是** 我是一个男狗仔
            //司机：我是老司机，我的年龄是** 我是男人 我的驾龄是23年
            //程序员：我叫程序猿，我的年龄是23 我是男生 我的工作年限是3年
            Driver d = new Driver("刘鹏飞", 50, '男', 23);
            d.DriverSayHello();
            Reporter rep = new Reporter("记者", 23, '男', "偷拍");
            rep.ReporterSayHello();

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
            public Person(string name, int age, char gender)
            {
                this.Name = name;
                this.Gender = gender;
                this.Age = age;
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
            public void DriverSayHello()
            {
                //我是老司机，我的年龄是** 我是男人 我的驾龄是23年
                Console.WriteLine("我是{0},我的年龄是{1}岁,我是{2}人，我的驾龄是{3}年", this.Name, this.Age, this.Gender, this.DriverTime);
            }
        }
        public class Reporter : Person
        {
            private string _hobby;

            public string Hobby
            {
                get { return _hobby; }
                set { _hobby = value; }
            }
            public Reporter(string name, int age, char gender, string hobby)
                : base(name, age, gender)
            {
                this.Hobby = hobby;
            }
            public void ReporterSayHello()
            {
                //记者：我叫记者，我的爱好是偷拍 我的年龄是** 我是一个男狗仔
                Console.WriteLine("我叫{0},我的爱好是{1},我的年龄是{2},我是一个{3}狗仔", this.Name, this.Hobby, this.Age, this.Gender);
            }
        }
    }
}
