
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Configurations
{
    public class PaymentTypesConfiguration : IEntityTypeConfiguration<PaymentTypes>
    {
        public void Configure(EntityTypeBuilder<PaymentTypes> builder)
        {
            builder.ToTable("_sctPAYMENTTYPES");

            builder.HasKey(e => e.Oid);
            builder.Property(e => e.Oid).HasColumnName("OID");
            builder.Property(e => e.Name).HasColumnName("NAME");
        }
    }
}
