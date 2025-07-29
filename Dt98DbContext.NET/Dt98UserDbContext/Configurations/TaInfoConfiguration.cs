
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Configurations
{
    public class TaInfoConfiguration : IEntityTypeConfiguration<TaInfo>
    {
        public void Configure(EntityTypeBuilder<TaInfo> builder)
        {
            builder.ToTable("TA_INFO");

            builder.HasKey(e => e.Oid);
            builder.Property(e => e.Oid).HasColumnName("OID");
            builder.Property(e => e.AppId).HasColumnName("APP_ID");
            builder.Property(e => e.RecId).HasColumnName("REC_ID");
            builder.Property(e => e.DtTimeStamp).HasColumnName("DT_TIMESTAMP");
            builder.Property(e => e.FileName).HasColumnName("FILENAME");
            builder.Property(e => e.Status).HasColumnName("STATUS");
            builder.Property(e => e.Content).HasColumnName("CONTENT");
        }
    }
}
