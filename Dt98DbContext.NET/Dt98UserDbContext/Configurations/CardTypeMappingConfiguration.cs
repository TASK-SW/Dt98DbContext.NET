
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities;

namespace Configurations
{
    public class CardTypeMappingConfiguration : IEntityTypeConfiguration<CardTypeMapping>
    {
        public void Configure(EntityTypeBuilder<CardTypeMapping> builder)
        {
            builder.ToTable("_sctCARDTYPEMAPPING");

            builder.HasKey(e => e.Oid);
            builder.Property(e => e.Oid).HasColumnName("OID");
            builder.Property(e => e.TypeBof).HasColumnName("TYPE_BOF");
            builder.Property(e => e.BofName).HasColumnName("BOF_NAME");
            builder.Property(e => e.BofId).HasColumnName("BOF_ID");
        }
    }
}
