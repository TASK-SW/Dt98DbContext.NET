
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities;

namespace Configurations
{
    public class GreyListsConfiguration : IEntityTypeConfiguration<GreyLists>
    {
        public void Configure(EntityTypeBuilder<GreyLists> builder)
        {
            builder.ToTable("_sptGREYLISTS");

            builder.HasKey(e => e.Oid);
            builder.Property(e => e.Oid).HasColumnName("OID");
            builder.Property(e => e.OidType).HasColumnName("OID_TYPE");
            builder.Property(e => e.Id).HasColumnName("ID");
            builder.Property(e => e.GenNo).HasColumnName("GENNO");
            builder.Property(e => e.UpGenNo).HasColumnName("UPGENNO");
            builder.Property(e => e.Version).HasColumnName("VERSION");
            builder.Property(e => e.Validity).HasColumnName("VALIDITY");
            builder.Property(e => e.DownloadDate).HasColumnName("DOWNLOADDATE");
        }
    }
}
