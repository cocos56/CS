using System;

namespace Test_4
{
    class Student : Person
    {
        public string Hobby;

        public Student() : base()
        {
            this.Hobby = "Null";
        }

        public Student(string name, double age, string hobby) :
            base(name, age)
        {
            this.Hobby = hobby;
        }

        public new void hello()
        {
            Console.WriteLine("我叫{0}，我今年{1}岁了，我的爱好是{2}。", this.Name, this.Age, Hobby);
        }
    }
}
