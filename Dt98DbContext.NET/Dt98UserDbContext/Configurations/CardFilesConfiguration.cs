
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities;

namespace Configurations
{
    public class CardFilesConfiguration : IEntityTypeConfiguration<CardFiles>
    {
        public void Configure(EntityTypeBuilder<CardFiles> builder)
        {
            builder.ToTable("_sptCARDFILES");

            builder.HasKey(e => e.Oid);
            builder.Property(e => e.Oid).HasColumnName("OID");
            builder.Property(e => e.OidBlackList).HasColumnName("OID_BLACKLIST");
            builder.Property(e => e.OidGreyList).HasColumnName("OID_GREYLIST");
            builder.Property(e => e.OidRedList).HasColumnName("OID_REDLIST");
            builder.Property(e => e.OidCardDlyTotal).HasColumnName("OID_CARDDLYTOTAL");
            builder.Property(e => e.OidCardTrxCount).HasColumnName("OID_CARDTRXCOUNT");
            builder.Property(e => e.OidTrxFile).HasColumnName("OID_TRXFILE");
            builder.Property(e => e.OidHost).HasColumnName("OID_HOST");
            builder.Property(e => e.OidCardDataCom).HasColumnName("OID_CARDDATACOM");
            builder.Property(e => e.OidForeignTrx).HasColumnName("OID_FOREIGNTRX");
        }
    }
}
