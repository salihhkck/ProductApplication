using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductApp.Core;

namespace ProductApp.Repository.Seeds;

internal class CategorySeed : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.HasData(
            new Category { Id = 1, Name = "Monitör" }, 
            new Category { Id = 2, Name = "Mouse" }, 
            new Category { Id = 3, Name = "Klavye" }
            );
    }
}
