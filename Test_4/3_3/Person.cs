using System;

namespace _3_3
{
    class Person
    {
        public string Name;
		public int ID;
		public static int IDCnt = 1;


		public Person(string name)
        {
			this.ID = IDCnt;
			IDCnt += 1;
            this.Name = name;
        }

        public void hello()
        {
            Console.WriteLine("我是人类");
        }
    }
}