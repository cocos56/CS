using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace _09序列化和反序列化
{
    //序列化：就是将对象转换为二进制。发送数据
    //反序列化：就是将二进制转换为对象。接收数据
    //作用：传输数据。只有二进制数据才能在网络中传输数据。
    //序列化：将这个类标记为可以被序列化的[Serializable]
    class Program
    {
        static void Main(string[] args)
        {
            //要将p这个对象 传输给对方电脑
            //Person p = new Person();
            //p.Name = "张三";
            //p.Age = 19;
            //p.Gender = '男';
            //using (FileStream fsWrite = new FileStream(@"C:\Users\SpringRain\Desktop\111.txt", FileMode.OpenOrCreate, FileAccess.Write))
            //{ 
            //    //开始序列化对象
            //    BinaryFormatter bf = new BinaryFormatter();
            //    bf.Serialize(fsWrite, p);
            //}
            //Console.WriteLine("序列化成功");
            //Console.ReadKey();

            //接收对方发送过来的二进制 反序列化成对象
            Person p;
            using (FileStream fsRead = new FileStream(@"C:\Users\SpringRain\Desktop\111.txt", FileMode.OpenOrCreate, FileAccess.Read))
            {
                BinaryFormatter bf = new BinaryFormatter();
                p = (Person)bf.Deserialize(fsRead);
            }
            Console.WriteLine(p.Name);
            Console.WriteLine(p.Age);
            Console.WriteLine(p.Gender);
            Console.ReadKey();
        }
    }


    [Serializable]
    public class Person
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }


        private char _gender;

        public char Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }

        private int _age;

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }
    }
}