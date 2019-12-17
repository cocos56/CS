namespace _07密封类
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    //public sealed class Person { }
    //public class Test : Person { }//密封类不能被其他类继承
    public class Test { }
    public sealed class Person:Test { }//密封类可以继承其他类
}
