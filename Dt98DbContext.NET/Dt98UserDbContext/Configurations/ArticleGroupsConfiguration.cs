using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Configurations;

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

        builder.HasMany(g => g.SubGroups)
            .WithOne(sg => sg.Group)
            .HasForeignKey(sg => sg.OidArtGrp);
    }

    #endregion Public Methods
}