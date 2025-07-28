
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities;

namespace Configurations
{
    public class VmaTankContentsConfiguration : IEntityTypeConfiguration<VmaTankContents>
    {
        public void Configure(EntityTypeBuilder<VmaTankContents> builder)
        {
            builder.ToTable("VMA_TankContents");

            builder.HasKey(e => new { e.TankId, e.ProductId, e.ProcessingTime, e.VmaSeqNumber, e.VmaType, e.VmaTypeSeqNumber, e.OrderNumber, e.TankContentsType });
            builder.Property(e => e.TankId).HasColumnName("TankId");
            builder.Property(e => e.ProductId).HasColumnName("ProductId");
            builder.Property(e => e.ProcessingTime).HasColumnName("ProcessingTime");
            builder.Property(e => e.VmaSeqNumber).HasColumnName("VMASeqNumber");
            builder.Property(e => e.VmaType).HasColumnName("VMAType");
            builder.Property(e => e.VmaTypeSeqNumber).HasColumnName("VMATypeSeqNumber");
            builder.Property(e => e.OrderNumber).HasColumnName("OrderNumber");
            builder.Property(e => e.TankContentsType).HasColumnName("TankContentsType");
            builder.Property(e => e.HostDeliveryState).HasColumnName("HostDeliveryState");
            builder.Property(e => e.TankContents).HasColumnName("TankContents");
            builder.Property(e => e.ProductLevel).HasColumnName("ProductLevel");
            builder.Property(e => e.WaterLevel).HasColumnName("WaterLevel");
            builder.Property(e => e.WaterVolume).HasColumnName("WaterVolume");
            builder.Property(e => e.Temperature).HasColumnName("Temperature");
            builder.Property(e => e.Density).HasColumnName("Density");
        }
    }
}
