using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace U28D第十五天
{
    class Program
    {
        //先建表 再建类
        
        //连接数据库5个步骤：
        //1 拿到数据库连接
        //2 拿到发送语句
        //3 执行sql语句
        //4 拿到执行结果
        //5 关闭资源
        static void Main(string[] args)
        {
            ////string url = "User ID=root;Password=myPassword;Host=localhost;Port=3306;Database=zhang;";//zhang 为自己定义的数据库
            string url = "User ID=root;Password=;Host=localhost;Port=3306;Database=zhang;";//Password=密码为空什么都不写 localhost本地 ID=root用户
            MySqlConnection conn = new MySqlConnection(url);//创建数据库连接
            conn.Open();//数据库连接打开
            //string sql = "select * from student";//创建sql语句
            //string sql = "select * from student where id=1";//创建sql语句

            string sql = "insert into student values(18,'ppp','man',4)";//创建sql语句
            MySqlCommand comd = new MySqlCommand(sql, conn);//发送sql语句给数据库服务器
            //MySqlDataReader reader = comd.ExecuteReader();//执行sql语句 MySqlDataReader类似于迭代器
            
            //while (reader.Read())//判断是否有下一个
            //{
            //    Console.WriteLine(reader.GetInt32(0));//拿到ID
            //    Console.WriteLine(reader.GetString(1));//拿到名字
            //    Console.WriteLine(reader.GetString(2));//拿到性别
            //    Console.WriteLine("---------");
            //}
            
            ////1.hasNext CurrentValue
            int a = comd.ExecuteNonQuery();//表示受影响的行数
            Console.WriteLine(a);//执行sql语句受影响的行数 不能执行第2次

            //public static bool FindStudentByName(string name)函数
            //bool b = FindStudentByName("shunv");
            //Console.WriteLine(b);             

            //public static bool Save(Student s)函数
            //Student s = new Student(15, "5555", "man", 3);
            //bool b = Save(s);//Save(s)--->s在Save(）圆括号里面 ORM---->object relation  Mapping对象关系映射
            //Console.WriteLine(b); 

            // public static Student FindStudentById(int id)函数
            //Student s = FindStudentById(8);
            //Console.WriteLine(s.Id + " " + s.Name + " " + s.Sex + " " + s.Grade);

            //List<Student> list = FindStudents(80);
            //Console.WriteLine(list.Count);
            //for (int i = 0; i < list.Count; i++)
            //{
            //    Console.WriteLine(list[i].Id + " " + list[i].Name + " " + list[i].Sex + " " + list[i].Grade);
            //}
        }
        public static bool FindStudentByName(string name)
        {
            string url = "User ID=root;Password=;Host=localhost;Port=3306;Database=zhang;";//Password=密码为空什么都不写 localhost本地 ID=root用户
            MySqlConnection conn = new MySqlConnection(url);//创建数据库连接
            conn.Open();//数据库连接打开
            string sql = "select * from student where name='" + name + "'";
            Console.WriteLine(sql);//打印输出sql语句
            MySqlCommand comd = new MySqlCommand(sql, conn);//发送sql语句给数据库服务器
            MySqlDataReader reader = comd.ExecuteReader();//执行sql语句  MySqlDataReader类似于迭代器
            return reader.Read();
            //接下来在“U28D第十五天”项目上鼠标右键添加“Student”类
        }
        public static bool Save(Student s)
        {
            bool b = false;
            string url = "User ID=root;Password=;Host=localhost;Port=3306;Database=zhang;";
            MySqlConnection conn = new MySqlConnection(url);//创建数据库连接
            conn.Open();//数据库连接打开
            //string sql = "insert into student values(" + s.Id + ",'" + s.Name + "','" + s.Sex + "'," + s.Grade + ")";//创建sql语句  这种写法太痛苦
            //sql语句的简单写法是一下两行
            string sql = "insert into student values({0},'{1}','{2}',{3})";
            sql= string.Format(sql, s.Id, s.Name, s.Sex, s.Grade);//F12转到定义，Format函数有params object[] args（可变参数）
            Console.WriteLine(sql);
            MySqlCommand comd = new MySqlCommand(sql, conn);// 发送sql语句给数据库服务器
            int a = comd.ExecuteNonQuery();//执行sql语句
            if (a==1)
            {
                return b= true;
            }
            conn.Close();//关闭资源
            return b;        
        }
        public static Student FindStudentById(int id)
        {
            Student s = null;
            string url = "User ID=root;Password=;Host=localhost;Port=3306;Database=zhang;";
            MySqlConnection conn = new MySqlConnection(url);//创建数据库连接
            conn.Open();//数据库连接打开
            string sql = "select * from student where id="+id;
            Console.WriteLine(sql);
            
            MySqlCommand comd = new MySqlCommand(sql, conn);//发送sql语句
            MySqlDataReader read = comd.ExecuteReader();
            if (read.Read())
            {
              //如何得到Student类的对象呢？
                s=new Student();//找不到就不需要开辟内存
                s.Id = read.GetInt32(0);
                s.Name = read.GetString(1);
                s.Sex = read.GetString(2);
                s.Grade = read.GetInt32(3);  
            }
            conn.Close();//关闭资源
            return s;
        }
        public static List<Student> FindStudents(double d)
        {
            List<Student> list = new List<Student>();
            //总分的平均分大于80的学生信息
            //List <Student>= null;
            string url = "User ID=root;Password=;Host=localhost;Port=3306;Database=zhang;";
            MySqlConnection conn = new MySqlConnection(url);//创建数据库连接
            conn.Open();//数据库连接打开            
           //select avg(sc_num) from score group by c_id 拿到每一个人的平均分
            //select s_id,avg(sc_num) a from score group by s_id having a>80
            //select id,name,sex,grade from student,(select s_id,avg(sc_num) a from score group by s_id having a>80) t where student.id=t.s_id;
            string sql = "select id,name,sex,grade from student,(select s_id,avg(sc_num) a from score group by s_id having a>"+d+") t where student.id=t.s_id;";
            Console.WriteLine(sql);
            MySqlCommand comd = new MySqlCommand(sql, conn);//发送sql语句
            MySqlDataReader read = comd.ExecuteReader();
            //Console.WriteLine(read.Read());//不能增加这条语句 要不然少输出一条信息
            while (read.Read())
            {
                Student s = new Student();
                s.Id = read.GetInt32(0);
                s.Name = read.GetString(1);
                s.Sex = read.GetString(2);
                s.Grade = read.GetInt32(3);
                list.Add(s);
            } 
            conn.Close();//关闭资源
            return list;

        }
    }
}