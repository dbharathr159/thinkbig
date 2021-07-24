using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DemoFoodApI.Entities
{
    public partial class MyContext:DbContext
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options)
        {

        }
       
        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Menu> Menus{ get; set; }
        public virtual DbSet<Orders> Orders1{ get; set; }

        public virtual DbSet<OrderItem> OrderItems{ get; set; }

        public virtual DbSet<Payment> Payments{ get; set; }
        //public virtual DbSet<>
       
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    if(!optionsBuilder.IsConfigured)
        //    {

        //        // optionsBuilder.UseSqlServer(@"Data Source=LAPTOP-63PEP4B9\MSSQLSERVER01;Initial Catalog=DeliveryDB;Integrated Security=True");
        //    }
    }
}
