using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Configurations
{
    public class EanCodesConfiguration : IEntityTypeConfiguration<EanCodes>
    {
        #region Public Methods

        public void Configure(EntityTypeBuilder<EanCodes> builder)
        {
            builder.ToTable("EANCODES");

            builder.HasKey(e => e.EanCode);
            builder.Property(e => e.EanCode).HasColumnName("EANCODE");
            builder.Property(e => e.OidArticle).HasColumnName("OID_ARTICLE");
            builder.Property(e => e.SalesPrice).HasColumnName("SALES_PRICE");

            builder.HasOne(e => e.Article)
                .WithMany(a => a.EanCodes)
                .HasForeignKey(e => e.OidArticle);
        }

        #endregion Public Methods
    }
}