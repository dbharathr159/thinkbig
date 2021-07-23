using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DemoFoodApI.Entities
    {
        public class MyContext : DbContext
        {
            public virtual DbSet<Admin> Admins { get; set; }
            public virtual DbSet<Customer> Customers { get; set; }
            public virtual DbSet<Menu> Menus { get; set; }
            public virtual DbSet<Order> Orders { get; set; }

            public virtual DbSet<OrderItem> OrderItems { get; set; }

            public virtual DbSet<Payment> Payments { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source = LAPTOP-PCGA02RJ; Initial Catalog = DelivaryDB; Integrated Security = True");
        }
        }
}

