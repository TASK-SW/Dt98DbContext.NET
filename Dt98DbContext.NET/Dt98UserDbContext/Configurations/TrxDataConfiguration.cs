
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities;

namespace Configurations
{
    public class TrxDataConfiguration : IEntityTypeConfiguration<TrxData>
    {
        public void Configure(EntityTypeBuilder<TrxData> builder)
        {
            builder.ToTable("TRXDATA");

            builder.HasKey(e => new { e.OidTrx, e.Generation, e.DtSequence });
            builder.Property(e => e.OidTrx).HasColumnName("OID_TRX");
            builder.Property(e => e.Generation).HasColumnName("GENERATION");
            builder.Property(e => e.DtSequence).HasColumnName("DT_SEQUENCE");
            builder.Property(e => e.DtTotalAmount).HasColumnName("DT_TOTALAMOUNT");
            builder.Property(e => e.DtDate).HasColumnName("DT_DATE");
            builder.Property(e => e.DtJourHead).HasColumnName("DT_JOURHEAD");
            builder.Property(e => e.DtTransAct).HasColumnName("DT_TRANSACT");
        }
    }
}
