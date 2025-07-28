
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities;

namespace Configurations
{
    public class ScaledDiscountConfiguration : IEntityTypeConfiguration<ScaledDiscount>
    {
        public void Configure(EntityTypeBuilder<ScaledDiscount> builder)
        {
            builder.ToTable("ScaledDiscount");

            builder.HasKey(e => new { e.ItemId, e.Threshold });
            builder.Property(e => e.ItemId).HasColumnName("ItemId");
            builder.Property(e => e.Threshold).HasColumnName("Threshold");
            builder.Property(e => e.Type).HasColumnName("Type");
            builder.Property(e => e.Amount).HasColumnName("Amount");
        }
    }
}
