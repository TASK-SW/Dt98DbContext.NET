using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities;

namespace Configurations
{
    public class DevSettingConfiguration : IEntityTypeConfiguration<DevSetting>
    {
        #region Public Methods

        public void Configure(EntityTypeBuilder<DevSetting> builder)
        {
            builder.ToTable("DEV_SETTING");

            builder.HasKey(e => e.IdDevSet);

            builder.Property(e => e.IdDevSet).HasColumnName("ID_DEV_SET");
            builder.Property(e => e.IdDevCfg).HasColumnName("ID_DEV_CFG");
            builder.Property(e => e.TypDevSet).HasColumnName("TYP_DEV_SET");
            builder.Property(e => e.ValDevSet).HasColumnName("VAL_DEV_SET");

            builder.HasOne(setting => setting.DevConfig)
                .WithMany(cfg => cfg.DevSettings)
                .HasForeignKey(setting => setting.IdDevCfg)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(setting => setting.ValType)
                .WithMany(vt => vt.DevSettings)
                .HasForeignKey(setting => setting.TypDevSet)
                .OnDelete(DeleteBehavior.Restrict);
        }

        #endregion Public Methods
    }
}