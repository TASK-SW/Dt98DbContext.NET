
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities;

namespace Configurations
{
    public class DevSettingConfiguration : IEntityTypeConfiguration<DevSetting>
    {
        public void Configure(EntityTypeBuilder<DevSetting> builder)
        {
            builder.ToTable("DEV_SETTING");

            builder.HasKey(e => new { e.IdDevCfg, e.ValDevSet });
            builder.Property(e => e.IdDevCfg).HasColumnName("ID_DEV_CFG");
            builder.Property(e => e.ValDevSet).HasColumnName("VAL_DEV_SET");
            builder.Property(e => e.TypDevSet).HasColumnName("TYP_DEV_SET");
            builder.Property(e => e.IdDevSet).HasColumnName("ID_DEV_SET");
        }
    }
}
