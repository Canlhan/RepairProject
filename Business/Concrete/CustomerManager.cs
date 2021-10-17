using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Concrete.Dtos;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        private ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public void Add(Customer customer)
        {
           
                _customerDal.Add(customer);
            
            
            
        }

        public void Delete(Customer customer)
        {
           _customerDal.Delete(customer);
        }

        public List<CustomerDetail> GetAll()
        {
            return _customerDal.GetCustomerDetail();
        }

        public Customer Get(string firstName)
        {
            return _customerDal.GetAll(c => c.UniqueId == firstName).SingleOrDefault();
        }

        public List<CustomerDetail> SortByFirstName(string firstName)
        {
            return _customerDal.SortByFirstName(firstName);
        }

        public void Update(Customer customer)
        {
            _customerDal.Update(customer);
        }

        public List<Customer> GetAllCustomer()
        {
            return _customerDal.GetAll();
        }

        public List<CustomerDetail> GetCustomerByName(string name)
        {
            return _customerDal.GetCustomerDetail(c => c.FirstName == name);
        }

        public List<CustomerDetail> GetCustomerByLastName(string lastName)
        {
            return _customerDal.GetCustomerDetail(c => c.LastName == lastName);
        }

        public List<CustomerDetail> GetCustomerByDate(string date)
        {
            return _customerDal.GetCustomerDetail();

        }
    }
}
