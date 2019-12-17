using System;

namespace _02面向对象初步
{
    public enum Gender
    {
        男,
        女
    }
    public class Person
    {
        //字段-----存储数据
        private string _name;
        //属性-----保护字段，对字段的值进行限定
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private Gender _gender;

        public Gender Gender
        {
            get
            {
                if (_gender != Gender.男 && _gender != Gender.女)
                {
                    return _gender = Gender.男;
                }
                return _gender;
            }
            set { _gender = value; }
        }
        private int _age;

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
        //private double _weight;//字段可以不写出来

        public double Weight//C#3.0后改进  自动属性
        {
            get;
            set;
        }

        private double _height;

        public double Height
        {
            get { return _height; }
            set { _height = value; }
        }

        public void CHLSS()
        {
            //this代表当前类的对象
            //Console.WriteLine("我叫{0},我是{1}生,我今年{2}岁了,我可以吃喝拉撒睡", this._name, this._gender, _age);
            Console.WriteLine("我叫{0},我是{1}生,我今年{2}岁了,我的体重是{3}kg,我可以吃喝拉撒睡", this.Name, this.Gender, Age, Weight);
        }
    }
}