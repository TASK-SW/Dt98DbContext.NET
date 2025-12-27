using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Configurations
{
    public class persNozzlesConfiguration : IEntityTypeConfiguration<persNozzles>
    {
        #region Public Methods

        public void Configure(EntityTypeBuilder<persNozzles> builder)
        {
            builder.ToTable("_persNOZZLES");

            builder.HasKey(e => e.Oid);
            builder.Property(e => e.Oid).HasColumnName("OID");
            builder.Property(e => e.Volume).HasColumnName("VOLUME");
            builder.Property(e => e.Amount).HasColumnName("AMOUNT");
        }

        #endregion Public Methods
    }
}