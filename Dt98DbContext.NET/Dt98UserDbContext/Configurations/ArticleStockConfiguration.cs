using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Configurations
{
    public class ArticleStockConfiguration : IEntityTypeConfiguration<ArticleStock>
    {
        #region Public Methods

        public void Configure(EntityTypeBuilder<ArticleStock> builder)
        {
            builder.ToTable("ArticleStock");

            builder.HasKey(a => new { a.OidArticle, a.WorkstationId });

            builder.Property(a => a.OidArticle)
                .HasColumnName("OIDArticle");

            builder.Property(a => a.WorkstationId)
                .HasColumnName("WorkstationId");

            builder.Property(a => a.CurrentQuantity)
                .HasColumnName("CurrentQuantity");

            builder.Property(a => a.OpenQuantity)
                .HasColumnName("OpenQuantity");
        }

        #endregion Public Methods
    }
}