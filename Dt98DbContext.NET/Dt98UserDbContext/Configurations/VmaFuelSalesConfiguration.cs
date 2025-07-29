
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Configurations
{
    public class VmaFuelSalesConfiguration : IEntityTypeConfiguration<VmaFuelSales>
    {
        public void Configure(EntityTypeBuilder<VmaFuelSales> builder)
        {
            builder.ToTable("VMA_FuelSales");

            builder.HasKey(e => e.Oid);
            builder.Property(e => e.Oid).HasColumnName("OID");
            builder.Property(e => e.EntryTime).HasColumnName("EntryTime");
            builder.Property(e => e.AuthorizationTime).HasColumnName("AuthorizationTime");
            builder.Property(e => e.FuelStartTime).HasColumnName("FuelStartTime");
            builder.Property(e => e.FuelEndTime).HasColumnName("FuelEndTime");
            builder.Property(e => e.TerminalId).HasColumnName("TerminalId");
            builder.Property(e => e.PaymentType).HasColumnName("PaymentType");
            builder.Property(e => e.ProductId).HasColumnName("ProductId");
            builder.Property(e => e.FuelPointId).HasColumnName("FuelPointId");
            builder.Property(e => e.NozzleId).HasColumnName("NozzleId");
            builder.Property(e => e.Amount).HasColumnName("Amount");
            builder.Property(e => e.Volume).HasColumnName("Volume");
            builder.Property(e => e.UnitPrice).HasColumnName("UnitPrice");
            builder.Property(e => e.HostDeliveryState).HasColumnName("HostDeliveryState");
        }
    }
}
