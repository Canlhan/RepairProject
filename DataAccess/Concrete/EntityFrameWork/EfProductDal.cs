using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAccess.EntitFramework;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFrameWork
{
   public class EfProductDal:EfEntityRespositoryBase<Product,RepairContext>,IProductDal
    {
    }
}
