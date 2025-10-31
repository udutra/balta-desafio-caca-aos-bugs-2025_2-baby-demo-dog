using BugStore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BugStore.Data.Mappings;

public class OrderMapping : IEntityTypeConfiguration<Order>{

    public void Configure(EntityTypeBuilder<Order> builder){
        builder.ToTable("Orders");
        builder.HasKey(x => x.Id);

        builder.Property(x => x.CustomerId)
            .IsRequired()
            .HasColumnType("VARCHAR")
            .HasMaxLength(160);

        builder.Property(x => x.CreatedAt)
            .IsRequired();

        builder.Property(x => x.UpdatedAt)
            .IsRequired();
    }
}