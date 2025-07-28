
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities;

namespace Configurations
{
    public class VmaHostStatesConfiguration : IEntityTypeConfiguration<VmaHostStates>
    {
        public void Configure(EntityTypeBuilder<VmaHostStates> builder)
        {
            builder.ToTable("VMA_HostStates");

            builder.HasKey(e => new { e.HostId, e.StateKey });
            builder.Property(e => e.HostId).HasColumnName("HostId");
            builder.Property(e => e.StateKey).HasColumnName("StateKey");
            builder.Property(e => e.StateValue).HasColumnName("StateValue");
        }
    }
}
