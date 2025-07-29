
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Configurations
{
    public class NormUnitsConfiguration : IEntityTypeConfiguration<NormUnits>
    {
        public void Configure(EntityTypeBuilder<NormUnits> builder)
        {
            builder.ToTable("_sctNORMUNITS");

            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).HasColumnName("ID");
            builder.Property(e => e.NormUnitName).HasColumnName("NORM_UNIT_NAME");
            builder.Property(e => e.NormBaseQuantity).HasColumnName("NORM_BASE_QUANTITY");
        }
    }
}
