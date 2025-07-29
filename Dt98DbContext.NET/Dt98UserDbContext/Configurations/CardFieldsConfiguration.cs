
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Configurations
{
    public class CardFieldsConfiguration : IEntityTypeConfiguration<CardFields>
    {
        public void Configure(EntityTypeBuilder<CardFields> builder)
        {
            builder.ToTable("_sptCARDFIELDS");

            builder.HasKey(e => e.Oid);
            builder.Property(e => e.Oid).HasColumnName("OID");
            builder.Property(e => e.OidType).HasColumnName("OID_TYPE");
            builder.Property(e => e.FieldId).HasColumnName("FIELDID");
            builder.Property(e => e.Position).HasColumnName("POSITION");
            builder.Property(e => e.Length).HasColumnName("LENGTH");
            builder.Property(e => e.CheckOption).HasColumnName("CHECKOPTION");
            builder.Property(e => e.MinSize).HasColumnName("MINSIZE");
            builder.Property(e => e.MaxSize).HasColumnName("MAXSIZE");
            builder.Property(e => e.TextId).HasColumnName("TEXTID");
        }
    }
}
