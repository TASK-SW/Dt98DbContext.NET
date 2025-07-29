
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Configurations
{
    public class IssuerListsConfiguration : IEntityTypeConfiguration<IssuerLists>
    {
        public void Configure(EntityTypeBuilder<IssuerLists> builder)
        {
            builder.ToTable("ISSUERLISTS");

            builder.HasKey(e => e.Oid);
            builder.Property(e => e.Oid).HasColumnName("OID");
            builder.Property(e => e.DtVersion).HasColumnName("DT_VERSION");
            builder.Property(e => e.DtLastUpdate).HasColumnName("DT_LASTUPDATE");
        }
    }
}
