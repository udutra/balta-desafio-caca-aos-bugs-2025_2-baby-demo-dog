using BugStore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BugStore.Data.Mappings;

public class CustomerMapping : IEntityTypeConfiguration<Customer>{
    public void Configure(EntityTypeBuilder<Customer> builder){
        builder.ToTable("Customers");
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Name)
            .IsRequired()
            .HasColumnType("NVARCHAR")
            .HasMaxLength(150);

        builder.Property(x => x.Email)
            .IsRequired()
            .HasColumnType("NVARCHAR")
            .HasMaxLength(150);

        builder.Property(x => x.Phone)
            .IsRequired()
            .HasColumnType("NVARCHAR")
            .HasMaxLength(11);
        builder.Property(x => x.BirthDate)
            .IsRequired();
    }
}