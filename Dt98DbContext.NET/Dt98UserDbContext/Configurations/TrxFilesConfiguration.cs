
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Configurations
{
    public class TrxFilesConfiguration : IEntityTypeConfiguration<TrxFiles>
    {
        public void Configure(EntityTypeBuilder<TrxFiles> builder)
        {
            builder.ToTable("TRXFILES");

            builder.HasKey(e => e.OidTrxFiles);
            builder.Property(e => e.OidTrxFiles).HasColumnName("OID");
            builder.Property(e => e.DtSequence).HasColumnName("DT_SEQUENCE");
            builder.Property(e => e.DtResetDate).HasColumnName("DT_RESETDATE");
            builder.Property(e => e.DtActNum).HasColumnName("DT_ACTNUM");
            builder.Property(e => e.DtPASNum).HasColumnName("DT_PASNUM");
            builder.Property(e => e.DtVersion).HasColumnName("DT_VERSION");
            builder.Property(e => e.DtLastTrxDate).HasColumnName("DT_LASTTRXDATE");
        }
    }
}
