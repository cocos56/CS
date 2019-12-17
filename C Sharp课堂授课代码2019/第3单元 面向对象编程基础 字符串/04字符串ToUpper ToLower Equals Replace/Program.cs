using System;

namespace _04字符串ToUpper_ToLower_Equals_Replace
{
    class Program
    {
        static void Main(string[] args)
        {
            ////练习一:随机输入你心中想到的一个名字，然后输出它的字符串长度  Length:可以得字符串的长度
            //Console.WriteLine("请输入你心中想的那个人的名字");
            //string name = Console.ReadLine();
            //Console.WriteLine("你心中想的人的名字的长度是{0}",name.Length);
            //Console.ReadKey();


            //Console.WriteLine("请输入你喜欢的课程");
            //string lessonOne = Console.ReadLine();
            ////将字符串转换成大写
            ////  lessonOne = lessonOne.ToUpper();
            ////将字符串转换成小写形式
            //// lessonOne = lessonOne.ToLower();
            //Console.WriteLine("请输入你喜欢的课程");
            //string lessonTwo = Console.ReadLine();
            ////   lessonTwo = lessonTwo.ToUpper();
            ////   lessonTwo = lessonTwo.ToLower();
            //if (lessonOne.Equals(lessonTwo, StringComparison.OrdinalIgnoreCase))
            //{
            //    Console.WriteLine("你们俩喜欢的课程相同");
            //}
            //else
            //{
            //    Console.WriteLine("你们俩喜欢的课程不同");
            //}
            //Console.ReadKey();


            //string s = "a b   dfd _   +    =  ,,, fdf ";
            ////分割字符串Split
            //char[] chs = { ' ', '_', '+', '=', ',' };
            //string[] str = s.Split(chs, StringSplitOptions.RemoveEmptyEntries);
            //Console.ReadKey();


            //练习：从日期字符串（"2008-08-08"）中分析出年、月、日；2008年08月08日。
            //让用户输入一个日期格式如:2008-01-02,你输出你输入的日期为2008年1月2日

            //string s = "2008-08-08";
            ////  char[] chs = { '-' };
            //string[] date = s.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
            //Console.WriteLine("{0}年{1}月{2}日", date[0], date[1], date[2]);
            //Console.ReadKey();

            string str = "国家关键人物胡锦涛";
            if (str.Contains("胡锦涛"))
            {
                str = str.Replace("胡锦涛", "***");
            }
            Console.WriteLine(str);
            Console.ReadKey();

            ////123-->一二三
            //Console.WriteLine("请输入转换前的字符串");
            //string s = Console.ReadLine();
            //char[] chs=s.ToCharArray();
            //M1(ref chs);
            //Console.ReadKey();

        }
        public static void M1(ref char[] s)
        {
            string s2 = "零一二三四五六七八九";
            char[] cs2 = s2.ToCharArray();
            for (int i = 0; i < s.Length; i++)
            {
                //if (s[i]=='1')
                //{
                //  s[i]='一'; 
                //}
                //else if (s[i] == '2')
                //{
                //    s[i] = '二';
                //}
                //......
                Console.Write(cs2[s[i] - 48]);
            }
            Console.WriteLine();
        }
    }
}