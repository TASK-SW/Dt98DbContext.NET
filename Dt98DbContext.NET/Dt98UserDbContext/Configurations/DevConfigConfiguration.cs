using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities;

namespace Configurations
{
    public class DevConfigConfiguration : IEntityTypeConfiguration<DevConfig>
    {
        #region Public Methods

        public void Configure(EntityTypeBuilder<DevConfig> builder)
        {
            builder.ToTable("DEV_CONFIG");

            builder.HasKey(e => e.IdDevCfg);
            builder.Property(e => e.IdDevCfg).HasColumnName("ID_DEV_CFG");
            builder.Property(e => e.IdDevTyp).HasColumnName("ID_DEV_TYP");
            builder.Property(e => e.IdDevCls).HasColumnName("ID_DEV_CLS");
            builder.Property(e => e.IdDevPar).HasColumnName("ID_DEV_PAR");

            builder.HasOne(cfg => cfg.DevType)
                .WithMany(dt => dt.DevConfigs)
                .HasForeignKey(cfg => new { cfg.IdDevTyp, cfg.IdDevCls })
                .HasPrincipalKey(dt => new { dt.IdDevTyp, dt.IdDevCls });  // 👈 Добавляем это

            builder.HasOne(cfg => cfg.DevClass)
                .WithMany(dc => dc.DevConfigs)
                .HasForeignKey(cfg => cfg.IdDevCls);

            builder.HasOne(cfg => cfg.ParentConfig)
                .WithMany(parent => parent.ChildConfigs)
                .HasForeignKey(devPar => devPar.IdDevPar)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(cfg => cfg.DevSettings)
                .WithOne(setting => setting.DevConfig)
                .HasForeignKey(setting => setting.IdDevCfg)
                .OnDelete(DeleteBehavior.Cascade);
        }

        #endregion Public Methods
    }
}