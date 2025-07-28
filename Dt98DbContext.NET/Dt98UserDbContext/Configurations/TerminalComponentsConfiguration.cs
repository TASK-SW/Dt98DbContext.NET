
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities;

namespace Configurations
{
    public class TerminalComponentsConfiguration : IEntityTypeConfiguration<TerminalComponents>
    {
        public void Configure(EntityTypeBuilder<TerminalComponents> builder)
        {
            builder.ToTable("_sptTERMINALCOMPONENTS");

            builder.HasKey(e => e.Oid);
            builder.Property(e => e.Oid).HasColumnName("OID");
            builder.Property(e => e.OidTerminal).HasColumnName("OID_TERMINAL");
            builder.Property(e => e.Id).HasColumnName("ID");
            builder.Property(e => e.IId).HasColumnName("IID");
            builder.Property(e => e.ClsId).HasColumnName("CLSID");
        }
    }
}
