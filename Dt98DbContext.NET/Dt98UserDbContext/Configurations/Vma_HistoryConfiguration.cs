
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities;

namespace Configurations
{
    public class Vma_HistoryConfiguration : IEntityTypeConfiguration<Vma_History>
    {
        public void Configure(EntityTypeBuilder<Vma_History> builder)
        {
            builder.ToTable("VMA_History");

            builder.HasKey(e => new { e.ProductId, e.FuelPointId, e.NozzleId, e.TankId, e.ProcessingTime, e.VmaSeqNumber, e.VmaType, e.VmaTypeSeqNumber, e.OrderNumber });
            builder.Property(e => e.ProductId).HasColumnName("ProductId");
            builder.Property(e => e.FuelPointId).HasColumnName("FuelPointId");
            builder.Property(e => e.NozzleId).HasColumnName("NozzleId");
            builder.Property(e => e.TankId).HasColumnName("TankId");
            builder.Property(e => e.ProcessingTime).HasColumnName("ProcessingTime");
            builder.Property(e => e.VmaSeqNumber).HasColumnName("VMASeqNumber");
            builder.Property(e => e.VmaType).HasColumnName("VMAType");
            builder.Property(e => e.VmaTypeSeqNumber).HasColumnName("VMATypeSeqNumber");
            builder.Property(e => e.OrderNumber).HasColumnName("OrderNumber");
            builder.Property(e => e.Status).HasColumnName("Status");
            builder.Property(e => e.HostDeliveryState).HasColumnName("HostDeliveryState");
            builder.Property(e => e.PlannedTime).HasColumnName("PlannedTime");
            builder.Property(e => e.UnitPrice).HasColumnName("UnitPrice");
            builder.Property(e => e.NewUnitPrice).HasColumnName("NewUnitPrice");
            builder.Property(e => e.Volume).HasColumnName("Volume");
            builder.Property(e => e.Amount).HasColumnName("Amount");
            builder.Property(e => e.ResultCode).HasColumnName("ResultCode");
        }
    }
}
