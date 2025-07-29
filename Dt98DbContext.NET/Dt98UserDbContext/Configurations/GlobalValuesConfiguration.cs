
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Configurations
{
    public class GlobalValuesConfiguration : IEntityTypeConfiguration<GlobalValues>
    {
        public void Configure(EntityTypeBuilder<GlobalValues> builder)
        {
            builder.ToTable("_sptGLOBALVALUES");

            builder.HasKey(e => e.Oid);
            builder.Property(e => e.Oid).HasColumnName("OID");
            builder.Property(e => e.DtValue).HasColumnName("DT_VALUE");
        }
    }
}
