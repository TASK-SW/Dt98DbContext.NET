using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities;

public class ArticleKitSetConfiguration : IEntityTypeConfiguration<ArticleKitSet>
{
    #region Public Methods

    public void Configure(EntityTypeBuilder<ArticleKitSet> builder)
    {
        builder.ToTable("ARTICLEKITSET");

        builder.HasKey(a => new { a.OidParent, a.OidChild });

        builder.Property(a => a.OidParent)
            .HasColumnName("OID_PARENT");

        builder.Property(a => a.OidChild)
            .HasColumnName("OID_CHILD");

        builder.Property(a => a.Count)
            .HasColumnName("COUNT");
    }

    #endregion Public Methods
}