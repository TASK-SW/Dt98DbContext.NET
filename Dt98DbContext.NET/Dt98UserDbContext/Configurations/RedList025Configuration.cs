using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Configurations
{
    public class RedList025Configuration : IEntityTypeConfiguration<RedList025>
    {
        #region Public Methods

        public void Configure(EntityTypeBuilder<RedList025> builder)
        {
            builder.ToTable("REDLIST025");

            builder.HasKey(e => e.Pan);
            builder.Property(e => e.Pan).HasColumnName("PAN");
            builder.Property(e => e.Count).HasColumnName("COUNT");
            builder.Property(e => e.EditDate).HasColumnName("EDITDATE");
        }

        #endregion Public Methods
    }
}