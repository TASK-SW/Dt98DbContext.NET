
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Configurations
{
    public class TrxFileTypesConfiguration : IEntityTypeConfiguration<TrxFileTypes>
    {
        public void Configure(EntityTypeBuilder<TrxFileTypes> builder)
        {
            builder.ToTable("_sctTRXFILETYPES");

            builder.HasKey(e => e.OidTrxFileTypes);
            builder.Property(e => e.OidTrxFileTypes).HasColumnName("OID");
            builder.Property(e => e.Id).HasColumnName("ID");
            builder.Property(e => e.Name).HasColumnName("NAME");
            builder.Property(e => e.IId).HasColumnName("IID");
            builder.Property(e => e.ClsId).HasColumnName("CLSID");
        }
    }
}
