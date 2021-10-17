using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Mime;
using System.Text;
using Core.DataAccess.EntitFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Concrete.Dtos;
using Microsoft.EntityFrameworkCore.Internal;

namespace DataAccess.Concrete.EntityFrameWork
{
    public class EfCustomerDal:EfEntityRespositoryBase<Customer,RepairContext> ,ICustomerDal
    {
        IQueryable<CustomerDetail> result;
        public List<CustomerDetail> GetCustomerDetail(Expression<Func<Customer, bool>> filter = null)
        {
            
            using (RepairContext context = new RepairContext())
            {
                
                 result = from c in filter == null ? context.Customers : context.Customers.Where(filter)

                    join p in context.Products on c.Id equals p.CustomerId
                    orderby p.CustomerId descending 

                     select new CustomerDetail()
                    {
                        
                        FirstName = c.FirstName,
                        LastName = c.LastName,
                        TelefonNumber = c.TelefonNumber,
                        Brand = p.Brand,
                        FinishDate = p.FinishDate,
                        Description = p.Description,
                        Fault = p.Fault,
                        ImeiNumber = p.ImeiNumber,
                        StartingDate = p.StartingDate,
                        Price = p.Price,
                        CustomerUniqueId = c.UniqueId
                        

                    };

                
                return result.ToList();

            }
        }

        public List<CustomerDetail> SortByFirstName(string firstName)
        {
            
            
                return result.OrderBy(c => c.FirstName).ToList();
            
                
        }
    }
}
