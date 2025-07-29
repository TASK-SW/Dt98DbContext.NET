
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Configurations
{
    public class FuelIngPointsConfiguration : IEntityTypeConfiguration<FuelIngPoints>
    {
        public void Configure(EntityTypeBuilder<FuelIngPoints> builder)
        {
            builder.ToTable("_sptFUELINGPOINTS");

            builder.HasKey(e => e.Oid);
            builder.Property(e => e.Oid).HasColumnName("OID");
            builder.Property(e => e.OidType).HasColumnName("OID_TYPE");
            builder.Property(e => e.OidPump).HasColumnName("OID_PUMP");
            builder.Property(e => e.Id).HasColumnName("ID");
            builder.Property(e => e.ExternNumber).HasColumnName("EXTERNNUMBER");
        }
    }
}
