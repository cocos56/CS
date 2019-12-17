using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace _06������ó�Ա
{
    class Program
    {
        static void Main(string[] args)
        {
            Type typePerson= typeof(Person);
            //ʵ��������
            object o=Activator.CreateInstance(typePerson);
            //�����Ը�ֵ
            PropertyInfo propName=typePerson.GetProperty("Name");
            propName.SetValue(o, "������", null);
//���Person���Age���Ե�����
            PropertyInfo propAge = typePerson.GetProperty("Age");
//��һ������ΪҪΪ�ĸ������Age���Ը�ֵ
            propAge.SetValue(o, 15, null);

            MethodInfo mi=typePerson.GetMethod("SayHello");
            mi.Invoke(o, null);
        }
    }
    class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public void SayHello()
        {
            Console.WriteLine("�ҽ�{0},�ҽ���{1}����", this.Name, this.Age);
        }
    }
}
