using MyShop.Core.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyShop.DataAccess.SQL
{
    public class DataContext : DbContext
    {
        // Look for <connectionStrings><add name="DefaultConnection" ...
        // in Myshop.WebUI\Web.config or
        // in MyShop.DataAccess.SQL\App.config
        public DataContext()
            : base("DefaultConnection") 
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<Basket> Baskets { get; set; }
        public DbSet<BasketItem> BasketItems { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
    }
}
