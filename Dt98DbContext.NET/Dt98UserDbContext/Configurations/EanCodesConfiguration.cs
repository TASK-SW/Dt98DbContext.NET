
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities;

namespace Configurations
{
    public class EanCodesConfiguration : IEntityTypeConfiguration<EanCodes>
    {
        public void Configure(EntityTypeBuilder<EanCodes> builder)
        {
            builder.ToTable("EANCODES");

            builder.HasKey(e => e.EanCode);
            builder.Property(e => e.EanCode).HasColumnName("EANCODE");
            builder.Property(e => e.OidArticle).HasColumnName("OID_ARTICLE");
            builder.Property(e => e.SalesPrice).HasColumnName("SALES_PRICE");
        }
    }
}
