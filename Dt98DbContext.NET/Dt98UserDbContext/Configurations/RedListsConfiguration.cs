using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Configurations
{
    public class RedListsConfiguration : IEntityTypeConfiguration<RedLists>
    {
        #region Public Methods

        public void Configure(EntityTypeBuilder<RedLists> builder)
        {
            builder.ToTable("_sptREDLISTS");

            builder.HasKey(e => e.Oid);
            builder.Property(e => e.Oid).HasColumnName("OID");
            builder.Property(e => e.OidType).HasColumnName("OID_TYPE");
            builder.Property(e => e.Id).HasColumnName("ID");
            builder.Property(e => e.ResetDate).HasColumnName("RESETDATE");
        }

        #endregion Public Methods
    }
}