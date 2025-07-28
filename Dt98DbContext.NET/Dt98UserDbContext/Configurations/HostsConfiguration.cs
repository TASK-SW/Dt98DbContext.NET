
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities;

namespace Configurations
{
    public class HostsConfiguration : IEntityTypeConfiguration<Hosts>
    {
        public void Configure(EntityTypeBuilder<Hosts> builder)
        {
            builder.ToTable("_sptHOSTS");

            builder.HasKey(e => e.Oid);
            builder.Property(e => e.Oid).HasColumnName("OID");
            builder.Property(e => e.OidType).HasColumnName("OID_TYPE");
            builder.Property(e => e.DtName).HasColumnName("DT_NAME");
            builder.Property(e => e.DtStationId).HasColumnName("DT_STATION_ID");
            builder.Property(e => e.DtIssuerListOid).HasColumnName("DT_ISSUERLIST_OID");
            builder.Property(e => e.DtFileIdMsd).HasColumnName("DT_FILEID_MSD");
            builder.Property(e => e.DtShortCut).HasColumnName("DT_SHORTCUT");
            builder.Property(e => e.DtApplicationId).HasColumnName("DT_APPLICATION_ID");
            builder.Property(e => e.DtInPath).HasColumnName("DT_INPATH");
            builder.Property(e => e.DtOutPath).HasColumnName("DT_OUTPATH");
            builder.Property(e => e.DtSlumPath).HasColumnName("DT_SLUMPATH");
            builder.Property(e => e.DtCardHandlingOid).HasColumnName("DT_CARDHANDLING_OID");
            builder.Property(e => e.DtCheckSystem).HasColumnName("DT_CHECK_SYSTEM");
            builder.Property(e => e.DtCheckAcceptance).HasColumnName("DT_CHECK_ACCEPTANCE");
            builder.Property(e => e.DtDelivErOpTotal).HasColumnName("DT_DELIVER_OPTOTAL");
            builder.Property(e => e.DtLoginName).HasColumnName("DT_LOGIN_NAME");
            builder.Property(e => e.DtApplicationType).HasColumnName("DT_APPLICATION_TYPE");
        }
    }
}
