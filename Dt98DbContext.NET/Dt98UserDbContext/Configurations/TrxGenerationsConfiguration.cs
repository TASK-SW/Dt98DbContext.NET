
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Configurations
{
    public class TrxGenerationsConfiguration : IEntityTypeConfiguration<TrxGenerations>
    {
        public void Configure(EntityTypeBuilder<TrxGenerations> builder)
        {
            builder.ToTable("TRXGENERATIONS");

            builder.HasKey(e => new { e.OidTrx, e.Generation });
            builder.Property(e => e.OidTrx).HasColumnName("OID_TRX");
            builder.Property(e => e.Generation).HasColumnName("GENERATION");
            builder.Property(e => e.StartDate).HasColumnName("STARTDATE");
            builder.Property(e => e.EndDate).HasColumnName("ENDDATE");
            builder.Property(e => e.DeliveryDate).HasColumnName("DELIVERYDATE");
        }
    }
}
