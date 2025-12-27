using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Configurations
{
    public class RedList003Configuration : IEntityTypeConfiguration<RedList003>
    {
        #region Public Methods

        public void Configure(EntityTypeBuilder<RedList003> builder)
        {
            builder.ToTable("REDLIST003");

            builder.HasKey(e => e.Pan);
            builder.Property(e => e.Pan).HasColumnName("PAN");
            builder.Property(e => e.Count).HasColumnName("COUNT");
            builder.Property(e => e.EditDate).HasColumnName("EDITDATE");
        }

        #endregion Public Methods
    }
}