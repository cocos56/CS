using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 集合
{
    class Program
    {
        //数组：相同类型的有序集合，大小固定，类型一致
        static void Main(string[] args)
        {
           //Java在构造器中初始化
            ArrayList list = new ArrayList();
           // Console.WriteLine(list.Capacity);
           // list.Add("1");
            list.Add(1);
            list.Add(12);
            list.Add(5);
            list.Add(7);
            list.Add(9);

            //public virtual object this[int index] { get; set; }//索引器
            
            //自动装箱：将基本数据类型转换为其所对应的类型           
            //自动拆箱:与自动装箱相反过程
            
            //object o = list[3];
            //int a=list[3]    集合在设计的时候认为可以存放任意类型的数据 object
            ////int a1 = (int)list[0];//转换有误
           // int a = (int)list[3];//显示转换

            //public virtual int BinarySearch(object value);//二分查找有序元素
          
            //public virtual bool Contains(object item);
           // list.Clear();
            
            //object[] o = new object[list.Count];
            //list.CopyTo(o);
            //for (int i = 0; i <o.Length; i++)
            //{
            //    Console.WriteLine(o[i]);
            //}

            //object[] o = list.ToArray();
            //for (int i = 0; i < o.Length; i++)
            //{
            //    Console.WriteLine(o[i]);
            //}

            //public virtual int IndexOf(object value);
            //public virtual void Insert(int index, object value);
            list.Insert(5, "abc");
            //list.Insert(8, "abc");//抛出异常
            list[2] = 'a';
            //list.Insert(5, 15);
            Console.WriteLine(list.IndexOf("abc"));//插入后在原索引元素之前
            //Console.WriteLine(list.Capacity);
            //Console.WriteLine(list.Count);
            Console.ReadKey();
            
            
            //CRUD增删改查
        }
    }
}
