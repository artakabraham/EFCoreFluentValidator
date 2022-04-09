using EFCore.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCore.Data
{
    public class OnlineShopDbContext : DbContext
    {
        public OnlineShopDbContext(DbContextOptions<OnlineShopDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<ProductOrder> ProductOrder { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData
                (
                    new Product() { Id = 1, Name = "Apple iPad", Price = 1000 },
                    new Product() { Id = 2, Name = "Samsung Smart TV", Price = 1500 },
                    new Product() { Id = 3, Name = "Nokia 130", Price = 1200 }
                );
        }

    }
}
