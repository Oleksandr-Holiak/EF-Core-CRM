using EF_Core_CRM.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_CRM.Database
{
    class EntityDatabase : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            AppSettings.LoadConfiguraion();

            optionsBuilder.
                UseSqlServer(Environment.GetEnvironmentVariable("DbConnectionString"));
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Customer>()
                .HasAlternateKey(c => c.Email);


            modelBuilder
                .Entity<User>()
                .HasAlternateKey(u => u.Email);


            modelBuilder
                .Entity<Order>()
                .HasMany(o => o.OrderItems)
                .WithOne(oi => oi.Order);
        }
    }
}
