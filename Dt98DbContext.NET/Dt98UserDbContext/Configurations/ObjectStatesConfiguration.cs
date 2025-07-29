
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Configurations
{
    public class ObjectStatesConfiguration : IEntityTypeConfiguration<ObjectStates>
    {
        public void Configure(EntityTypeBuilder<ObjectStates> builder)
        {
            builder.ToTable("OBJECTSTATES");

            builder.HasKey(e => new { e.Objtype, e.ObjId, e.PArtype, e.ParId, e.State, e.ObjStateIX });
            builder.Property(e => e.Objtype).HasColumnName("OBJTYPE");
            builder.Property(e => e.ObjId).HasColumnName("OBJID");
            builder.Property(e => e.PArtype).HasColumnName("PARTYPE");
            builder.Property(e => e.ParId).HasColumnName("PARID");
            builder.Property(e => e.State).HasColumnName("STATE");
            builder.Property(e => e.ObjStateIX).HasColumnName("Order = 4");
        }
    }
}
