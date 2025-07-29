
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Configurations
{
    public class OpTotalBaseMatrixConfiguration : IEntityTypeConfiguration<OpTotalBaseMatrix>
    {
        public void Configure(EntityTypeBuilder<OpTotalBaseMatrix> builder)
        {
            builder.ToTable("_sptOPTOTAL_BASEMATRIX");

            builder.HasKey(e => e.Oid);
            builder.Property(e => e.Oid).HasColumnName("OID");
            builder.Property(e => e.DtProductId).HasColumnName("DT_PRODUCT_ID");
            builder.Property(e => e.DtTransactionId).HasColumnName("DT_TRANSACTION_ID");
            builder.Property(e => e.DtType).HasColumnName("DT_TYPE");
        }
    }
}
