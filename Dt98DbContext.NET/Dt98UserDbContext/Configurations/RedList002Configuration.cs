
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities;

namespace Configurations
{
    public class RedList002Configuration : IEntityTypeConfiguration<RedList002>
    {
        public void Configure(EntityTypeBuilder<RedList002> builder)
        {
            builder.ToTable("REDLIST002");

            builder.HasKey(e => e.Pan);
            builder.Property(e => e.Pan).HasColumnName("PAN");
            builder.Property(e => e.Count).HasColumnName("COUNT");
            builder.Property(e => e.EditDate).HasColumnName("EDITDATE");
        }
    }
}
