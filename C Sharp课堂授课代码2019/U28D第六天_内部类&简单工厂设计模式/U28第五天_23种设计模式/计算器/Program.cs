using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 计算器
{
    class Program
    {
        //面向对象的计算器  父类：运算
        //Operate--> Add Sub Mul Div operating(int,int)
        static void Main(string[] args)
        {
           
            //Operate o =OperateFactory.GetOperate("+");
            //int result=o.operating(3, 10);
            //Console.WriteLine(result);

           
            string s = Console.ReadLine();
            //23+25
            string[] ss=s.Split('+','-','*','/');
            int a=Convert.ToInt32(ss[0]);
            int b = Convert.ToInt32(ss[1]);
            string s2 = s.Substring(ss[0].Length,1);
           char c= Convert.ToChar(s2);
            Operate o = OperateFactory.GetOperate(c);
            int result = o.operating(a,b);
            Console.WriteLine(result);
        }
        public interface Operate
        {
            int operating(int a,int b);
        }
        public class  Add:Operate
        {
            public int operating(int a,int b)
            {
                return a+b;
            }
        }
        public class  Sub:Operate
        {
            public int operating(int a,int b)
            {
                return a-b;
            }
        }
         public class  Mul:Operate
        {
            public int operating(int a,int b)
            {
                return a*b;
            }
        }
         public class  Div:Operate
        {
             public int operating(int a, int b)
            {
                return a/b;
            }
        }

       public class OperateFactory
       {
           public static Operate GetOperate(char c)
           {
               if (c == '+')
               {
                   return new Add();                  
               }
               else if (c == '-')
               {
                   return new Sub();
               }
               else if (c == '*')
               {
                   return new Mul();
               }
               else
               {
                   return new Div();
               }
           }
       }
        
    }
}
