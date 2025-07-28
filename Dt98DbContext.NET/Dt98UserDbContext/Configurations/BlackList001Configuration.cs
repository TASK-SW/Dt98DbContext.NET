using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Configurations
{
    public class BlackList001Configuration : IEntityTypeConfiguration<BlackList001>
    {
        #region Public Methods

        public void Configure(EntityTypeBuilder<BlackList001> builder)
        {
            builder.ToTable("BLACKLIST001");

            builder.HasKey(b => b.Oid);

            builder.Property(b => b.Oid)
                .HasColumnName("OID");

            builder.Property(b => b.OidBlackList)
                .HasColumnName("OID_BLACKLIST");

            builder.Property(b => b.LowerPan)
                .HasColumnName("LOWERPAN");

            builder.Property(b => b.UpperPan)
                .HasColumnName("UPPERPAN");

            builder.Property(b => b.WithDraw)
                .HasColumnName("WITHDRAW");

            builder.Property(b => b.Mutator)
                .HasColumnName("MUTATOR");
        }

        #endregion Public Methods
    }
}