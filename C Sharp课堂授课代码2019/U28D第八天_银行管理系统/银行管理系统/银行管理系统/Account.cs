using System;

namespace 银行管理系统
{
  public  class Account//只有属性和方法的类称为裸体类 Bean
    {
      public static int num = 1;
      public double Balance { get; set; }
      public int Id { get; set; }//Account getAccount(int index)要用
      public Account(double balance)
      {
          this.Balance = balance;
          this.Id = num;
          num++;//用户每增加一个Id加1
      }
      public  double getBalance()
      {
          return this.Balance;
      }
      public virtual bool deposit(double amount)
      {//存钱


          this.Balance += amount;
          return true;
      }
      public virtual bool withdraw(double amount)
      {//取钱

          double temp = this.Balance;

          if (temp  >= amount)
          {
              temp -= amount;
              this.Balance = temp;
              Console.WriteLine("取钱成功！");
              return true;
          }
          else
          {
              //第一种方法
              //Console.WriteLine("余额不足！");
              //return false;

              //第二种方法
              throw new BankException("余额不足");

          }
      }
      public override string ToString()
      {
          return "id:" + this.Id + "\tbalance:" + this.Balance;
      }
    }
}