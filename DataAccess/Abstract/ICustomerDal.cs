using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Core.DataAccess;
using Entities.Concrete;
using Entities.Concrete.Dtos;

namespace DataAccess.Abstract
{
   public interface ICustomerDal:IEntityRespository<Customer>
    {
        List<CustomerDetail> GetCustomerDetail(Expression<Func<Customer, bool>> filter = null);
        List<CustomerDetail> SortByFirstName(string firstName);
    }
}
