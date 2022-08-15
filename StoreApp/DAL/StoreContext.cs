
using Microsoft.EntityFrameworkCore;
using StoreApp.Models;

namespace StoreApp.DAL
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options) : base(options)
        {
            // Database.EnsureCreated();
        }
        //        public DbSet<Store> Stores { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().ToTable("Product");
            //modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
