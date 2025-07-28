
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities;

namespace Configurations
{
    public class TankNetzConfiguration : IEntityTypeConfiguration<TankNetz>
    {
        public void Configure(EntityTypeBuilder<TankNetz> builder)
        {
            builder.ToTable("TankNetz");

            builder.HasKey(e => e.Oid);
            builder.Property(e => e.Oid).HasColumnName("OID");
            builder.Property(e => e.DateTime).HasColumnName("DateTime");
            builder.Property(e => e.JournalId).HasColumnName("JournalId");
            builder.Property(e => e.StationId).HasColumnName("StationId");
            builder.Property(e => e.TerminalId).HasColumnName("TerminalId");
            builder.Property(e => e.FirstCard).HasColumnName("FirstCard");
            builder.Property(e => e.SecondCard).HasColumnName("SecondCard");
            builder.Property(e => e.Mileage).HasColumnName("Mileage");
            builder.Property(e => e.AddInfo).HasColumnName("AddInfo");
            builder.Property(e => e.ArticleId).HasColumnName("ArticleId");
            builder.Property(e => e.FpId).HasColumnName("FPId");
            builder.Property(e => e.ProductType).HasColumnName("ProductType");
            builder.Property(e => e.Quantity).HasColumnName("Quantity");
            builder.Property(e => e.UnitPrice).HasColumnName("UnitPrice");
            builder.Property(e => e.Amount).HasColumnName("Amount");
            builder.Property(e => e.Nummerator).HasColumnName("Nummerator");
            builder.Property(e => e.Pin).HasColumnName("PIN");
            builder.Property(e => e.ArticleName).HasColumnName("ArticleName");
            builder.Property(e => e.TraceNo).HasColumnName("TraceNo");
        }
    }
}
