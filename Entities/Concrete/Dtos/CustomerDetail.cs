using System;
using System.Collections.Generic;
using System.Text;
using Entities.Abstract;

namespace Entities.Concrete.Dtos
{
    public class CustomerDetail:IDto
    {
        
        public string FirstName{ get; set; }
        public string LastName { get; set; }
        public string TelefonNumber { get; set; }
        public string CustomerUniqueId { get; set; }
        public string Price { get; set; }
        public string Description { get; set; }
        public DateTime StartingDate { get; set; }
        public DateTime?  FinishDate { get; set; }
        public string Fault { get; set; }
        public string Brand { get; set; }
        public string ImeiNumber { get; set; }
        
    }
}
