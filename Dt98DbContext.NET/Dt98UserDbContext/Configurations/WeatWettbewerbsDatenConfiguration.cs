
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Configurations
{
    public class WeatWettbewerbsDatenConfiguration : IEntityTypeConfiguration<WeatWettbewerbsDaten>
    {
        public void Configure(EntityTypeBuilder<WeatWettbewerbsDaten> builder)
        {
            builder.ToTable("WEAT_WettbewerbsDaten");

            builder.HasKey(e => e.Oid);
            builder.Property(e => e.Oid).HasColumnName("OID");
            builder.Property(e => e.OidWettBewerber).HasColumnName("OID_WETTBEWERBER");
            builder.Property(e => e.ProductId).HasColumnName("ProductId");
            builder.Property(e => e.UnitPrice).HasColumnName("UnitPrice");
            builder.Property(e => e.DateTime).HasColumnName("DateTime");
        }
    }
}
