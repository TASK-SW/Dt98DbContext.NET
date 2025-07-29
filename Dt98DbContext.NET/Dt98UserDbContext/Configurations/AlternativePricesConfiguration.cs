using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Configurations;

public class AlternativePricesConfiguration : IEntityTypeConfiguration<AlternativePrices>
{
    #region Public Methods

    public void Configure(EntityTypeBuilder<AlternativePrices> builder)
    {
        builder.ToTable("AlternativePrices");

        builder.HasKey(a => new { a.OidArticle, a.PriceId });

        builder.Property(a => a.OidArticle)
            .HasColumnName("OIDArticle");

        builder.Property(a => a.PriceId)
            .HasColumnName("PriceId");

        builder.Property(a => a.SalesPrice)
            .HasColumnName("SalesPrice");
    }

    #endregion Public Methods
}