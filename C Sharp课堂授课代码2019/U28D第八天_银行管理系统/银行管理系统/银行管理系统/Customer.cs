using System.Collections.Generic;

namespace 银行管理系统
{
    public class Customer
    {

        public static int num=1;       
        public List<Account> list {get;set;}      
        public string Name { get; set; }
        public int Id { get; set; }
        public Customer(string name)
        {
           this.Name = name;
           this.list=new List<Account>();//在这里this加不加都可以  加this用于区分外部变量还是内部字段（属性）
           this.Id=num;
           num++;
        }
        public Account GetAccount(int id)
        {          
           Account a=null; //现需要new出来一个人的账户才能查询        
           foreach (Account act in list)
           {
               if (act.Id==id)
	            {
                   a=act;		 
	            }               
           }
           return a;
      }
       public void addAccount(Account account)
       {
           list.Add(account);
       }
    public string getName()
       {
           return this.Name;
       } 
    }
}
