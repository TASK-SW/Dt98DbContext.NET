
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Configurations
{
    public class CardTypesConfiguration : IEntityTypeConfiguration<CardTypes>
    {
        public void Configure(EntityTypeBuilder<CardTypes> builder)
        {
            builder.ToTable("_sctCARDTYPES");

            builder.HasKey(e => e.Oid);
            builder.Property(e => e.Oid).HasColumnName("OID");
            builder.Property(e => e.Id).HasColumnName("ID");
            builder.Property(e => e.Name).HasColumnName("NAME");
            builder.Property(e => e.ShortName).HasColumnName("SHORTNAME");
            builder.Property(e => e.IId).HasColumnName("IID");
            builder.Property(e => e.ClsId).HasColumnName("CLSID");
            builder.Property(e => e.IIdLayout).HasColumnName("IID_LAYOUT");
            builder.Property(e => e.ClsIdLayout).HasColumnName("CLSID_LAYOUT");
            builder.Property(e => e.OidCardBaseType).HasColumnName("OID_CARDBASETYPE");
            builder.Property(e => e.IIdManualCardDlg).HasColumnName("IID_MANUALCARDDLG");
            builder.Property(e => e.ClsIdManualCardDlg).HasColumnName("CLSID_MANUALCARDDLG");
        }
    }
}
