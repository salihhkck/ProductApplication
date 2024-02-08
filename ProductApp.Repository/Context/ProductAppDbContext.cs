using Microsoft.EntityFrameworkCore;
using ProductApp.Core;
using System.Reflection;

namespace ProductApp.Repository.Context;

public class ProductAppDbContext : DbContext
{
    public ProductAppDbContext(DbContextOptions<ProductAppDbContext> options) : base(options)
    {

    }

    DbSet<Category> Categories { get; set; }
    DbSet<Product> Products { get; set; }
    DbSet<ProductFeature> ProductFeatures { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        modelBuilder.Entity<ProductFeature>().HasData(new ProductFeature()
        {
            Id = 1,
            Color = "Kırmızı",
            Height = 100,
            Width = 100,
            ProductId = 2,
        },

        new ProductFeature()
        {
            Id = 2,
            Color = "Siyah",
            Height = 100,
            Width = 150,
            ProductId = 1
        });

        base.OnModelCreating(modelBuilder);
    }
}
