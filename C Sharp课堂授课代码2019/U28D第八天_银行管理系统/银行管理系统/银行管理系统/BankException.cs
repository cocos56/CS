using System;

namespace 银行管理系统
{
    //自定义异常类 但是必须继承至Exception类
    //异常类型中常见属性:Message-----错误信息,StackTrace-----描述异常发生位置信息
    class BankException:Exception      
    {
        public BankException(string str)
            : base(str)//调用系统（基类）构造器base(str)   基类Exception有个构造器“public Exception(string message);”
        {
            //Console.WriteLine(Message);
        }
    }
}
