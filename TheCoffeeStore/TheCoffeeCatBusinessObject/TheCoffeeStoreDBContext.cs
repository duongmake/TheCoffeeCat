using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TheCoffeeCatBusinessObject.BusinessObject;

namespace TheCoffeeCatBusinessObject
{
    public class TheCoffeeStoreDBContext : DbContext 
    {
        public TheCoffeeStoreDBContext()
        {

        }
        public TheCoffeeStoreDBContext(DbContextOptions<TheCoffeeStoreDBContext> opt) : base(opt) { }

        public DbSet<Cat> Cats { get; set; }
        public DbSet<CatProduct> CatProducts { get; set; }
        public DbSet<CoffeeShop>  CofffeeShops { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Drink> Drinks { get; set; }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Staff> Staffs { get; set; }

        public DbSet<Subscription> Subscriptions { get; set; }

        public DbSet<Table> Tables { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderDetail> OrderDetails { get; set; }




        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(builder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(GetConnectionString());
        }

        private string GetConnectionString()
        {
            IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true)
                .Build();
            return config["ConnectionStrings:DB"]!;
        }
    }
}
