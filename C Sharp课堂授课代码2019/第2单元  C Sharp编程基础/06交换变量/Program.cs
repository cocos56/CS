﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06交换变量
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 10;
            int n2 = 20;
            //int temp = n1;
            //n1 = n2;
            //n2 = temp;

            //n1 = n1 + n2;//30
            //n2 = n1 - n2;//10
            //n1 = n1 - n2;//20

            n1 = n1 - n2;//-10
            n2 = n1 + n2;//10
            n1 = n2 - n1;//20
            Console.WriteLine("交换后，n1的值是{0},n2的值是{1}", n1, n2);
            Console.ReadLine();

        }
    }
}
