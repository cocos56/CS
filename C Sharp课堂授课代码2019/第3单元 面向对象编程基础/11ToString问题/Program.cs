using System;

namespace _11ToString问题
{
    class Program
    {
        static void Main(string[] args)
        {
            //引用类型对象，ToString后打印是这个对象所在的类的命名空间
            int[] nums = { 1, 2, 3, 4, 5, 6 };
            //System.Int32[]
            Console.WriteLine(nums.ToString());
            Person p = new Person();
            //_01_ToString问题.Person
            Console.WriteLine(p.ToString());
            Console.ReadKey();
        }
    }
    public class Person
    {

    }
}