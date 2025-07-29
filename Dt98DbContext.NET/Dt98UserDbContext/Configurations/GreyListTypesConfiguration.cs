
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Configurations
{
    public class GreyListTypesConfiguration : IEntityTypeConfiguration<GreyListTypes>
    {
        public void Configure(EntityTypeBuilder<GreyListTypes> builder)
        {
            builder.ToTable("_sctGREYLISTTYPES");

            builder.HasKey(e => e.Oid);
            builder.Property(e => e.Oid).HasColumnName("OID");
            builder.Property(e => e.Id).HasColumnName("ID");
            builder.Property(e => e.Name).HasColumnName("NAME");
            builder.Property(e => e.IId).HasColumnName("IID");
            builder.Property(e => e.ClsId).HasColumnName("CLSID");
        }
    }
}
