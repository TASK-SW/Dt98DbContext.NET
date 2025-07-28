
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities;

namespace Configurations
{
    public class TankTransactionsConfiguration : IEntityTypeConfiguration<TankTransactions>
    {
        public void Configure(EntityTypeBuilder<TankTransactions> builder)
        {
            builder.ToTable("TankTransactions");

            builder.HasKey(e => e.PkId);
            builder.Property(e => e.PkId).HasColumnName("PkId");
            builder.Property(e => e.TrxDate).HasColumnName("TrxDate");
            builder.Property(e => e.TrxType).HasColumnName("TrxType");
            builder.Property(e => e.TankId).HasColumnName("TankId");
            builder.Property(e => e.ProductId).HasColumnName("ProductId");
            builder.Property(e => e.Quantity).HasColumnName("Quantity");
            builder.Property(e => e.Info).HasColumnName("Info");
        }
    }
}
