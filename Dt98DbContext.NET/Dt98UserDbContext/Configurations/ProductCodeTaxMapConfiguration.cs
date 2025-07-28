
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities;

namespace Configurations
{
    public class ProductCodeTaxMapConfiguration : IEntityTypeConfiguration<ProductCodeTaxMap>
    {
        public void Configure(EntityTypeBuilder<ProductCodeTaxMap> builder)
        {
            builder.ToTable("_sptPRODUCTCODETAXMAP");

            builder.HasKey(e => new { e.Id, e.ExtCode });
            builder.Property(e => e.Id).HasColumnName("ID");
            builder.Property(e => e.ExtCode).HasColumnName("EXTCODE");
            builder.Property(e => e.VatOid).HasColumnName("VAT_OID");
            builder.Property(e => e.ProductCodeName).HasColumnName("PRODUCTCODENAME");
        }
    }
}
