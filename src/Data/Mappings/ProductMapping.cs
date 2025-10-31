using BugStore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BugStore.Data.Mappings;

public class ProductMapping : IEntityTypeConfiguration<Product>{
    public void Configure(EntityTypeBuilder<Product> builder){
        builder.ToTable("Products");
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Title)
            .IsRequired()
            .HasColumnType("NVARCHAR")
            .HasMaxLength(180);

        builder.Property(x => x.Slug)
            .IsRequired()
            .HasColumnType("NVARCHAR")
            .HasMaxLength(180);

        builder.Property(x => x.Price)
            .IsRequired()
            .HasColumnType("MONEY");
    }
}