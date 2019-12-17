using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05构造函数和析构函数
{
    public class Student
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private char _gender;

        public char Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }
        private int _age;

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }
        private double _weight;

        public double Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }
        private double _chinese;

        public double Chinese
        {
            get { return _chinese; }
            set { _chinese = value; }
        }
        public double English
        {
            get;
            set;
        }
        public double Math
        {
            get;
            set;
        }
        public void SayHello()
        {
            Console.WriteLine("你好，我叫{0},我今年{1}岁了,我是{2}生,我的体重是{3}kg", this.Name, this.Age, this.Gender, this.Weight);
        }
        public void ShowScore()
        {
            Console.WriteLine("你好，我叫{0},我总成绩是{1},平均成绩是{2:0.00}", this.Name, this.Chinese + this.English + this.Math, (this.Chinese + this.English + this.Math) / 3);
        }
        //构造函数用于初始化对象
        //没有返回值 连void都没有
        //构造函数名字和类名一样 系统为我们提供一个无参的默认构造函数
        public Student()
        {
        }
        public Student(string name, char gender, int age, double weight)
        {
            this.Name = name;
            this.Gender = gender;
            this.Age = age;
            this.Weight = weight;
        }
        //this:调用当前类中的构造函数
        public Student(string name, char gender, double chinese, double english, double math)
            : this(name, gender, 0, 0)
        {
            //this.Name = name;
            //this.Gender = gender;
            this.Chinese = chinese;
            this.Math = math;
            this.English = english;
        }
        ~Student()//程序结束的时候 析构函数才执行  帮助我们释放资源的 没有参数
        {
            Console.WriteLine("我是一个析构函数");
        }


    }
}
