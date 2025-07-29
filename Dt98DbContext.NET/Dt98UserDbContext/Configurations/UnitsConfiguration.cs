
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Configurations
{
    public class UnitsConfiguration : IEntityTypeConfiguration<Units>
    {
        public void Configure(EntityTypeBuilder<Units> builder)
        {
            builder.ToTable("_sctUNITS");

            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).HasColumnName("ID");
            builder.Property(e => e.Name).HasColumnName("NAME");
            builder.Property(e => e.ShortCut).HasColumnName("SHORTCUT");
            builder.Property(e => e.Decimals).HasColumnName("DECIMALS");
        }
    }
}
