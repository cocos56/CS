namespace _040static用法
{
    class Program
    {
        //int a = 10;
        //static int a = 10;
        const int a = 10;
        //static修饰的方法表示该方法是属于类，而不属于对象
        static void Main(string[] args)
        {
            M();
            Program.M();
            Program p = new Program();
            p.M1();
        }
        public static void M()
        {
            //a++; //因为a是普通变量，静态（全局）方法不知道要操作哪个对象的a字段
            //S();不能调用的 静态方法不能调用费静态方法
            //a++;
        }
        public void M1()
        {
            //a++;
            M();//普通可以调用静态方法
            //a = 20;
        }
        public void S()
        { }
    }
}