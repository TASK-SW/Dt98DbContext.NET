
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Configurations
{
    public class CardBaseTypesConfiguration : IEntityTypeConfiguration<CardBaseTypes>
    {
        public void Configure(EntityTypeBuilder<CardBaseTypes> builder)
        {
            builder.ToTable("_sctCARDBASETYPES");

            builder.HasKey(e => e.Oid);
            builder.Property(e => e.Oid).HasColumnName("OID");
            builder.Property(e => e.Name).HasColumnName("NAME");
        }
    }
}
