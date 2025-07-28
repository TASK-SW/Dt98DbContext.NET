
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities;

namespace Configurations
{
    public class CodeVouchersConfiguration : IEntityTypeConfiguration<CodeVouchers>
    {
        public void Configure(EntityTypeBuilder<CodeVouchers> builder)
        {
            builder.ToTable("CodeVouchers");

            builder.HasKey(e => new { e.VoucherCode, e.VoucherType, e.EanCode });
            builder.Property(e => e.VoucherCode).HasColumnName("VoucherCode");
            builder.Property(e => e.VoucherType).HasColumnName("VoucherType");
            builder.Property(e => e.ItemId).HasColumnName("ItemId");
            builder.Property(e => e.ParValue).HasColumnName("ParValue");
            builder.Property(e => e.ExpirationDate).HasColumnName("ExpirationDate");
            builder.Property(e => e.RedemptionDate).HasColumnName("RedemptionDate");
            builder.Property(e => e.EanCode).HasColumnName("EANCode");
            builder.Property(e => e.ValidFromDate).HasColumnName("ValidFromDate");
            builder.Property(e => e.CreationSiteId).HasColumnName("CreationSiteId");
            builder.Property(e => e.CreationDate).HasColumnName("CreationDate");
            builder.Property(e => e.IsScanned).HasColumnName("IsScanned");
            builder.Property(e => e.VoucherSeqNo).HasColumnName("VoucherSeqNo");
        }
    }
}
