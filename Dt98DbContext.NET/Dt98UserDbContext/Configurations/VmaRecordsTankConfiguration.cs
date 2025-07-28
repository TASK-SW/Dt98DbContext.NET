
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities;

namespace Configurations
{
    public class VmaRecordsTankConfiguration : IEntityTypeConfiguration<VmaRecordsTank>
    {
        public void Configure(EntityTypeBuilder<VmaRecordsTank> builder)
        {
            builder.ToTable("VMARECORDSTANK");

            builder.HasKey(e => new { e.ProductId, e.FuelpointId, e.NozzleId, e.TsBegin, e.TankId });
            builder.Property(e => e.ProductId).HasColumnName("ProductId");
            builder.Property(e => e.FuelpointId).HasColumnName("FuelpointId");
            builder.Property(e => e.NozzleId).HasColumnName("NozzleId");
            builder.Property(e => e.TsBegin).HasColumnName("TSBegin");
            builder.Property(e => e.TankId).HasColumnName("TankId");
            builder.Property(e => e.TankMeter).HasColumnName("TankMeter");
        }
    }
}
