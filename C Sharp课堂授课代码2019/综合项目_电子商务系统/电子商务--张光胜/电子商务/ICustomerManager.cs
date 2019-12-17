using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 电子商务
{
   public interface ICustomerManager
    {
        Customer FindCustomerByName(string name);
        Customer FindCustomerById(int id);
        void SaveCustomer(Customer c);
        void UpdateCustomer(Customer c);
        bool DeleteCustomerById(int id);
        bool DeleteCustomerByName(string name);
        Seller FindSellerByName(string name);
        Seller FindSellerById(int id);
    }
}
