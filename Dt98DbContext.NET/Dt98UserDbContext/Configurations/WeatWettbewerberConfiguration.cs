
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities;

namespace Configurations
{
    public class WeatWettbewerberConfiguration : IEntityTypeConfiguration<WeatWettbewerber>
    {
        public void Configure(EntityTypeBuilder<WeatWettbewerber> builder)
        {
            builder.ToTable("WEAT_Wettbewerber");

            builder.HasKey(e => e.Oid);
            builder.Property(e => e.Oid).HasColumnName("OID");
            builder.Property(e => e.Competitor).HasColumnName("Competitor");
            builder.Property(e => e.CompanyNo).HasColumnName("CompanyNo");
            builder.Property(e => e.Location).HasColumnName("Location");
            builder.Property(e => e.Street).HasColumnName("Street");
            builder.Property(e => e.Zip).HasColumnName("ZIP");
            builder.Property(e => e.City).HasColumnName("City");
            builder.Property(e => e.Product01).HasColumnName("Product_01");
            builder.Property(e => e.Product02).HasColumnName("Product_02");
            builder.Property(e => e.Product03).HasColumnName("Product_03");
            builder.Property(e => e.Product04).HasColumnName("Product_04");
            builder.Property(e => e.Product05).HasColumnName("Product_05");
            builder.Property(e => e.Product06).HasColumnName("Product_06");
            builder.Property(e => e.Product07).HasColumnName("Product_07");
            builder.Property(e => e.Product08).HasColumnName("Product_08");
            builder.Property(e => e.Product09).HasColumnName("Product_09");
            builder.Property(e => e.Product10).HasColumnName("Product_10");
            builder.Property(e => e.Product11).HasColumnName("Product_11");
            builder.Property(e => e.Product12).HasColumnName("Product_12");
            builder.Property(e => e.Product13).HasColumnName("Product_13");
            builder.Property(e => e.Product14).HasColumnName("Product_14");
            builder.Property(e => e.Product15).HasColumnName("Product_15");
        }
    }
}
