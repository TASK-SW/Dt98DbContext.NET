
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities;

namespace Configurations
{
    public class OpTotalProductMapConfiguration : IEntityTypeConfiguration<OpTotalProductMap>
    {
        public void Configure(EntityTypeBuilder<OpTotalProductMap> builder)
        {
            builder.ToTable("_sptOPTOTAL_PRODUCTMAP");

            builder.HasKey(e => e.Oid);
            builder.Property(e => e.Oid).HasColumnName("OID");
            builder.Property(e => e.ArticleId).HasColumnName("ARTICLE_ID");
            builder.Property(e => e.ProductId).HasColumnName("PRODUCT_ID");
        }
    }
}
