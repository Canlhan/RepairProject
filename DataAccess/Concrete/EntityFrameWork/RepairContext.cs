using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;








namespace DataAccess.Concrete.EntityFrameWork
{
    
    public class RepairContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var adres = Con(System.IO.File.ReadAllText(@"C:\Adress.txt"));

            
          string myConnectionString = @"Data Source="+adres[0]+ ",1433;Initial Catalog=EDI_HR;database=Repairdb; user=" + adres[1]+";password="+adres[2]+";";
            //@"Server=192.168.1.36;Database=Repairdb;Uid=can;Pwd=12345;"
            optionsBuilder.UseSqlServer(myConnectionString);
            
        }
        
        public DbSet<Product> Products { get; set; }
       
        public DbSet<Customer> Customers { get; set; }

        private string[] Con(string cn)
        {
            var cg = cn.Split(',');
            return cg;
        }
    }
}
