
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Configurations
{
    public class TerminalSettingsConfiguration : IEntityTypeConfiguration<TerminalSettings>
    {
        public void Configure(EntityTypeBuilder<TerminalSettings> builder)
        {
            builder.ToTable("_sptTERMINALSETTINGS");

            builder.HasKey(e => e.Oid);
            builder.Property(e => e.Oid).HasColumnName("OID");
            builder.Property(e => e.OidTerminalComponent).HasColumnName("OID_TERMINALCOMPONENT");
            builder.Property(e => e.Id).HasColumnName("ID");
            builder.Property(e => e.Value).HasColumnName("VALUE");
            builder.Property(e => e.Type).HasColumnName("TYPE");
        }
    }
}
