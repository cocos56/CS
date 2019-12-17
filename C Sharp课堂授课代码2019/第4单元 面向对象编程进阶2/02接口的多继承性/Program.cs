using System;

namespace _02接口的多继承性
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public interface M1
    {
        void Test1();
    }
    public interface M2
    {
        void Test2();
    }
    public interface M3
    {
        void Test3();
    }
    public interface SuperInterface : M1, M2, M3
    {
 
    }
    public class Car : SuperInterface
    {
        public void Test1()
        {
            throw new NotImplementedException();
        }

        public void Test2()
        {
            throw new NotImplementedException();
        }

        public void Test3()
        {
            throw new NotImplementedException();
        }
    }
}
