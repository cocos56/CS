namespace 银行管理系统
{
   public class SavingAccount:Account
    {
       public double Rate { get; set; }
       public SavingAccount(double balance, double rate):base(balance)
       {         
           this.Rate = rate;
        }       
    }
}
