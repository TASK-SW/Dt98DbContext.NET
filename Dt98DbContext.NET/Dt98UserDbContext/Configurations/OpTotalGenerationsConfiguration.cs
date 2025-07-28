
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities;

namespace Configurations
{
    public class OpTotalGenerationsConfiguration : IEntityTypeConfiguration<OpTotalGenerations>
    {
        public void Configure(EntityTypeBuilder<OpTotalGenerations> builder)
        {
            builder.ToTable("OPTOTALGENERATIONS");

            builder.HasKey(e => new { e.OidHost, e.Generation });
            builder.Property(e => e.OidHost).HasColumnName("OID_HOST");
            builder.Property(e => e.Generation).HasColumnName("GENERATION");
            builder.Property(e => e.CycleStart).HasColumnName("CYCLESTART");
            builder.Property(e => e.CycleEnd).HasColumnName("CYCLEEND");
            builder.Property(e => e.CreationStart).HasColumnName("CREATIONSTART");
            builder.Property(e => e.CreationEnd).HasColumnName("CREATIONEND");
            builder.Property(e => e.DeliveryDate).HasColumnName("DELIVERYDATE");
        }
    }
}
