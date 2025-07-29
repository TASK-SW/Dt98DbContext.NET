using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Configurations
{
    public class DevTypeConfiguration : IEntityTypeConfiguration<DevType>
    {
        #region Public Methods

        public void Configure(EntityTypeBuilder<DevType> builder)
        {
            builder.ToTable("DEV_TYPE");

            // 🧩 Составной первичный ключ
            builder.HasKey(e => new { e.IdDevTyp, e.IdDevCls });

            builder.Property(e => e.IdDevTyp).HasColumnName("ID_DEV_TYP");
            builder.Property(e => e.IdDevCls).HasColumnName("ID_DEV_CLS");
            builder.Property(e => e.NmdevTyp).HasColumnName("NM_DEV_TYP");
            builder.Property(e => e.ClsIdDevTyp).HasColumnName("CLSID_DEV_TYP");

            // 🔗 Указываем внешний ключ с соответствующим составному ключу
            builder.HasMany(e => e.DevConfigs)
                .WithOne(cfg => cfg.DevType)
                .HasForeignKey(cfg => new { cfg.IdDevTyp, cfg.IdDevCls })                 // 👈 внешний ключ
                .HasPrincipalKey(e => new { e.IdDevTyp, e.IdDevCls });                    // 👈 основной ключ
        }

        #endregion Public Methods
    }
}