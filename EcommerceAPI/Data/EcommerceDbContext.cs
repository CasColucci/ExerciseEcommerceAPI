using EcommerceAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace EcommerceAPI.Data
{
    public class EcommerceDbContext : DbContext 
    {
        public EcommerceDbContext(DbContextOptions<EcommerceDbContext> options) : base(options)
        {
            
        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "Laptop", Description = "A portable computer with a closing lid.", Price = 999, Category = Category.Electronics, CreatedDate = DateTime.Now},
                new Product { Id = 2, Name = "Band T-Shirt", Description = "A t-shirt with the logo of a popular band.", Price = 20, Category = Category.Clothing, CreatedDate = DateTime.Today.AddDays(-2)},
                new Product { Id = 3, Name = "Blender", Description = "A kitchen tool used to emulsify food.", Price = 35, Category = Category.Kitchen, CreatedDate = DateTime.Today.AddDays(-3) },
                new Product { Id = 4, Name = "Lipstick", Description = "A tube of lipstick in a bright red color.", Price = 15, Category = Category.Beauty, CreatedDate = DateTime.Today.AddDays(-4) }
                );
        }
    }
}
