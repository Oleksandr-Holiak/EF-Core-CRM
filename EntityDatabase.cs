using EF_Core_CRM.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_CRM
{
    class EntityDatabase : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
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
