
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Configurations
{
    public class sptTrxFilesConfiguration : IEntityTypeConfiguration<sptTrxFiles>
    {
        public void Configure(EntityTypeBuilder<sptTrxFiles> builder)
        {
            builder.ToTable("_sptTRXFILES");

            builder.HasKey(e => e.Oid);
            builder.Property(e => e.Oid).HasColumnName("OID");
            builder.Property(e => e.OidType).HasColumnName("OID_TYPE");
            builder.Property(e => e.Id).HasColumnName("ID");
            builder.Property(e => e.ResetDate).HasColumnName("RESETDATE");
        }
    }
}
