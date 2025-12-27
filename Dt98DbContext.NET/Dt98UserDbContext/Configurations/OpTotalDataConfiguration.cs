using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Configurations
{
    public class OpTotalDataConfiguration : IEntityTypeConfiguration<OpTotalData>
    {
        #region Public Methods

        public void Configure(EntityTypeBuilder<OpTotalData> builder)
        {
            builder.ToTable("OPTOTALDATA");

            builder.HasKey(e => e.Oid);
            builder.Property(e => e.Oid).HasColumnName("OID");
            builder.Property(e => e.OidHost).HasColumnName("OID_HOST");
            builder.Property(e => e.Generation).HasColumnName("GENERATION");
            builder.Property(e => e.DtType).HasColumnName("DT_TYPE");
            builder.Property(e => e.DtTransactionId).HasColumnName("DT_TRANSACTION_ID");
            builder.Property(e => e.DtProductId).HasColumnName("DT_PRODUCT_ID");
            builder.Property(e => e.DtAmount).HasColumnName("DT_AMOUNT");
            builder.Property(e => e.DtQuantity).HasColumnName("DT_QUANTITY");
            builder.Property(e => e.UnitCode).HasColumnName("UNITCODE");
            builder.Property(e => e.DtCount).HasColumnName("DT_COUNT");
        }

        #endregion Public Methods
    }
}