using System;

namespace 银行管理系统
{
   public class CheckingAccount:Account
    {
        public double Overdraft { get; set; }//透资额度
       public  CheckingAccount(double balance, double overdraft):base(balance)
       {
           this.Overdraft = overdraft;
       }
      public CheckingAccount(double balance):base(balance)
       {

       }
      public override bool  withdraw(double amount)
      {
          if(this.Overdraft>=amount)
          {
              this.Overdraft -= amount;
              return true;
          }
          else
          {
              Console.WriteLine("超出透资额度！");
              return false;  
          }                   
      }
     public double getOverdraft()
      {
          return this.Overdraft;
      }
    }
}
