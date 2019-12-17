using System;

namespace _14Random
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.产生随机数的对象
            Random r = new Random();
            while (true)
            {
                //2.让产生随机数的这个对象调用方法产生随机数
                int rNumber = r.Next(1, 11);
                Console.WriteLine(rNumber);
                Console.ReadKey();
            }

            ////上辈子是什么样的人
            //Random r = new Random();
            //while (true)
            //{
            //    int rNumber = r.Next(1, 7);
            //    Console.WriteLine("请输入一个姓名");
            //    string name = Console.ReadLine();
            //    switch (rNumber)
            //    {
            //        case 1: Console.WriteLine("{0}上辈子是卖炊饼的", name);
            //            break;
            //        case 2: Console.WriteLine("{0}上辈子是西门大官人", name);
            //            break;
            //        case 3: Console.WriteLine("{0}上辈子是大汉奸", name);
            //            break;
            //        case 4: Console.WriteLine("{0}上辈子是活菩萨", name);
            //            break;
            //        case 5: Console.WriteLine("{0}上辈子是皮条客", name);
            //            break;
            //        case 6: Console.WriteLine("{0}上辈子是搞运输的", name);
            //            break;
            //        default:
            //            break;
            //    }
            //    Console.ReadKey();
            //}
        }
    }
}