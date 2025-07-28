
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities;

namespace Configurations
{
    public class VmaRecordsConfiguration : IEntityTypeConfiguration<VmaRecords>
    {
        public void Configure(EntityTypeBuilder<VmaRecords> builder)
        {
            builder.ToTable("VMARECORDS");

            builder.HasKey(e => new { e.ProductId, e.FuelpointId, e.NozzleId, e.TsBegin });
            builder.Property(e => e.ProductId).HasColumnName("ProductId");
            builder.Property(e => e.FuelpointId).HasColumnName("FuelpointId");
            builder.Property(e => e.NozzleId).HasColumnName("NozzleId");
            builder.Property(e => e.TsBegin).HasColumnName("TSBegin");
            builder.Property(e => e.Tsend).HasColumnName("TSEnd");
            builder.Property(e => e.OldPrice).HasColumnName("OldPrice");
            builder.Property(e => e.NewPrice).HasColumnName("NewPrice");
            builder.Property(e => e.Volume).HasColumnName("Volume");
            builder.Property(e => e.Amount).HasColumnName("Amount");
            builder.Property(e => e.HostDeliveryState).HasColumnName("HostDeliveryState");
            builder.Property(e => e.OrderNumber).HasColumnName("OrderNumber");
            builder.Property(e => e.TsPlanned).HasColumnName("TSPlanned");
        }
    }
}
