using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductApp.Core;

namespace ProductApp.Repository.Configurations;

internal class CategoryConfiguration 
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x=>x.Id).UseIdentityColumn();
        builder.Property(x=>x.Name).IsRequired().HasMaxLength(50);

        builder.ToTable("Categories");
    }
}
