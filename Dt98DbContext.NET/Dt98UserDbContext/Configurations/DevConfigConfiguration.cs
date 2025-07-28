
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities;

namespace Configurations
{
    public class DevConfigConfiguration : IEntityTypeConfiguration<DevConfig>
    {
        public void Configure(EntityTypeBuilder<DevConfig> builder)
        {
            builder.ToTable("DEV_CONFIG");

            builder.HasKey(e => e.IdDevCfg);
            builder.Property(e => e.IdDevCfg).HasColumnName("ID_DEV_CFG");
            builder.Property(e => e.IdDevTyp).HasColumnName("ID_DEV_TYP");
            builder.Property(e => e.IdDevCls).HasColumnName("ID_DEV_CLS");
            builder.Property(e => e.IdDevPar).HasColumnName("ID_DEV_PAR");
        }
    }
}
