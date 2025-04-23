using dbTable.Models;
using Microsoft.EntityFrameworkCore;

namespace dbTable.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<ProductModel> Products { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ProductModel>().HasData(
                new ProductModel { Id = 1, Name = "Phone", Description = "New device", Price = 512.4f },
                new ProductModel { Id = 2, Name = "Laptop", Description = "Used before", Price = 123.4f },
                new ProductModel { Id = 3, Name = "TV", Description = "New type of TV", Price = 532.4f }
            );
        }
    }
}
