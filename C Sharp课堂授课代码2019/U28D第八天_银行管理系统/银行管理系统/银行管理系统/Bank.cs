using System;
using System.Collections.Generic;

namespace 银行管理系统
{
    class Bank
    {
        //Dictionary:相同键在java中覆盖掉,而在c#中直接报出异常      
        Dictionary<int, Customer> Dic{get;set;}
        public int CustNum { get; set; } //表示当前ATM机器上操作账户的顾客ID      
        public Bank()
        {
            Dic = new Dictionary<int, Customer>();
        } 
       public void AddCustomer(Customer c)
        {
            Dic.Add(c.Id, c);
        }
       public Customer GetCustomer(int num)//num--指的是键
        {          
            return Dic[num];//根据num键取Dic中的值//教师写
        }
       public Customer GetCustomerByName(string name)//根据顾客的name值返回一个客户
       {
           Customer cus = null;
           foreach (Customer c in Dic.Values)
           {
               if(c.Name==name)
               {
                   cus = c;
               }
           }
           return cus;
       }
     //public Customer GetCustomerById(int id)//根据顾客的id编号返回一个客户
     //{
     //    Customer cus = null;
     //    foreach (Customer c in Dic.Values)
     //    {
     //        if (c.Id == id)
     //        {
     //            cus = c;
     //        }
     //    }
     //    return cus;
     //}
        
        
        public void GetAllCustomer()
       {          
          foreach (var item in Dic.Values)
           {
               Console.WriteLine(item);
           }          
       }
      
        public int GetCustomerNum()//表示当前ATM机器上操作账户的顾客ID    
      {
            return  this.CustNum;
      }
    }
}
