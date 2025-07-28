
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities;

namespace Configurations
{
    public class sptIssuerListsConfiguration : IEntityTypeConfiguration<sptIssuerLists>
    {
        public void Configure(EntityTypeBuilder<sptIssuerLists> builder)
        {
            builder.ToTable("_sptISSUERLISTS");

            builder.HasKey(e => e.Oid);
            builder.Property(e => e.Oid).HasColumnName("OID");
            builder.Property(e => e.OidType).HasColumnName("OID_TYPE");
            builder.Property(e => e.Name).HasColumnName("NAME");
        }
    }
}
