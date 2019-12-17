using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03占位符
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 10;
            int n2 = 20;
            int n3 = 30;
            int n4 = 40;
            //Console.WriteLine("第一个数字是：" + n1 + "，第二个数字是：" + n2 + "，第三个数字是：" + n3);
            //需要注意的地方：
            //1.你挖了多少个坑，就应该填几个坑，多填了，没效果，少填了，抛异常
            //2.输出顺序是按照挖坑的顺序输出的
            Console.WriteLine("第一个数字是{1}，第二个数字是{2}，第三个数字是{0}", n1, n2, n3);
            Console.ReadKey();
        }
    }
}
