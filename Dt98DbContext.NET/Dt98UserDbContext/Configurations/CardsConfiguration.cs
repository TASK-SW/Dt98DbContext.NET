using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Configurations
{
    public class CardsConfiguration : IEntityTypeConfiguration<Cards>
    {
        #region Public Methods

        public void Configure(EntityTypeBuilder<Cards> builder)
        {
            builder.ToTable("_sptCARDS");

            builder.HasKey(e => e.Oid);
            builder.Property(e => e.Oid).HasColumnName("OID");
            builder.Property(e => e.OidType).HasColumnName("OID_TYPE");
            builder.Property(e => e.OidTerminal).HasColumnName("OID_TERMINAL");
            builder.Property(e => e.Id).HasColumnName("ID");
            builder.Property(e => e.State).HasColumnName("STATE");
            builder.Property(e => e.RecState).HasColumnName("RECSTATE");
            builder.Property(e => e.OidCardHandling).HasColumnName("OID_CARDHANDLING");
            builder.Property(e => e.OidPaymentType).HasColumnName("OID_PAYMENTTYPE");
        }

        #endregion Public Methods
    }
}