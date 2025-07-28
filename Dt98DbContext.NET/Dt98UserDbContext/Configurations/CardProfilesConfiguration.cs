
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities;

namespace Configurations
{
    public class CardProfilesConfiguration : IEntityTypeConfiguration<CardProfiles>
    {
        public void Configure(EntityTypeBuilder<CardProfiles> builder)
        {
            builder.ToTable("_sptCARDPROFILES");

            builder.HasKey(e => e.Oid);
            builder.Property(e => e.Oid).HasColumnName("OID");
            builder.Property(e => e.OidCard).HasColumnName("OID_CARD");
            builder.Property(e => e.Id).HasColumnName("ID");
            builder.Property(e => e.DataSource).HasColumnName("DATASOURCE");
            builder.Property(e => e.CountErNo).HasColumnName("COUNTERNO");
        }
    }
}
