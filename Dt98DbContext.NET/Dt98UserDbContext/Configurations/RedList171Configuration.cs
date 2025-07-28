
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities;

namespace Configurations
{
    public class RedList171Configuration : IEntityTypeConfiguration<RedList171>
    {
        public void Configure(EntityTypeBuilder<RedList171> builder)
        {
            builder.ToTable("REDLIST171");

            builder.HasKey(e => e.Pan);
            builder.Property(e => e.Pan).HasColumnName("PAN");
            builder.Property(e => e.Count).HasColumnName("COUNT");
            builder.Property(e => e.EditDate).HasColumnName("EDITDATE");
        }
    }
}
