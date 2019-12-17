using System;

//第一次

//写一个Student类和一个Teacher类, 他们都有一个打招呼的方法, 不同的是Studetn打招呼是说"大家好,我叫XX,我今年XX岁了,我的爱好是XXX",Teacher的打招呼的方法是说"大家好,我叫XX,我今年XX岁了,我已经工作XX年了"?
//  自己定义一个父类Person,两个子类Teacher和Student类.练习类内部构造器的调用，练习子类调用父类的构造器
// 自己试试, 子类可以自动转父类,父类转子类要通过强转.为了不出错,可以先通过is判断或用as转换

namespace Test_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stu = new Student()
            {
                Name = "Coco",
                Age = 22,
                Hobby = "coding"
            };
            stu.hello();

            Teacher t = new Teacher();
            t.Name = "Mr. Smith";
            t.Age = 42;
            t.WorkingAge = 15;
            t.hello();

            Console.WriteLine();
            //里氏转换：1)子类可以赋值给父类
            Person p = new Student("Join", 18, "Running");
            //Student ss = (Student)p;  有风险

            //2)如果父类中装的是子类对象，那么可以将这个父类转换为子类对象

            //3)子类对象可以调用父类中的成员，但是父类对象永远只能调用自己的成员

            //is用法：表示类型转换 转换成功返回True，否则False
            //强制类型转换 由大类型转换为小类型 有风险
            if (p is Student)
            {
                Console.WriteLine("可以转换，正在进行转换");
                //as用法 表示类型转化 转换成功返回对应的对象 否则返回一个null
                Student t2 = p as Student;
                t2.hello();
            }
            else
            {
                Console.WriteLine("不可以转换");
            }

            Console.WriteLine("\nPress any key to quit.");
            Console.ReadKey();
        }
    }
}