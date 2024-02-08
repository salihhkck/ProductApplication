using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductApp.Core;

namespace ProductApp.Repository.Seeds;

internal class ProductSeed : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.HasData(new Product
        {
            Id = 1,
            CategoryId = 1,
            Name= "HP Led Monitör",
            Price = 9000,
            Stock=25,
            CreatedDate = DateTime.Now
        },
        new Product
        {
            Id = 2,
            CategoryId = 2,
            Name = "Rampage Gaming Mouse",
            Price = 1200,
            Stock = 12,
            CreatedDate = DateTime.Now
        },
        new Product
        {
            Id = 3,
            CategoryId = 3,
            Name = "Logitech MX Klavye",
            Price = 6000,
            Stock = 25,
            CreatedDate = DateTime.Now
        },
        new Product
        {
            Id = 4,
            CategoryId = 1,
            Name = "Samsung Crystal Monitör",
            Price = 16000,
            Stock = 9,
            CreatedDate = DateTime.Now
        },
        new Product
        {
            Id = 5,
            CategoryId = 2,
            Name = "Bim Mouse",
            Price = 100,
            Stock = 65,
            CreatedDate = DateTime.Now
        });

    }
}
