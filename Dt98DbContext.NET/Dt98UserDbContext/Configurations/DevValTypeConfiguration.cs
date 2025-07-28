using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities;

namespace Configurations
{
    public class DevValTypeConfiguration : IEntityTypeConfiguration<DevValType>
    {
        #region Public Methods

        public void Configure(EntityTypeBuilder<DevValType> builder)
        {
            builder.ToTable("DEV_VALTYPE");

            builder.HasKey(e => e.IdValType);

            builder.Property(e => e.IdValType).HasColumnName("ID_VAL_TYPE");
            builder.Property(e => e.NmValType).HasColumnName("NM_VAL_TYPE");

            builder.HasMany(e => e.DevSettings)
                .WithOne(s => s.ValType)
                .HasForeignKey(s => s.TypDevSet)
                .OnDelete(DeleteBehavior.Restrict);
        }

        #endregion Public Methods
    }
}