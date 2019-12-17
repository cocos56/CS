using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06类的定义复习
{
    public class Person
    {
        //字段、属性、方法、构造函数与析构函数
        //字段：存储数据
        //属性:保护字段，对字段的取值和设值进行限定 过渡中间作用 属性并不存值
        //方法:描述对象行为的
        //构造函数：初始化对象（给对象的每个属性依次赋值的）
        //类中的成员，默认是private
        string _name;
        public string Name
        {
            get
            {
                if (_name != "SunQuan")
                {
                    _name = "SunQuan";
                }
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        int _age;
        /// <summary>
        /// 属性本质上就是两个方法 仅有get称为只读属性 仅有Set称为只写属性
        /// Ctrl+R，E  封装字段 快速创建属性
        /// </summary>
        public int Age
        {
            get { return _age; }
            set
            {
                if (value < 0 || value > 100)
                {
                    value = 0;
                }
                _age = value;
            }
        }
        char _gender;

        public char Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }
        public void SayHello()
        {
            Console.WriteLine("我叫{0}，我今年{1}岁了，我是{2}生", this.Name, this.Age, this.Gender);
        }
        //构造函数：名字和类名一样，连void都没有
        //          在同一个类里面，重载：参数个数、顺序、类型都不一样，名称一样       

        //系统提供默认无参构造函数,如果自定义了带参构造函数，无参的构造函数就被屏蔽，需要显示的写出来
        public Person()
        {

        }
        /// <summary>
        /// this:1.调用本类当中的构造函数
        /// this:2.代表当前类的对象
        /// </summary>
        public Person(string name, char gender, int age)
            : this(name, gender)
        {
            //this.Name = name;
            //this.Gender = gender;
            this.Age = age;
        }
        public Person(string name, char gender)
        {
            this.Name = name;
            if (gender != '男' && gender != '女')
            {
                gender = '男';
            }
            this.Gender = gender;
        }
        ~Person()
        {
            Console.WriteLine("调用了析构函数");
        }
    }
}
