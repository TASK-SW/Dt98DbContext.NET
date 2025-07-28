using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities;

namespace Configurations
{
    public class DevClassConfiguration : IEntityTypeConfiguration<DevClass>
    {
        #region Public Methods

        public void Configure(EntityTypeBuilder<DevClass> builder)
        {
            builder.ToTable("DEV_CLASS");

            builder.HasKey(e => e.IdDevCls);
            builder.Property(e => e.IdDevCls).HasColumnName("ID_DEV_CLS");
            builder.Property(e => e.NmdevCls).HasColumnName("NM_DEV_CLS");

            builder.HasMany(x => x.DevConfigs)
                .WithOne(x => x.DevClass)
                .HasForeignKey(x => x.IdDevCls);
        }

        #endregion Public Methods
    }
}