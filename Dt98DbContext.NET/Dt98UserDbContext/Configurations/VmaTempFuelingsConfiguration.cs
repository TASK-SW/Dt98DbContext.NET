
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Configurations
{
    public class VmaTempFuelingsConfiguration : IEntityTypeConfiguration<VmaTempFuelings>
    {
        public void Configure(EntityTypeBuilder<VmaTempFuelings> builder)
        {
            builder.ToTable("VMA_TempFuelings");

            builder.HasKey(e => e.Oid);
            builder.Property(e => e.Oid).HasColumnName("OID");
            builder.Property(e => e.EntryTime).HasColumnName("EntryTime");
            builder.Property(e => e.FuelingTime).HasColumnName("FuelingTime");
            builder.Property(e => e.ProductId).HasColumnName("ProductId");
            builder.Property(e => e.FuelPointId).HasColumnName("FuelPointId");
            builder.Property(e => e.NozzleId).HasColumnName("NozzleId");
            builder.Property(e => e.ProcessingState).HasColumnName("ProcessingState");
            builder.Property(e => e.Amount).HasColumnName("Amount");
            builder.Property(e => e.Volume).HasColumnName("Volume");
            builder.Property(e => e.TankConfig).HasColumnName("TankConfig");
        }
    }
}
