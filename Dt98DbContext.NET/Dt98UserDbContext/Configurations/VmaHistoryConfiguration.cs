
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Configurations
{
    public class VmaHistoryConfiguration : IEntityTypeConfiguration<VmaHistory>
    {
        public void Configure(EntityTypeBuilder<VmaHistory> builder)
        {
            builder.ToTable("VMAHISTORY");

            builder.HasKey(e => new { e.ProductId, e.VmaType, e.DateTime, e.OrderNumber });
            builder.Property(e => e.ProductId).HasColumnName("ProductId");
            builder.Property(e => e.VmaType).HasColumnName("VMAType");
            builder.Property(e => e.DateTime).HasColumnName("DateTime");
            builder.Property(e => e.OrderNumber).HasColumnName("OrderNumber");
            builder.Property(e => e.UnitPrice).HasColumnName("UnitPrice");
            builder.Property(e => e.HostDeliveryState).HasColumnName("HostDeliveryState");
            builder.Property(e => e.Volume).HasColumnName("Volume");
            builder.Property(e => e.Amount).HasColumnName("Amount");
            builder.Property(e => e.VolumePeriod).HasColumnName("VolumePeriod");
            builder.Property(e => e.AmountPeriod).HasColumnName("AmountPeriod");
            builder.Property(e => e.NewUnitPrice).HasColumnName("NewUnitPrice");
            builder.Property(e => e.TsBegin).HasColumnName("TSBegin");
            builder.Property(e => e.TsPlanned).HasColumnName("TSPlanned");
            builder.Property(e => e.DeltaVolume).HasColumnName("DeltaVolume");
            builder.Property(e => e.DeltaAmount).HasColumnName("DeltaAmount");
            builder.Property(e => e.LastDateTime).HasColumnName("LastDateTime");
        }
    }
}
