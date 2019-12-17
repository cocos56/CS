using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookManagementSystem.View;
using BookManagementSystem.Frameworrk;

namespace BookManagementSystem
{
    class Student
    {
        public string Name;

        private static Student instance;

        private Student()
        {

        }
        internal static Student Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Student();
                }
                return instance;
            }
        }
    }
     
    class Program
    {



        static void Main(string[] args)
        {
            //UIManager ui = new UIManager();
            //ui.Open<EnterView>();
            //Student s1 = Student.Instance;
            //Student s2 = Student.Instance;
            //Console.WriteLine(ReferenceEquals(s1, s2));

            UIManager.Instance.Open<EnterView>().Enter();

            
        }
    }
}
