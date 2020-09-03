using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StoreApp.Models;

namespace StoreApp.Data
{
    public class StoreAppContext : DbContext
    {
        public StoreAppContext (DbContextOptions<StoreAppContext> options)
            : base(options)
        {
        }

        // DbSet for LINQ Queries for Customers
        public DbSet<StoreApp.Models.Customers> Customers { get; set; }
        // DbSet for LINQ Queries for Orders
        public DbSet<StoreApp.Models.Orders> Orders { get; set; }
        // DbSet for LINQ Queries for Products
        public DbSet<StoreApp.Models.Products> Products { get; set; }
        // DbSet for LINQ Queries for OrderITem
        public DbSet<StoreApp.Models.OrderItem> OrderItem { get; set; }
    }
}
