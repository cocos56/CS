using System;

namespace _08简单工厂设计模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请你输入您想要的笔记本品牌");
            string brand = Console.ReadLine();
            NoteBook nb = GetNoteBook(brand);
            nb.SayHello();
            Console.ReadKey();
        }
        /// <summary>
        /// 简单工厂设计模式的核心：根据用户的输入创建对象 赋值给父类
        /// </summary>
        /// <param name="brand"></param>
        /// <returns></returns>
        public static NoteBook GetNoteBook(string brand)
        {
            NoteBook nb=null;
            switch (brand)
            {
                case "Lenovo": nb = new Lenovo();
                    break;
                case "IBM": nb = new IBM();
                    break;
                case "Acer": nb = new Acer();
                    break;
                case "Dell": nb = new Dell();
                    break;
            }
            return nb; 
        }
    }
   
    public abstract class NoteBook
    {
        public abstract void SayHello();
    }
    public class Lenovo : NoteBook
    {
        public override void SayHello()
        {
            Console.WriteLine("我是联想笔记本，经济又划算！");
        }
    }
    public class Acer : NoteBook
    {
        public override void SayHello()
        {
            Console.WriteLine("我是宏碁笔记本，我来自中国台湾");
        }
    }
    public class Dell : NoteBook
    {
        public override void SayHello()
        {
            Console.WriteLine("我是戴尔笔记本");
        }
    }
    public class IBM : NoteBook
    {
        public override void SayHello()
        {
            Console.WriteLine("我是IBM笔记本");
        }
    }
}