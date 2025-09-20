using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Configurations
{
    public class HostTypesConfiguration : IEntityTypeConfiguration<HostTypes>
    {
        #region Public Methods

        public void Configure(EntityTypeBuilder<HostTypes> builder)
        {
            builder.ToTable("_sctHOSTTYPES");

            builder.HasKey(e => e.Oid);
            builder.Property(e => e.Oid).HasColumnName("OID");
            builder.Property(e => e.Name).HasColumnName("NAME");
        }

        #endregion Public Methods
    }
}