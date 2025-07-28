
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities;

namespace Configurations
{
    public class ProductCodeGroupsConfiguration : IEntityTypeConfiguration<ProductCodeGroups>
    {
        public void Configure(EntityTypeBuilder<ProductCodeGroups> builder)
        {
            builder.ToTable("_sptPRODUCTCODEGROUPS");

            builder.HasKey(e => e.Oid);
            builder.Property(e => e.Oid).HasColumnName("OID");
            builder.Property(e => e.Id).HasColumnName("ID");
            builder.Property(e => e.Description).HasColumnName("DESCRIPTION");
            builder.Property(e => e.FixedVat).HasColumnName("FIXED_VAT");
        }
    }
}
