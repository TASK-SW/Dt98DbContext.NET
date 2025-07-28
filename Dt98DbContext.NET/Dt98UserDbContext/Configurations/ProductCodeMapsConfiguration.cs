
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities;

namespace Configurations
{
    public class ProductCodeMapsConfiguration : IEntityTypeConfiguration<ProductCodeMaps>
    {
        public void Configure(EntityTypeBuilder<ProductCodeMaps> builder)
        {
            builder.ToTable("_sptPRODUCTCODEMAPS");

            builder.HasKey(e => new { e.Id, e.IntCode });
            builder.Property(e => e.Id).HasColumnName("ID");
            builder.Property(e => e.IntCode).HasColumnName("INTCODE");
            builder.Property(e => e.ExtCode).HasColumnName("EXTCODE");
        }
    }
}
