using BugStore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BugStore.Data.Mappings;

public class OrderLineMapping: IEntityTypeConfiguration<OrderLine>{
    public void Configure(EntityTypeBuilder<OrderLine> builder){
        builder.ToTable("OrderLines");
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Quantity)
            .IsRequired()
            .HasColumnType("INTEGER");

        builder.Property(x => x.Total)
            .IsRequired()
            .HasColumnType("DECIMAL");

        builder.Property(x => x.ProductId)
            .IsRequired()
            .HasColumnType("VARCHAR")
            .HasMaxLength(160);

    }

}