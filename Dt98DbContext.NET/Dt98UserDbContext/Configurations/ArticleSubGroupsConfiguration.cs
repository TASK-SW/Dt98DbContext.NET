using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Configurations;

public class ArticleSubGroupsConfiguration : IEntityTypeConfiguration<ArticleSubGroups>
{
    #region Public Methods

    public void Configure(EntityTypeBuilder<ArticleSubGroups> builder)
    {
        builder.ToTable("ARTICLESUBGROUPS");

        builder.HasKey(a => a.OidSubGroups);

        builder.Property(a => a.OidSubGroups).HasColumnName("OID");
        builder.Property(a => a.OidArtGrp).HasColumnName("OID_ARTGRP");
        builder.Property(a => a.Id).HasColumnName("ID");
        builder.Property(a => a.Name).HasColumnName("NAME");
        builder.Property(a => a.Minage).HasColumnName("MIN_AGE");

        builder.HasOne(sg => sg.Group)
            .WithMany(g => g.SubGroups)
            .HasForeignKey(sg => sg.OidArtGrp);

        builder.HasMany(sg => sg.Articles)
            .WithOne(a => a.SubGroup)
            .HasForeignKey(a => a.OidArtSubGrp);
    }

    #endregion Public Methods
}