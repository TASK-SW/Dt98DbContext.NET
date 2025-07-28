
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities;

namespace Configurations
{
    public class DevTypeConfiguration : IEntityTypeConfiguration<DevType>
    {
        public void Configure(EntityTypeBuilder<DevType> builder)
        {
            builder.ToTable("DEV_TYPE");

            builder.HasKey(e => new { e.IdDevTyp, e.IdDevCls });
            builder.Property(e => e.IdDevTyp).HasColumnName("ID_DEV_TYP");
            builder.Property(e => e.IdDevCls).HasColumnName("ID_DEV_CLS");
            builder.Property(e => e.NmdevTyp).HasColumnName("NM_DEV_TYP");
            builder.Property(e => e.ClsIdDevTyp).HasColumnName("CLSID_DEV_TYP");
        }
    }
}
