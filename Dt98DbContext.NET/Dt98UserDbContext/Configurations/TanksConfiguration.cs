
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities;

namespace Configurations
{
    public class TanksConfiguration : IEntityTypeConfiguration<Tanks>
    {
        public void Configure(EntityTypeBuilder<Tanks> builder)
        {
            builder.ToTable("_sptTANKS");

            builder.HasKey(e => e.Oid);
            builder.Property(e => e.Oid).HasColumnName("OID");
            builder.Property(e => e.OidType).HasColumnName("OID_TYPE");
            builder.Property(e => e.OidArticle).HasColumnName("OID_ARTICLE");
            builder.Property(e => e.OidTankLevelTab).HasColumnName("OID_TANKLEVELTAB");
            builder.Property(e => e.Id).HasColumnName("ID");
            builder.Property(e => e.Volume).HasColumnName("VOLUME");
            builder.Property(e => e.Length).HasColumnName("LENGTH");
            builder.Property(e => e.Height).HasColumnName("HEIGHT");
            builder.Property(e => e.Width).HasColumnName("WIDTH");
        }
    }
}
