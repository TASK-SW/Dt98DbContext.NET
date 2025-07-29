using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Configurations
{
    public class TaxesConfiguration : IEntityTypeConfiguration<Taxes>
    {
        #region Public Methods

        public void Configure(EntityTypeBuilder<Taxes> builder)
        {
            builder.ToTable("TAXES");

            builder.HasKey(e => e.OidTaxes);
            builder.Property(e => e.OidTaxes).HasColumnName("OID");
            builder.Property(e => e.Id).HasColumnName("ID");
            builder.Property(e => e.Name).HasColumnName("NAME");
            builder.Property(e => e.Tax).HasColumnName("TAX");

            builder.HasMany(t => t.Articles)
                .WithOne(a => a.Tax)
                .HasForeignKey(a => a.OidTax);
        }

        #endregion Public Methods
    }
}