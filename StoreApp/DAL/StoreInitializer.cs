using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using WebApplication1.Models;
namespace WebApplication1.DAL
{
    public static class  StoreInitializer
    {
        public static void Initialize(StoreContext context)
        {
            var products = new List<Product>
            {
            new Product{Name="Coffee", QuantityAvailable=3, Price= 3.50m,DateAdded=DateTime.Parse("2005-09-01")},
            new Product{Name="Sandwich", QuantityAvailable=3, Price= 10.00m,DateAdded=DateTime.Parse("2005-09-02")},
            new Product{Name="Book", QuantityAvailable=3, Price= 15.50m,DateAdded=DateTime.Parse("2005-09-04")},

            };
            products.ForEach(s => context.Products.Add(s));
            context.SaveChanges();

        }
    }
}
