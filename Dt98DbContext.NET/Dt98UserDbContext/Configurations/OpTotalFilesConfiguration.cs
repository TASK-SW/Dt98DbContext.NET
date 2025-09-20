using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Configurations
{
    public class OpTotalFilesConfiguration : IEntityTypeConfiguration<OpTotalFiles>
    {
        #region Public Methods

        public void Configure(EntityTypeBuilder<OpTotalFiles> builder)
        {
            builder.ToTable("OPTOTALFILES");

            builder.HasKey(e => e.Oid);
            builder.Property(e => e.Oid).HasColumnName("OID");
            builder.Property(e => e.StartDate).HasColumnName("STARTDATE");
            builder.Property(e => e.ActualGen).HasColumnName("ACTUALGEN");
            builder.Property(e => e.DelivGen).HasColumnName("DELIVGEN");
            builder.Property(e => e.DtVersion).HasColumnName("DT_VERSION");
        }

        #endregion Public Methods
    }
}