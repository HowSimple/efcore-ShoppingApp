﻿using WebApplication1.Models;

using Microsoft.EntityFrameworkCore;

namespace WebApplication1.DAL
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options) : base(options)
        {
           // Database.EnsureCreated();
        }
//        public DbSet<Store> Stores { get; set; }
        public DbSet<Product> Products { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().ToTable("Product");
            //modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
