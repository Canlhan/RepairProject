using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAccess;
using Entities.Abstract;
using Entities.Concrete;

namespace DataAccess.Abstract
{
   public interface IProductDal:IEntityRespository<Product>
    {

    }
}
