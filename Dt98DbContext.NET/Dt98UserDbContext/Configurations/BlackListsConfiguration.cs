using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Configurations
{
    public class BlackListsConfiguration : IEntityTypeConfiguration<BlackLists>
    {
        #region Public Methods

        public void Configure(EntityTypeBuilder<BlackLists> builder)
        {
            builder.ToTable("_sptBLACKLISTS");

            builder.HasKey(b => b.Oid);

            builder.Property(b => b.Oid).HasColumnName("OID");
            builder.Property(b => b.OidType).HasColumnName("OID_TYPE");
            builder.Property(b => b.Id).HasColumnName("ID");
            builder.Property(b => b.Version).HasColumnName("VERSION");
            builder.Property(b => b.Validity).HasColumnName("VALIDITY");
            builder.Property(b => b.DownloadDate).HasColumnName("DOWNLOADDATE");
            builder.Property(b => b.GenNo).HasColumnName("GENNO");
            builder.Property(b => b.UpGenNo).HasColumnName("UPGENNO");
            builder.Property(b => b.GroupDownloadDate).HasColumnName("GROUPDOWNLOADDATE");
            builder.Property(b => b.DataComId).HasColumnName("DATACOM_ID");
            builder.Property(b => b.PanLength).HasColumnName("PAN_LENGTH");
            builder.Property(b => b.StripLength).HasColumnName("STRIP_LENGTH");
            builder.Property(b => b.ExpirationDays).HasColumnName("EXPIRATION_DAYS");
        }

        #endregion Public Methods
    }
}