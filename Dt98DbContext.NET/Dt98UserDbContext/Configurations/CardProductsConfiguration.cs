using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Configurations
{
    public class CardProductsConfiguration : IEntityTypeConfiguration<CardProducts>
    {
        #region Public Methods

        public void Configure(EntityTypeBuilder<CardProducts> builder)
        {
            builder.ToTable("_sptCARDPRODUCTS");

            builder.HasKey(e => e.Oid);
            builder.Property(e => e.Oid).HasColumnName("OID");
            builder.Property(e => e.OidCardType).HasColumnName("OID_CARDTYPE");
            builder.Property(e => e.ServiceCode).HasColumnName("SERVICECODE");
            builder.Property(e => e.ServiceValue).HasColumnName("SERVICEVALUE");
            builder.Property(e => e.Products).HasColumnName("PRODUCTS");
        }

        #endregion Public Methods
    }
}