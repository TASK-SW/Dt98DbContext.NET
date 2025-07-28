
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities;

namespace Configurations
{
    public class PumpTypesConfiguration : IEntityTypeConfiguration<PumpTypes>
    {
        public void Configure(EntityTypeBuilder<PumpTypes> builder)
        {
            builder.ToTable("_sctPUMPTYPES");

            builder.HasKey(e => e.Oid);
            builder.Property(e => e.Oid).HasColumnName("OID");
            builder.Property(e => e.Id).HasColumnName("ID");
            builder.Property(e => e.Name).HasColumnName("NAME");
            builder.Property(e => e.IId).HasColumnName("IID");
            builder.Property(e => e.ClsId).HasColumnName("CLSID");
        }
    }
}
