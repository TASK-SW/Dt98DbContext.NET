
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities;

namespace Configurations
{
    public class VmaHistoryTankConfiguration : IEntityTypeConfiguration<VmaHistoryTank>
    {
        public void Configure(EntityTypeBuilder<VmaHistoryTank> builder)
        {
            builder.ToTable("VMAHISTORYTANK");

            builder.HasKey(e => new { e.ProductId, e.TankId, e.VmaType, e.DateTime, e.OrderNumber });
            builder.Property(e => e.ProductId).HasColumnName("ProductId");
            builder.Property(e => e.TankId).HasColumnName("TankId");
            builder.Property(e => e.VmaType).HasColumnName("VMAType");
            builder.Property(e => e.DateTime).HasColumnName("DateTime");
            builder.Property(e => e.OrderNumber).HasColumnName("OrderNumber");
            builder.Property(e => e.UnitPrice).HasColumnName("UnitPrice");
            builder.Property(e => e.UnitPriceNew).HasColumnName("UnitPriceNew");
            builder.Property(e => e.TankContent).HasColumnName("TankContent");
            builder.Property(e => e.TankMeter).HasColumnName("TankMeter");
            builder.Property(e => e.HostDeliveryState).HasColumnName("HostDeliveryState");
        }
    }
}
