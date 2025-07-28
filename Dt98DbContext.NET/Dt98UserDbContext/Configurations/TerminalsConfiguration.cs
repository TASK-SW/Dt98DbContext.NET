
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities;

namespace Configurations
{
    public class TerminalsConfiguration : IEntityTypeConfiguration<Terminals>
    {
        public void Configure(EntityTypeBuilder<Terminals> builder)
        {
            builder.ToTable("_sptTERMINALS");

            builder.HasKey(e => e.Oid);
            builder.Property(e => e.Oid).HasColumnName("OID");
            builder.Property(e => e.OidType).HasColumnName("OID_TYPE");
            builder.Property(e => e.Id).HasColumnName("ID");
            builder.Property(e => e.Name).HasColumnName("NAME");
            builder.Property(e => e.State).HasColumnName("STATE");
            builder.Property(e => e.TermLanguage).HasColumnName("TERMLANGUAGE");
        }
    }
}
