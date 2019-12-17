using System;

namespace Test_4
{
    class Teacher : Person
    {
        public double WorkingAge;

        public Teacher() { }

        public Teacher(string name, double age, double workingAge) :
            base(name, age)
        {
            this.WorkingAge = workingAge;
        }

        public new void hello()
        {
            Console.WriteLine("我叫{0}，我今年{1}岁了，我已经工作{2}年了。", this.Name, this.Age, WorkingAge);
        }
    }
}
