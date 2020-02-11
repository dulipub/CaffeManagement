using System;
using Microsoft.EntityFrameworkCore;
using System.Data;
using CaffeManagementCore.Models;
using CaffeManagementCore.Models.Helpers;

namespace CaffeManagementCore
{
    public class CaffeContext : DbContext
    {
        public CaffeContext(DbContextOptions options) : base(options) { }

        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<AddictionalCharge> AddictionalCharges { get; set; }

        //This will override default table generation
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
        }
    }
}
