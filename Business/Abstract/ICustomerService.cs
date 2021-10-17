using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete.Dtos;

namespace Business.Abstract
{
   public interface ICustomerService
   {
       List<CustomerDetail> GetAll();
       List<CustomerDetail> GetCustomerByName(string name);
       List<CustomerDetail> GetCustomerByLastName(string lastName);
       List<CustomerDetail> GetCustomerByDate(string date);
        List<Customer> GetAllCustomer();
        Customer Get(string firstName);
       List<CustomerDetail> SortByFirstName(string firstName);
        void Add(Customer customer);

       void Update(Customer customer);

       void Delete(Customer customer);
   }
}
