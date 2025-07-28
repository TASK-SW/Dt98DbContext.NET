
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities;

namespace Configurations
{
    public class VmaCurrentConfiguration : IEntityTypeConfiguration<VmaCurrent>
    {
        public void Configure(EntityTypeBuilder<VmaCurrent> builder)
        {
            builder.ToTable("VMA_Current");

            builder.HasKey(e => new { e.ProductId, e.FuelPointId, e.NozzleId, e.TankId });
            builder.Property(e => e.ProductId).HasColumnName("ProductId");
            builder.Property(e => e.FuelPointId).HasColumnName("FuelPointId");
            builder.Property(e => e.NozzleId).HasColumnName("NozzleId");
            builder.Property(e => e.TankId).HasColumnName("TankId");
            builder.Property(e => e.Volume).HasColumnName("Volume");
            builder.Property(e => e.Amount).HasColumnName("Amount");
        }
    }
}
