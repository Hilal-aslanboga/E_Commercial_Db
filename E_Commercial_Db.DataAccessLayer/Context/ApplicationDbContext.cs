using E_Commercial_Db.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commercial_Db.DataAccessLayer.Context
{
     class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext()
        {
            Database.Connection.ConnectionString = "";  //kendi server ınıza ait server name ve database isminizi giriniz.
        }

        //Database imizde oluşucak tabloların isimlerini girdik.
        public DbSet<Category> Categories { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Shipper> Shippers { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; } 

    }
}
