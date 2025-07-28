using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities;

public class ArticleGroupsConfiguration : IEntityTypeConfiguration<ArticleGroups>
{
    #region Public Methods

    public void Configure(EntityTypeBuilder<ArticleGroups> builder)
    {
        builder.ToTable("ARTICLEGROUPS");

        builder.HasKey(a => a.Oid);

        builder.Property(a => a.Oid)
            .HasColumnName("OID");

        builder.Property(a => a.Id)
            .HasColumnName("ID");

        builder.Property(a => a.Name)
            .HasColumnName("NAME");
    }

    #endregion Public Methods
}