
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities;

namespace Configurations
{
    public class MtsConfiguration : IEntityTypeConfiguration<Mts>
    {
        public void Configure(EntityTypeBuilder<Mts> builder)
        {
            builder.ToTable("MTS");

            builder.HasKey(e => e.Oid);
            builder.Property(e => e.Oid).HasColumnName("OID");
            builder.Property(e => e.ProductSign).HasColumnName("ProductSign");
            builder.Property(e => e.ProductCode).HasColumnName("ProductCode");
            builder.Property(e => e.NewPrice).HasColumnName("NewPrice");
            builder.Property(e => e.OldPrice).HasColumnName("OldPrice");
            builder.Property(e => e.ServiceMode).HasColumnName("ServiceMode");
            builder.Property(e => e.DateTime).HasColumnName("DateTime");
            builder.Property(e => e.OrderNumber).HasColumnName("OrderNumber");
            builder.Property(e => e.HostDeliveryState).HasColumnName("HostDeliveryState");
        }
    }
}
