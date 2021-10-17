using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
        Product Get(int customerId);
        void Add(Product product);

        void Update(Product product);

        void Delete(Product product);
    }
}
