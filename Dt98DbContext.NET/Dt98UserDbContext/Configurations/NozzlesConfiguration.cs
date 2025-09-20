using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Configurations
{
    public class NozzlesConfiguration : IEntityTypeConfiguration<Nozzles>
    {
        #region Public Methods

        public void Configure(EntityTypeBuilder<Nozzles> builder)
        {
            builder.ToTable("_sptNOZZLES");

            builder.HasKey(e => e.Oid);
            builder.Property(e => e.Oid).HasColumnName("OID");
            builder.Property(e => e.OidType).HasColumnName("OID_TYPE");
            builder.Property(e => e.OidFuelIngPoint).HasColumnName("OID_FUELINGPOINT");
            builder.Property(e => e.OidTank).HasColumnName("OID_TANK");
            builder.Property(e => e.Id).HasColumnName("ID");
        }

        #endregion Public Methods
    }
}