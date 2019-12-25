namespace _06访问修饰符
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            Student s = new Student();
        }
    }

    public class Person
    {
        private char _gender;//不能被子类继承
        public int Age { get; set; }
        protected string _name;//可以被子类继承
        internal int _chinese;//仅可以在当前项目当中访问到
        protected internal int _math;
    }

    public class Student : Person
    {
        public Student()
        {
            //this.Age  可以
            //this._name 可以
            //this._math
        }
    }
}