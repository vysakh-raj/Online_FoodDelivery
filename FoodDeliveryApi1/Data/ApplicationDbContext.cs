using FoodDeliveryApi1.Models;
using Microsoft.EntityFrameworkCore;

namespace FoodDeliveryApi1.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
     : base(options)
        {
            ChangeTracker.LazyLoadingEnabled = false;
        }


        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Order> Orders { get; set; }

    }

}
