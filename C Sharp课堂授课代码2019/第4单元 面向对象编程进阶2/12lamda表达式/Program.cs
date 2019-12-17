﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _12lamda表达式
{
    public delegate void DelOne();
    public delegate void DelTwo(string name);
    public delegate string DelThree(string name);
    class Program
    {
        static void Main(string[] args)
        {
            DelOne del = () => { };//delegate() { };
            DelTwo del2 = (string name) => { }; //delegate(string name) { };
            DelThree del3 = (string name) => { return name; };

            List<int> list = new List<int>() { 4, 8, 12, 24, 5, 9, 6 };
            list.RemoveAll(n => n > 6);
            //for (int i = 0; i < list.Count; i++)
            //{
            //    Console.WriteLine(list[i]);
            //}
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
