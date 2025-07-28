
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities;

namespace Configurations
{
    public class RedList029Configuration : IEntityTypeConfiguration<RedList029>
    {
        public void Configure(EntityTypeBuilder<RedList029> builder)
        {
            builder.ToTable("REDLIST029");

            builder.HasKey(e => e.Pan);
            builder.Property(e => e.Pan).HasColumnName("PAN");
            builder.Property(e => e.Count).HasColumnName("COUNT");
            builder.Property(e => e.EditDate).HasColumnName("EDITDATE");
        }
    }
}
