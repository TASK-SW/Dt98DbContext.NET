
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Configurations
{
    public class ReceiptsToPrintConfiguration : IEntityTypeConfiguration<ReceiptsToPrint>
    {
        public void Configure(EntityTypeBuilder<ReceiptsToPrint> builder)
        {
            builder.ToTable("ReceiptsToPrint");

            builder.HasKey(e => e.OidJourHead);
            builder.Property(e => e.OidJourHead).HasColumnName("OID_JourHead");
            builder.Property(e => e.TerminalId).HasColumnName("TerminalId");
            builder.Property(e => e.ReceiptMsg).HasColumnName("ReceiptMsg");
            builder.Property(e => e.RetryPrintCount).HasColumnName("RetryPrintCount");
        }
    }
}
