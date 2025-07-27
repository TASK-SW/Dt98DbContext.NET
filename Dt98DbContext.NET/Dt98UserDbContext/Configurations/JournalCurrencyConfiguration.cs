using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Configurations
{
    public class JournalCurrencyConfiguration : IEntityTypeConfiguration<JournalCurrency>
    {
        #region Public Methods

        public void Configure(EntityTypeBuilder<JournalCurrency> builder)
        {
            builder.ToTable("JOURNALCURRENCY");

            builder.HasKey(jc => new { jc.OidJournal, jc.IdCny });

            builder.Property(jc => jc.OidJournal).HasColumnName("OID_JOURNAL");
            builder.Property(jc => jc.IdCny).HasColumnName("ID_CNY");

            builder.HasOne(jc => jc.Header)
                .WithMany(jh => jh.JournalCurrency)
                .HasForeignKey(jc => jc.OidJournal)
                .HasPrincipalKey(jh => jh.Oid);

            builder.Property(jc => jc.SyCny).HasColumnName("SY_CNY");
            builder.Property(jc => jc.ExchgRateRcv).HasColumnName("EXCHG_RATE_RCV");
            builder.Property(jc => jc.ExchgRateRtn).HasColumnName("EXCHG_RATE_RTN");
            builder.Property(jc => jc.ExchgFee).HasColumnName("EXCHG_FEE");
            builder.Property(jc => jc.AmtSale).HasColumnName("AMT_SALE");
            builder.Property(jc => jc.AmtRcv).HasColumnName("AMT_RCV");
            builder.Property(jc => jc.AmtRtn).HasColumnName("AMT_RTN");
            builder.Property(jc => jc.TyTnd).HasColumnName("TY_TND");
            builder.Property(jc => jc.FlmAIntNd).HasColumnName("FL_MAIN_TND");
            builder.Property(jc => jc.LocalAmtRnd).HasColumnName("LOCAL_AMT_RND");
            builder.Property(jc => jc.DeTnd).HasColumnName("DE_TND");
        }

        #endregion Public Methods
    }
}