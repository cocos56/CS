using System;

namespace _3_3
{
    class Student : Person
    {
        public float Score;

        public Student(string name, float score) :
            base(name)
        {
            this.Score = score;
        }

        public new void hello()
        {
            Console.WriteLine("我的学号是{0}，我叫{1}，我的分数是{2}。", ID, Name, Score);
        }

		public float CompareTo(Student other)
		{
			return (Score - other.Score);
		}
	}
}