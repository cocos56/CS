using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00构造函数的调用
{
    class Program
    {
        /*总结：
         * 1.子类的构造器必须要调用父类的构造器
         * 调用分为2种，隐式的调用和显示的调用
         * 隐式调用会去找父类中是否有无参的构造器
         * 如果没有则报错
         * 一旦父类中有其他构造器，则必须显示的调用base
         * 
         * 那么因此我们在写一个类的时候，一般
         * 会写一个全参的构造器和一个无参的构造器。
        
        
         */
        static void Main(string[] args)
        {
            TT tt = new TT();
            Console.WriteLine(tt.A + " " + tt.B + " " + tt.C);
            TT tt2 = new TT(6);
            Console.WriteLine(tt2.A + " " + tt2.B + " " + tt2.C);
            TT tt3 = new TT(5, "wang", 100);
            Console.WriteLine(tt3.A + " " + tt3.B + " " + tt3.C);
            Console.ReadKey();
        }
    }

    public class T
    {
        public int A { get; set; }
        public string B { get; set; }
        public T(int a, string b)
            : this(a)
        {
            this.B = b;
            Console.WriteLine("1");
        }
        public T(int a)
        {
            this.A = a;
            Console.WriteLine("2");
        }
        public T(string b)
        {
            this.B = b;
            Console.WriteLine("3");
        }
    }
    public class TT : T
    {
        public int C { get; set; }
        public TT(int c)
            : base(1, "a")
        {
            this.C = c;
            Console.WriteLine("4");
        }
        public TT(int a, string b, int c)
            : base(a, b)
        {
            this.C = c;
            Console.WriteLine("5");
        }
        public TT()
            : this(8)
        {
            Console.WriteLine("6");
        }
    }
}
