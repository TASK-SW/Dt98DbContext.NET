
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Configurations
{
    public class ObjectTypesConfiguration : IEntityTypeConfiguration<ObjectTypes>
    {
        public void Configure(EntityTypeBuilder<ObjectTypes> builder)
        {
            builder.ToTable("_sctOBJECTTYPES");

            builder.HasKey(e => e.Objtype);
            builder.Property(e => e.Objtype).HasColumnName("OBJTYPE");
            builder.Property(e => e.ObjtypeName).HasColumnName("OBJTYPENAME");
        }
    }
}
