using System;
using System.Collections.Generic;
using System.Text;
using Entities.Abstract;

namespace Entities.Concrete
{
   public  class Product:IEntity
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string Description { get; set; }
        public string ImeiNumber { get; set; }
        public string Price { get; set; }
        public string Brand { get; set; }
        public string Fault { get; set; }
        public bool Status { get; set; }
        public DateTime StartingDate { get; set; }
        public DateTime?  FinishDate { get; set; }
    }
}
