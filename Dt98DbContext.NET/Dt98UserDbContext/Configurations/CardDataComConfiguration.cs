
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Configurations
{
    public class CardDataComConfiguration : IEntityTypeConfiguration<CardDataCom>
    {
        public void Configure(EntityTypeBuilder<CardDataCom> builder)
        {
            builder.ToTable("_sptCARDDATACOM");

            builder.HasKey(e => e.Oid);
            builder.Property(e => e.Oid).HasColumnName("OID");
            builder.Property(e => e.DtCardTypeId).HasColumnName("DT_CARD_TYPE_ID");
            builder.Property(e => e.DtRoundOpTotal).HasColumnName("DT_ROUND_OPTOTAL");
            builder.Property(e => e.DtRoundTrx).HasColumnName("DT_ROUND_TRX");
            builder.Property(e => e.DtXmitLimitOutdoor).HasColumnName("DT_XMIT_LIMIT_OUTDOOR");
            builder.Property(e => e.DtLimitOutdoor).HasColumnName("DT_LIMIT_OUTDOOR");
            builder.Property(e => e.DtLimitTotal).HasColumnName("DT_LIMIT_TOTAL");
            builder.Property(e => e.DtAcceptance).HasColumnName("DT_ACCEPTANCE");
            builder.Property(e => e.DtXmitOnlineAuth).HasColumnName("DT_XMIT_ONLINE_AUTH");
            builder.Property(e => e.DtOnlineAuth).HasColumnName("DT_ONLINE_AUTH");
            builder.Property(e => e.DtXmitPinAuth).HasColumnName("DT_XMIT_PIN_AUTH");
            builder.Property(e => e.DtPinAuth).HasColumnName("DT_PIN_AUTH");
            builder.Property(e => e.PanStripBlackList).HasColumnName("PAN_STRIP_BLACKLIST");
            builder.Property(e => e.PanStripTransAct).HasColumnName("PAN_STRIP_TRANSACT");
            builder.Property(e => e.TrxDelivMask).HasColumnName("TRXDELIVMASK");
        }
    }
}
