
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities;

namespace Configurations
{
    public class OpTotalPaymentMapConfiguration : IEntityTypeConfiguration<OpTotalPaymentMap>
    {
        public void Configure(EntityTypeBuilder<OpTotalPaymentMap> builder)
        {
            builder.ToTable("_sptOPTOTAL_PAYMENTMAP");

            builder.HasKey(e => e.Oid);
            builder.Property(e => e.Oid).HasColumnName("OID");
            builder.Property(e => e.OidPaymentType).HasColumnName("OID_PAYMENTTYPE");
            builder.Property(e => e.OidTerminalType).HasColumnName("OID_TERMINALTYPE");
            builder.Property(e => e.TransactionId).HasColumnName("TRANSACTION_ID");
        }
    }
}
