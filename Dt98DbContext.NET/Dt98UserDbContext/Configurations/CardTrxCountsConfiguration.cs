
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities;

namespace Configurations
{
    public class CardTrxCountsConfiguration : IEntityTypeConfiguration<CardTrxCounts>
    {
        public void Configure(EntityTypeBuilder<CardTrxCounts> builder)
        {
            builder.ToTable("_sptCARDTRXCOUNTS");

            builder.HasKey(e => e.Oid);
            builder.Property(e => e.Oid).HasColumnName("OID");
            builder.Property(e => e.OidType).HasColumnName("OID_TYPE");
            builder.Property(e => e.Id).HasColumnName("ID");
            builder.Property(e => e.ResetDate).HasColumnName("RESETDATE");
        }
    }
}
