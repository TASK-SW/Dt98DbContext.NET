using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Configurations
{
    public class CardFieldValuesConfiguration : IEntityTypeConfiguration<CardFieldValues>
    {
        #region Public Methods

        public void Configure(EntityTypeBuilder<CardFieldValues> builder)
        {
            builder.ToTable("_sptCARDFIELDVALUES");

            builder.HasKey(e => e.Oid);
            builder.Property(e => e.Oid).HasColumnName("OID");
            builder.Property(e => e.OidField).HasColumnName("OID_FIELD");
            builder.Property(e => e.Value).HasColumnName("VALUE");
            builder.Property(e => e.ClsId).HasColumnName("CLSID");
            builder.Property(e => e.IId).HasColumnName("IID");
            builder.Property(e => e.InternalCode).HasColumnName("INTERNALCODE");
        }

        #endregion Public Methods
    }
}