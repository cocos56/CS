using System;

namespace _01结构体
{
    public struct Person
    {
        public string _name;
        public int _age;
        public Gender _gender;
    }

    public enum Gender
    {
        男,
        女
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person zsPerson;
            zsPerson._name = "张三";
            zsPerson._age = 10;
            zsPerson._gender = Gender.男;
            Console.WriteLine("我叫{0},我今年{1}岁了，我是{2}生", zsPerson._name, zsPerson._age, zsPerson._gender);
            Console.ReadKey();
        }
    }
}